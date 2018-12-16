using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using winformProject.DAO;
using winformProject.GUI;

namespace winformProject
{
    public partial class loginForm : MaterialSkin.Controls.MaterialForm
    {
        public loginForm()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue400, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            
        }
       
        private void loginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserDAO dao = new UserDAO();
            bool result = dao.CheckLogin(txtUsername.Text, txtPassword.Text);
            if(result == false)
            {
                ErrorLabel.Text = "UserID or Password is not correct, please try again.";
            }
            else
            {
                MessageBox.Show("Login Success! Please Wait loading data");
                mainform main = new mainform(txtUsername.Text);
                this.Hide();
                main.Show();
                DialogResult save = MessageBox.Show("Do you want to save login status?","Option",MessageBoxButtons.OKCancel);
                if(save == DialogResult.OK)
                {
                    MessageBox.Show("your loginstate is saved!");
                    dao.SaveLoginState(txtUsername.Text, txtPassword.Text);
                }
            }
        }
    }
}
