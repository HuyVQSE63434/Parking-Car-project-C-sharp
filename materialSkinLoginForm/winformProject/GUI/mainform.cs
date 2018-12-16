using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
    public partial class mainform : Form
    {
        private string Userid { get; set; }
        
        public mainform(string id)
        {
            InitializeComponent();
            Userid = id;
            UserIF o = UserDAO.GetUserfullInfor(id);
            if (o != null)
            {
                welcomLabel.Text = "Welcome " + o.firstName + " " + o.lastName;
                UserAvatar.Image = o.GetImage();
            }
            
        }
        public mainform()
        {
            InitializeComponent();
        }
        private void mainform_Load(object sender, EventArgs e)
        {
            RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("smartparking", true);
            try
            {
                if(key!=null)
                if (key.GetValue("IsClosedWindow") != null && (string)key.GetValue("IsClosedWindow") == "True")
                {
                        bunifuImageButton2_Click(sender, e);
                }
                else
                {
                    key.SetValue("IsClosedWindow", false);
                }
            }
            finally
            {
                if (key != null)
                {
                    key.Close();
                }
            }
            EmployeeForm welcom = EmployeeForm.GetInstance(this.Userid);

            welcom.MdiParent = this;
            welcom.Dock = DockStyle.Fill;
            welcom.Show();
            welcom.BringToFront();

        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(5);
            this.Hide();
            Form[] child = this.MdiChildren.ToArray();
            foreach (var item in child)
            {
                item.Hide();
            }
            this.ShowInTaskbar = false;
            WindowState = FormWindowState.Maximized;
            notifyIcon1.Visible = true;
            RegistryKey rApp = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\windows\\CurrentVersion\\Run", true);
            if (rApp.GetValue("SmartParking") == null)
            {
                rApp.SetValue("SmartParking", Application.ExecutablePath.ToString());
            }
            rApp.Close();
            RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("smartparking", true);
            if(key!=null)
            if (key.GetValue("IsClosedWindow") != null && (string)key.GetValue("IsClosedWindow") == "False")
            {
                key.SetValue("IsClosedWindow", true);
            }
        }

        private void BtnMenuIcon_Click(object sender, EventArgs e)
        {
            if (slidemenu.Width == 50)
            {
                slidemenu.Visible = false;
                slidemenu.Width = 250;
                panelAnimator.ShowSync(slidemenu);

            }
            else
            {
                slidemenu.Visible = false;
                slidemenu.Width = 50;
                panelAnimator.ShowSync(slidemenu);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistryKey rApp = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\windows\\CurrentVersion\\Run", true);
            if (rApp.GetValue("SmartParking") !=null)
            {
                rApp.DeleteValue("SmartParking", false);
            }
            rApp.Close();
            Application.Exit();
        }
        private void showUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Show();
            this.ShowInTaskbar = true;
            Form[] child = this.MdiChildren.ToArray();
            foreach (var item in child)
            {
                item.Show();
                item.BringToFront();
            }
            WindowState = FormWindowState.Normal;
        }
        private void notificationIcon_DoubleClick(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Show();
            Form[] child = this.MdiChildren.ToArray();
            foreach (var item in child)
            {
                item.Show();
                item.BringToFront();
            }
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void btnUserManage_Click(object sender, EventArgs e)
        {
            EmployeeForm welcom = EmployeeForm.GetInstance(this.Userid);

            welcom.MdiParent = this;
            welcom.Dock = DockStyle.Fill;
            welcom.Show();
            welcom.BringToFront();
        }

        private void btnCarManage_Click(object sender, EventArgs e)
        {
            CarForm carform = CarForm.GetInstance();
            carform.MdiParent = this;
            carform.Dock = DockStyle.Fill;
            carform.Show();
            carform.BringToFront();

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            ParkingManager manager = ParkingManager.Instance();
            manager.MdiParent = this;
            manager.Dock = DockStyle.Fill;
            manager.Show();
            manager.BringToFront();
        }
    }
}
