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
    public partial class welcomeForm : Form
    {
        private new shotScreen Parent;
        public welcomeForm(string welcomeString, shotScreen parent)
        {
            InitializeComponent();
            bunifuFlatButton1.Text = welcomeString;
            Parent = parent;
        }

        private void welcomeForm_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parent.Dispose();
        }

        private void icon_Click(object sender, EventArgs e)
        {

        }
    }
}
