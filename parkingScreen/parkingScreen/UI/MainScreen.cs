using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using webcamCSharp;

namespace parkingScreen
{
    public partial class MainScreen : MetroFramework.Forms.MetroForm
    {
        private static MainScreen mainscreen = null;
        public MainScreen()
        {
            InitializeComponent();
        
        }
        public static MainScreen instance()
        {
            if(mainscreen == null)
            {
                mainscreen = new MainScreen();
            }
            return mainscreen;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            shotScreen shotscreen = shotScreen.instance();
            shotscreen.txtKeyCode.ReadOnly = true;
            shotscreen.btnSubmit.Enabled = false;
            shotscreen.btnTakePicture.Enabled = true;
            shotscreen.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            shotScreen shotscreen = shotScreen.instance();
            shotscreen.txtKeyCode.ReadOnly = false;
            shotscreen.btnSubmit.Enabled = true;
            shotscreen.btnTakePicture.Enabled = false;
            shotscreen.Show();
        }
    }
}
