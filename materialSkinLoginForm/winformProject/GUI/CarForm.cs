using System;
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
    public partial class CarForm : Form
    {
        private static CarForm instance;
        private CarForm()
        {
            InitializeComponent();
            SqlDeStart();
        }

        public static CarForm GetInstance()
        {
            if (instance != null)
            {
                return instance;
            }
            else
            {
                return instance = new CarForm();
            }
        }
        static string connectionString = "Data Source=database2.c69kwntmezi6.us-east-2.rds.amazonaws.com;Initial Catalog=smartParking;User ID=sa;Password=12345678";
        static SqlTableDependency<tblCar> tableDependency = new SqlTableDependency<tblCar>(connectionString, "tblCars");
        private void SqlDeStart()
        {

            tableDependency.OnChanged += tableDependency_change;
            tableDependency.Start();

        }
        delegate void DelegateDetData();
        private void tableDependency_change(object sender, RecordChangedEventArgs<tblCar> e)
        {
            if (e.ChangeType != ChangeType.None)
            {
                if (this.Visible == true)
                {
                        MessageBox.Show("We has some change: " + e.ChangeType + " Car is occurr. please wait until loading data done!");
                        if (InvokeRequired)
                        {
                            DelegateDetData d = new DelegateDetData(GetDataAsync);
                            this.Invoke(d);
                        }
                    
                }
                else
                {
                    mainform parent = (mainform)this.MdiParent;
                    parent.notifyIcon1.BalloonTipText = "We has some change: " +
                        e.ChangeType + " car is occurr.";
                    parent.notifyIcon1.ShowBalloonTip(5);
                    if (InvokeRequired)
                    {
                        DelegateDetData d = new DelegateDetData(GetDataAsync);
                        this.Invoke(d);
                    }

                }
            }
        }
        //=======================================================================================
        CarIF[] data;
        private int idhinhpass = 0;
        async void GetDataAsync()
        {
            data = await CarDAO.GetAllCarInfoAsync();
            List<CarIF> dataMain = new List<CarIF>();
            foreach (var item in data)
            {
                dataMain.Add(item);
            }
            DataGridCar.DataSource = dataMain;// loi call by other thread
            //DataGridCar.DataSource = data;
            CarIF car = data[0];
            carIdTextBox.Text = car.CarId.ToString();
            carNameTextBox.Text = car.CarName;
            if (car.GetImage() != null)
                avtBox.Image = car.GetImage();
            licensePlateTextBox.Text = car.licensePlate;
            UserIDDropD.Items.Add(car.UserId);
            UserIDDropD.SelectedIndex = 0;
            List<string> userid = CarDAO.GetAllUserId();
            foreach (var item in userid)
            {
                if (!UserIDDropD.Items.Contains(item))
                    UserIDDropD.Items.Add(item);
            }
            dataBlinding(DataGridCar.DataSource);
            MessageBox.Show("loading data done!");
        }
        //internal void GetData()
        //{
        //    data = CarDAO.GetAllCarInfo();
        //    List<CarIF> dataMain = new List<CarIF>();
        //    foreach (var item in data)
        //    {
        //        dataMain.Add(item);
        //    }
        //    DataGridCar.DataSource = dataMain;// loi call by other thread
        //    //DataGridCar.DataSource = data;
        //    CarIF car = data[0];
        //    carIdTextBox.Text = car.CarId.ToString();
        //    carNameTextBox.Text = car.CarName;
        //    if (car.GetImage() != null)
        //        avtBox.Image = car.GetImage();
        //    licensePlateTextBox.Text = car.licensePlate;
        //    UserIDDropD.Items.Add(car.UserId);
        //    UserIDDropD.SelectedIndex = 0;
        //    List<string> userid = CarDAO.GetAllUserId();
        //    foreach (var item in userid)
        //    {
        //        if (!UserIDDropD.Items.Contains(item))
        //            UserIDDropD.Items.Add(item);
        //    }
        //    dataBlinding(DataGridCar.DataSource);

        //}

        internal void Getdata(CarIF data)
        {
            List<CarIF> list = (List<CarIF>)DataGridCar.DataSource;
            list.Add(data);
            DataGridCar.DataSource = list;
            dataBlinding(DataGridCar.DataSource);

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<CarIF> dataSearch = CarDAO.GetCarByLikeName(txtSearch.Text, data);
            DataGridCar.DataSource = dataSearch;
            if (dataSearch != null)
            {
                CarIF car = dataSearch.ElementAt(0);
                carIdTextBox.Text = car.CarId.ToString();
                carNameTextBox.Text = car.CarName;
                if (car.GetImage() != null)
                    avtBox.Image = car.GetImage();
                licensePlateTextBox.Text = car.licensePlate;
                UserIDDropD.Items.Add(car.UserId);
                UserIDDropD.SelectedIndex = 0;
                List<string> userid = CarDAO.GetAllUserId();
                foreach (var item in userid)
                {
                    if (!UserIDDropD.Items.Contains(item))
                        UserIDDropD.Items.Add(item);
                }
            }
            dataBlinding(DataGridCar.DataSource);
        }
        public void dataBlinding(object data)
        {
            carIdTextBox.DataBindings.Clear();
            carNameTextBox.DataBindings.Clear();
            licensePlateTextBox.DataBindings.Clear();
            statusLabel.DataBindings.Clear();
            UserIDDropD.DataBindings.Clear();

            carIdTextBox.DataBindings.Add("text", data, "carID");
            carNameTextBox.DataBindings.Add("text", data, "carName");
            licensePlateTextBox.DataBindings.Add("text", data, "licensePlate");
            UserIDDropD.DataBindings.Add("text", data, "userID");
            statusLabel.DataBindings.Add("text", data, "status");

        }

        private void DataGridCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = DataGridCar.CurrentCell.RowIndex;

            int id = int.Parse(DataGridCar.Rows[index].Cells[0].Value.ToString().Trim());
            if (id != idhinhpass)
            {
                idhinhpass = id;
                foreach (var item in data)
                {
                    if (item.CarId == idhinhpass)
                    {
                        avtBox.Image = item.GetImage();
                        foreach (var userid in UserIDDropD.Items)
                        {
                            if (userid.ToString().Equals(item.UserId))
                            {
                                UserIDDropD.SelectedItem = item.UserId;
                            }
                        }
                    }
                }
            };
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            GetDataAsync();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            AddNewCarForm addForm = AddNewCarForm.GetInstances(this);
            addForm.Show();
        }

        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            CarDAO dao = new CarDAO();
            MemoryStream ms = new MemoryStream();
            avtBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            dao.UpdateCar(new tblCar()
            {
                carID = int.Parse(carIdTextBox.Text),
                carName = carNameTextBox.Text,
                licensePlate = licensePlateTextBox.Text,
                userID = UserIDDropD.SelectedText,
                status = statusLabel.Text,
                nearestPhoto = ms.ToArray()
            });
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            CarDAO dao = new CarDAO();
            dao.DeleteCar(carIdTextBox.Text);
            GetDataAsync();
        }

        private void carNameTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            CarDAO dao = new CarDAO();
            dao.UnDeleteCar(carIdTextBox.Text);
            GetDataAsync();
        }
    }
}
