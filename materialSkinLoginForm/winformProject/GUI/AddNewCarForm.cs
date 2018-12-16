using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winformProject.DAO;
using winformProject.DTO;
using winformProject.Utis;

namespace winformProject.GUI
{
    public partial class AddNewCarForm : Form
    {

        private static AddNewCarForm instances;
        private CarForm parent;
        private AddNewCarForm()
        {
            InitializeComponent();
        }
        public static AddNewCarForm GetInstances(CarForm parent)
        {
            if (instances != null) return instances;
            if(instances == null) return instances = new AddNewCarForm(parent);
            if (instances.IsDisposed) return instances = new AddNewCarForm(parent);
            else return null;
        }
        public AddNewCarForm(CarForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void btnUploadLicense_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.InitialDirectory = "D:\\";
            if (of.ShowDialog() == DialogResult.OK)
            {
                Image im = Image.FromFile(of.FileName);
                PicBoxCarLicence.Image = im;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewCarForm_Load(object sender, EventArgs e)
        {
        
            MemoryStream msImage;
            WebClient wcImage = new WebClient();
            msImage = new MemoryStream(wcImage.DownloadData("http://chittagongit.com/images/license-plate-icon/license-plate-icon-3.jpg"));
            PicBoxCarLicence.Image = Image.FromStream(msImage);

            string[] roles = CarDAO.GetAllUser();
            foreach (var item in roles)
            {
                if (!cbUser.Items.Contains(item))
                    cbUser.Items.Add(item);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool check = ValidationFeild();
            if (check == true)
            {
                tblCar car = new tblCar();
                CarIF data = new CarIF();
                car.carName  = txtCarName.Text;
                if(txtLicensePlate.Text == null || txtLicensePlate.Text == "")
                {
                    if (readLicense(PicBoxCarLicence.Image) == null)
                    {
                        MessageBox.Show("Can't read license.Please give another picture");
                    }
                    else
                    {
                        car.licensePlate = readLicense(PicBoxCarLicence.Image);
                    }
                }
                else
                {
                    car.licensePlate = txtLicensePlate.Text;
                }
                MemoryStream ms = new MemoryStream();
                PicBoxCarLicence.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                car.nearestPhoto = ms.ToArray();
                car.status = "activated";
                car.userID = cbUser.SelectedItem.ToString();
                CarDAO dao = new CarDAO();
                dao.AddNewCar(car);
                data = CarDAO.GetCarfullInforByName(car.carName);
                parent.Getdata(data);
                MessageBox.Show("Add car success!");
                this.Close();
            }
        }
        private bool ValidationFeild()
        {
            CarDAO dao = new CarDAO();
            errorProvider1.Clear();
            bool result = true;

            if (txtCarName.Text == null || txtCarName.Text == "")
            {
                MessageBox.Show("Car Name can not be null");
                result = false;
            }
            else if (txtLicensePlate.Text == null || txtLicensePlate.Text == "")
            {
                if(PicBoxCarLicence.Image == null)
                MessageBox.Show("license plate or picture must have!");
                result = false;
            }
            else 
            {
                bool Continue = false;
                if (Continue == false)
                {
                    if (cbUser.SelectedItem == null)
                    {
                        errorProvider1.SetError(this.cbUser, "User hasn't chosen!!");
                        result = false;
                    }
                }

            }

            if(dao.checkCar(txtCarName.Text) == false)
            {
                result = false;
                MessageBox.Show("car name existed!");
            }
            return result;
        }
        private string readLicense(Image image)
        {
            if (image != null)
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

                string[] pl = content.Split('"', '{', '}', ',', ':');

                if(pl.Length > 5)
                {
                    return pl[5];
                }
            }
            return null;
        }
    }
}
