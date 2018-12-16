using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using System.IO;
using RestSharp;
using parkingScreen.DAO;
using parkingScreen;
using System.Threading;

namespace webcamCSharp
{
    public partial class shotScreen : MetroFramework.Forms.MetroForm
    {
        private FilterInfoCollection cameras;
        private VideoCaptureDevice cam;
        //private string carname;

        private static shotScreen shotscreen = null;
        public shotScreen()
        {
            InitializeComponent();
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in cameras)
            {
                comboBox1.Items.Add(info.Name);
            }
            comboBox1.SelectedIndex = 0;
        }

        internal static shotScreen instance()
        {
            if (shotscreen == null)
            {
                shotscreen = new shotScreen();
            }
            if (shotscreen.IsDisposed)
            {
                shotscreen = new shotScreen();
            }
            return shotscreen;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
            cam = new VideoCaptureDevice(cameras[comboBox1.SelectedIndex].MonikerString);
            cam.NewFrame += cam_NewFrame;
            cam.Start();
        }

        private void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bitmap;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }

        }

        private void btnTakePicture_Click(object sender, EventArgs e)
        {
            if (checkKeyCode == false)
            {
                if (pictureBox1.Image != null)
                {
                    Image image = (Image)pictureBox1.Image.Clone();


                    string carname = GetCarName(image);
                    if (carname != null)
                    {
                        pictureBox1.Image = image;
                        tblParkDAO parkDao = new tblParkDAO();
                        bool checkPark = parkDao.CheckBooked(carname);
                        if (checkPark == true)
                        {
                            welcomeForm w = new welcomeForm("Welcome " + carname, this);
                            w.Show();
                            tblHistoryDAO camc = new tblHistoryDAO();
                            camc.CreateHistory(carname);
                        }
                        else
                        {
                            MessageBox.Show("You do not have booked place, we will fill you in the random place");
                            bool haveBlankPalce=parkDao.CreateRamdomPlace(carname);
                            if(haveBlankPalce == true)
                            {
                                parkDao.CheckBooked(carname);
                                welcomeForm w = new welcomeForm("Welcome " + carname, this);
                                w.Show();
                                tblHistoryDAO camc = new tblHistoryDAO();
                                camc.CreateHistory(carname);
                            }
                            else
                            {
                                MessageBox.Show("We don't have blank slot, sorrry guy!");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("You car is invaliable");
                    }

                }
                else
                {
                    MessageBox.Show("start first!!!!!");
                }

            }
            else
            {
                if (pictureBox1.Image != null)
                {
                    Image image = (Image)pictureBox1.Image.Clone();


                    string carname = GetCarName(image);
                    tblCarDAO carDao = new tblCarDAO();
                    if (carname != null && carDao.getCarIdByCarName(carname) == shareHis.carID)
                    {
                        pictureBox1.Image = image;
                        tblParkDAO parkDao = new tblParkDAO();
                        parkDao.UpdateParkingSlot(carname);
                        tblHistoryDAO hisDao = new tblHistoryDAO();
                        hisDao.UpdateFullHistory(carname);
                        welcomeForm w = new welcomeForm("GoodBye " + carname, this);
                        w.Show();
                    }
                    else
                    {
                        MessageBox.Show("the code not for this car!");
                    }
                }
                else
                {
                    MessageBox.Show("start first!!!!!");
                }
            }

        }
        public string GetCarName(Image image)
        {
            var client = new RestClient("http://api.openfpt.vn/anpr");
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "multipart/form-data");
            request.AddHeader("api_key", "3fa389a41e084709a9f2eecfcfd764b4");


            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] imageBytes = ms.ToArray();

            request.AddFileBytes("image", imageBytes, "image");

            IRestResponse response = client.Execute(request);

            string content = response.Content;

            if (content != null)
            {
                string[] pl = content.Split('"', '{', '}', ',', ':');
                //for (int i = 0; i < pl.Length; i++)
                //{
                //    if (pl[i] != "") MessageBox.Show("Test " + i + " is " + pl[i]);
                //}
                if (pl.Length > 5)
                {
                    string result = pl[5];
                    if (cam != null && cam.IsRunning)
                    {
                        cam.Stop();

                    }
                    tblCarDAO camc = new tblCarDAO();
                    string carname = camc.checkCarReturnName(result);
                    if (carname != null)
                    {
                        return carname;
                    }
                }
                else
                {
                    MessageBox.Show("please take photo again");
                }
            }
            else
            {
                MessageBox.Show("please take photo again");
            }
            return null;
        }
        private tblHistory shareHis;
        private bool checkKeyCode = false;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtKeyCode.Text == "" || txtKeyCode.Text == null)
            {
                MessageBox.Show("please input keycode");
            }
            else
            {
                KeyCodeCheck check = new KeyCodeCheck();
                tblHistory result = check.CheckKC(txtKeyCode.Text);
                if (result != null)
                {
                    shareHis = result;
                    MessageBox.Show("Right key code, please take picture!");
                    checkKeyCode = true;
                    btnTakePicture.Enabled = true;
                    txtKeyCode.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("wrong keycode");
                }
            }
        }

        private void shotScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
