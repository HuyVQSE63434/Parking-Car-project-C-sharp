using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using winformProject.DAO;
using winformProject.DTO;
using winformProject.Utis;

namespace winformProject.GUI
{
    public partial class AddNewEmpForm : Form
    {
        private UserIF data= new UserIF();
        public Boolean done = false;
        public bool cancel = false; 
        private static AddNewEmpForm instance;
        internal UserIF UserData { get => data; set => data = value; }
        private EmployeeForm parent;
        public static AddNewEmpForm getInstance(EmployeeForm pForm)
        {
            if(instance != null)
            {
                return instance;
            }
            else
            {
                return instance = new AddNewEmpForm(pForm);
            }
        }
        private AddNewEmpForm(EmployeeForm pForm)
        {
            InitializeComponent();
            //MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            //skinmanager.AddFormToManage(this);
            //skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue400,
            //    MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500,
            //    MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            this.parent = pForm;
            MemoryStream msImage;
            WebClient wcImage = new WebClient();
            msImage = new MemoryStream(wcImage.DownloadData("http://farm9.staticflickr.com/8130/29541772703_6ed8b50c47_b.jpg"));
            pictureBox1.Image = Image.FromStream(msImage);
        }

        private void AddNewEmpForm_Load(object sender, EventArgs e)
        {
            string[] roles = UserDAO.GetAllRole();
            foreach (var item in roles)
            {
                if(!comboBoxRole.Items.Contains(item))
                comboBoxRole.Items.Add(item);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.InitialDirectory = "D:\\";
            if(of.ShowDialog() == DialogResult.OK)
            {
                Image im = Image.FromFile(of.FileName);
                pictureBox1.Image = im;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool check = ValidationFeild();
            if(check == true)
            {
                tblAccount ac = new tblAccount();
                tblUser user = new tblUser();
                ac.userID = user.userID =data.userId = txtUserId.Text;
                ac.password = txtPassword.Text;
                ac.roleName = data.role =comboBoxRole.SelectedItem.ToString();
                ac.status = data.status ="activated";
                user.firstName = data.firstName =txtFirstName.Text;
                user.lastName = data.lastName =txtLastName.Text;
                user.mail= data.mail = txtEmail.Text;
                user.phoneNumber = data.phoneNum = txtPhoneNum.Text;
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                user.image = ms.ToArray();
                data.SetImage(ms.ToArray());
                UserDAO dao = new UserDAO();
                dao.AddNewEmployee(user, ac);
                MessageBox.Show("Add success!!!");

                done = true;
                parent.GetData(data);
                this.Hide();
            }
        }

        private bool ValidationFeild()
        {
            errorProvider1.Clear();
            DataClasses1DataContext db = new DataClasses1DataContext();
            bool result = true;
            var oldId = (from table in db.tblUsers select table.userID).ToList();
            if(txtUserId.Text!= "" || txtUserId != null)
            {
                foreach (var item in oldId)
                {
                    if(item == txtUserId.Text)
                    {
                        result = false;
                        MessageBox.Show("User Id is existed!!!");
                    }
                }
            }
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (txtUserId.Text == null || txtUserId.Text == "")
            {
                MessageBox.Show("User Id can not be null");
                result = false;
            }
            else if(txtPassword.Text == null || txtPassword.Text == "")
            {
                MessageBox.Show("Password can not be null");
                result = false;
            }
            else if(txtFirstName.Text ==null || txtFirstName.Text == "")
            {
                MessageBox.Show("First Name can not be null");
                result = false;
            }
            else if(txtLastName.Text == null || txtLastName.Text == "")
            {
                MessageBox.Show("Last Name can not be null");
                result = false;
            }
            else if( txtEmail.Text == null || txtEmail.Text == "")
            {
                MessageBox.Show("email can not be null");
                result = false;
            }
            else if (!Regex.IsMatch(txtEmail.Text,pattern))
            {
                errorProvider1.SetError(this.txtEmail, "format of email is wrong");
                result = false;
            }
            else if (txtPhoneNum.Text == null || txtPhoneNum.Text == "")
            {
                MessageBox.Show("Phone Number can not be null");
                result = false;
            }
            else
            {
                bool Continue = false;
                try
                {
                    long.Parse(txtPhoneNum.Text);
                }
                catch (Exception e)
                {
                    errorProvider1.SetError(this.txtPhoneNum, "Phone can not contain character");
                    result = false;
                    Continue = true;
                }
                if(Continue == false)
                {
                    if (txtPhoneNum.Text.Length != 10)
                    {
                        MessageBox.Show("phone number must have 10 numbers");
                        result = false;
                    }
                    else if (comboBoxRole.SelectedItem == null)
                    {
                        errorProvider1.SetError(this.comboBoxRole, "role hasn't chosen!!");
                        result = false;
                    }
                }
                
            }
            return result;
        }
    }
}
