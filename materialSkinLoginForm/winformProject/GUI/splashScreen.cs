using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winformProject.DAO;
using winformProject.GUI;

namespace winformProject
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }
        private Timer tmr;

        private void Tmr_Tick(object sender, EventArgs e)
        {
            //after 3 sec stop the timer

            tmr.Stop();

            //display mainform
            checkLogin();

           
        }
        private void splashScreen_Load(object sender, EventArgs e)
        {
            tmr = new Timer();

            //set time interval 3 sec

            tmr.Interval = 2000;

            //starts the timer

            tmr.Start();

            tmr.Tick += Tmr_Tick;
        }
        private void checkLogin()
        {
            RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("smartparking");
            try
            {
                if (key != null)
                {
                    if (key.GetValue("UserId") != null && key.GetValue("Password") != null)
                    {
                        string userId = (string)key.GetValue("UserId");
                        string password = (string)key.GetValue("Password");
                        UserDAO dao = new UserDAO();
                        bool result = dao.CheckLogin(userId, password);
                        if (result == false)
                        {
                            loginForm mf = new loginForm();
                            mf.StartPosition = FormStartPosition.CenterScreen;

                            mf.Show();

                            //hide this form

                            this.Hide();
                        }
                        else
                        {
                            mainform main = new mainform(userId);
                            main.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        loginForm mf = new loginForm();
                        mf.StartPosition = FormStartPosition.CenterScreen;

                        mf.Show();

                        //hide this form

                        this.Hide();
                    }
                }
                else
                {
                    loginForm mf = new loginForm();
                    mf.StartPosition = FormStartPosition.CenterScreen;

                    mf.Show();

                    //hide this form

                    this.Hide();
                }
            }
            finally
            {
                if (key != null)
                {
                    key.Close();
                }
            }
            
        }
    }
}
