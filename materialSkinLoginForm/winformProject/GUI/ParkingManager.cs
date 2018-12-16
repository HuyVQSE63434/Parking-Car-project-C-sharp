using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;
using winformProject.DAO;
using winformProject.DTO;
using winformProject.Utis;

namespace winformProject.GUI
{
    public partial class ParkingManager : Form
    {
        private ParkingManager()
        {
            InitializeComponent();
        }
        private static ParkingManager instance;
        public static ParkingManager Instance()
        {
            if (instance != null) return instance;
            else return instance = new ParkingManager();
        }

        
        private void ParkingManager_Load(object sender, EventArgs e)
        {

            List<string> useridList = CarDAO.GetAllUserId();
            cbUser.DataSource = useridList;
            cbUser.SelectedIndex = 0;
            GetData(cbUser.SelectedValue.ToString());
            GetParkedPerMonth();
        }
        public void GetParkedPerMonth()
        {
            this.chart1.Series.Clear();

            chart1.Series.Add("month");
            // Set title
            chart1.Titles.Clear();
            this.chart1.Titles.Add("Parked per Month");

            // Add series.
            ManagerDAO dao = new ManagerDAO();
            Hashtable Htable = dao.GetDataParked(cbUser.SelectedValue.ToString());
            ICollection table = Htable.Keys;
            foreach (var item in table)
            {
                chart1.Series["month"].Points.AddXY(item, Htable[item]);
            }

        }

        public void GetMoneyPerMonth()
        {
            this.chart1.Series.Clear();

            chart1.Series.Add("Money(vnd)");
            // Set title
            chart1.Titles.Clear();
            this.chart1.Titles.Add("Money per Month");

            // Add series.
            ManagerDAO dao = new ManagerDAO();
            Hashtable Htable = dao.GetDataMoney(cbUser.SelectedValue.ToString());
            ICollection table = Htable.Keys;
            foreach (var item in table)
            {
                chart1.Series["Money(vnd)"].Points.AddXY(item, (int)Htable[item]);
                
            }

        }
        public void GetData(string id)
        {
            ManagerDAO dao = new ManagerDAO();
            manageDTO dto = dao.getManageDTO(id);

            lbFNames.Text = dto.FullName;
            lbCars.Text = dto.numberOfCars.ToString();
            lbParked.Text = dto.numberOfParked.ToString();
            lbTimes.Text = dto.numberOfTimes;

            dgvHistory.DataSource = dto.HistoryLists;
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData(cbUser.SelectedValue.ToString());
            GetParkedPerMonth();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            GetParkedPerMonth();
        }

        private void btnMperM_Click(object sender, EventArgs e)
        {
            GetMoneyPerMonth();
        }
    }
}
