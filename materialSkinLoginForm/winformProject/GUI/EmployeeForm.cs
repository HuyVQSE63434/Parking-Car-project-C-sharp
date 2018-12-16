using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;
using winformProject.DAO;
using winformProject.DTO;
using winformProject.Utis;

namespace winformProject.GUI
{
    public partial class EmployeeForm : Form
    {


        private EmployeeForm(string id)
        {
            this.userId = id;

            InitializeComponent();
            SqlDeStart();
        }
        static string connectionString = "Data Source=database2.c69kwntmezi6.us-east-2.rds.amazonaws.com;Initial Catalog=smartParking;User ID=sa;Password=12345678";
        static SqlTableDependency<tblUser> tableDependency = new SqlTableDependency<tblUser>(connectionString, "tblUsers");

        private void SqlDeStart()
        {

            tableDependency.OnChanged += tableDependency_change;
            tableDependency.Start();

        }
        delegate void DelegateGetData();
        private void tableDependency_change(object sender, RecordChangedEventArgs<tblUser> e)
        {
            if (e.ChangeType != ChangeType.None)
            {
                if (this.Visible == true)
                {
                    MessageBox.Show("We has some change: " + e.ChangeType + " User is occurr. please wait until loading data done!");
                    if (InvokeRequired)
                    {
                        DelegateGetData d = new DelegateGetData(GetDataAsync);
                        this.Invoke(d);
                    }
                }
                else
                {
                    mainform parent = (mainform)this.MdiParent;
                    parent.notifyIcon1.BalloonTipText = "We has some change: " +
                        e.ChangeType + " User is occurr. ";
                    parent.notifyIcon1.ShowBalloonTip(5);
                    if (InvokeRequired)
                    {
                        DelegateGetData d = new DelegateGetData(GetDataAsync);
                        this.Invoke(d);
                    }
                }
            }
        }


        //======================================================================================


        public string userId;
        private string idhinhpass;
        private static EmployeeForm instance;
        private UserIF[] data;

        public static EmployeeForm GetInstance(string id)
        {
            if (instance != null) return instance;
            else return instance = new EmployeeForm(id);
        }
        
        async void GetDataAsync()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new getdata(GetDataAsync));
            }
            else
            {
                UserIF user = UserDAO.GetUserfullInfor(userId);
                if (user != null)
                {
                    lbRole.Text = user.role;
                    txtUserId.Text = user.userId;
                    avtBox.Image = user.GetImage();
                    txtFirstName.Text = user.firstName;
                    txtLastNane.Text = user.lastName;
                    txtMail.Text = user.mail;
                    txtPhoneNum.Text = user.phoneNum;
                    List<UserIF> dataMain = new List<UserIF>();
                    data = await UserDAO.UserDataAsync();
                    foreach (var item in data)
                    {
                        dataMain.Add(item);
                    }
                    DataGridEm.DataSource = dataMain;

                    dataBlinding(DataGridEm.DataSource);
                    MessageBox.Show("completed load data!");
                }
            }
        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            //GetData();
            GetDataAsync();
        }
        private delegate void getdata();
        //internal void GetData()
        //{
        //    if (this.InvokeRequired)
        //    {
        //        this.Invoke(new getdata(GetData));
        //    }
        //    else
        //    {
        //        UserIF user = UserDAO.GetUserfullInfor(userId);
        //        if (user != null)
        //        {
        //            lbRole.Text = user.role;
        //            txtUserId.Text = user.userId;
        //            avtBox.Image = user.GetImage();
        //            txtFirstName.Text = user.firstName;
        //            txtLastNane.Text = user.lastName;
        //            txtMail.Text = user.mail;
        //            txtPhoneNum.Text = user.phoneNum;
        //            List<UserIF> dataMain = new List<UserIF>();
        //            data = UserDAO.GetAllUserfullInfor();
        //            foreach (var item in data)
        //            {
        //                dataMain.Add(item);
        //            }
        //            DataGridEm.DataSource = dataMain;

        //            dataBlinding(DataGridEm.DataSource);

        //        }
        //    }
        //}

        private void dataBlinding(object data)
        {
            avtBox.DataBindings.Clear();
            lbRole.DataBindings.Clear();
            txtFirstName.DataBindings.Clear();
            txtLastNane.DataBindings.Clear();
            txtMail.DataBindings.Clear();
            txtPhoneNum.DataBindings.Clear();
            txtUserId.DataBindings.Clear();

            lbRole.DataBindings.Add("text", data, "role");
            txtFirstName.DataBindings.Add("text", data, "firstName");
            txtLastNane.DataBindings.Add("text", data, "lastName");
            txtMail.DataBindings.Add("text", data, "mail");
            txtPhoneNum.DataBindings.Add("text", data, "phoneNum");
            txtUserId.DataBindings.Add("text", data, "userId");
        }

        internal void GetData(UserIF data)
        {
            List<UserIF> datalist = (List<UserIF>)DataGridEm.DataSource;
            datalist.Add(data);
            DataGridEm.DataSource = datalist;
            //DataGridEm.Rows.Add(data.userId, data.firstName,data.lastName,data.phoneNum,data.mail,data.role);
            dataBlinding(DataGridEm.DataSource);
        }

        private void DataGridEm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = DataGridEm.CurrentCell.RowIndex;
            string id = DataGridEm.Rows[index].Cells[0].Value.ToString().Trim();
            if (id != idhinhpass)
            {
                idhinhpass = id;
                foreach (var item in (List<UserIF>)DataGridEm.DataSource)
                {
                    if (item.userId == idhinhpass)
                    {
                        avtBox.Image = item.GetImage();
                    }
                }
            };

        }
        private AddNewEmpForm emp;
        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            emp = AddNewEmpForm.getInstance(instance);
            emp.Show();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            UserDAO dao = new UserDAO();
            dao.DeleteEmployee(txtUserId.Text);
            //GetData();
            GetDataAsync();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UserDAO dao = new UserDAO();
            MemoryStream ms = new MemoryStream();
            avtBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            dao.UpdateImployee(new tblUser()
            {
                userID = txtUserId.Text,
                firstName = txtFirstName.Text,
                lastName = txtLastNane.Text,
                phoneNumber = txtPhoneNum.Text,
                mail = txtMail.Text,
                image = ms.ToArray()
            });
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<UserIF> dataSearch = UserDAO.GetUserfullInforByNameLike(txtSearch.Text, data);

            DataGridEm.DataSource = dataSearch;

            if (dataSearch != null)
            {
                UserIF user = dataSearch.ElementAt(0);
                lbRole.Text = user.role;
                txtUserId.Text = user.userId;
                txtFirstName.Text = user.firstName;
                txtLastNane.Text = user.lastName;
                txtMail.Text = user.mail;
                txtPhoneNum.Text = user.phoneNum;
                if (user.GetImage() != null)
                    avtBox.Image = user.GetImage();


            }
            dataBlinding(DataGridEm.DataSource);

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUndelete_Click(object sender, EventArgs e)
        {
            UserDAO dao = new UserDAO();
            dao.UnDeleteEmployee(txtUserId.Text);
            //GetData();
            GetDataAsync();
        }
    }
}
