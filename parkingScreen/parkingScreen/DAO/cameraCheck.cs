using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingScreen.DAO
{
    class cameraCheck
    {
        public string checkCarReturnName(string carnumber)
        {
            string result = null;
            DataClasses1DataContext db = new DataClasses1DataContext();
            var com = from table in db.tblCars where table.licensePlate == carnumber select table;
            foreach (var item in com)
            {
                 result = item.carName;
            }
            db.Dispose();
            return result;
        }

        public string getCarIdByCarName(string carName)
        {
            string result = null;
            DataClasses1DataContext db = new DataClasses1DataContext();
            var com = from table in db.tblCars where table.carName == carName select table;
            foreach (var item in com)
            {
                result = item.carName;
            }
            db.Dispose();
            return result;
        }

        public tblCar getCarByName(string name)
        {
            tblCar result = null;
            DataClasses1DataContext db = new DataClasses1DataContext();
            var com = from table in db.tblCars where table.carName == name select table;
            foreach (var item in com)
            {
                result = item;
            }
            return result;
        }
        
        public int Getposition(int carID)
        {
            int result = 0;
            DataClasses1DataContext db = new DataClasses1DataContext();
            var com =( from table in db.tblCarParks where table.carID == carID select table).Single();
            if (com != null)
            {
                result = int.Parse(com.position);
            }
            return result;
        }

        public void CreateHistory(string carname)
        {
            cameraCheck camc = new cameraCheck();
            tblCar car = camc.getCarByName(carname);
            if (camc.Getposition(car.carID)!=0)
            {
                DataClasses1DataContext db = new DataClasses1DataContext();

                tblHistory his = new tblHistory();
                his.carID = car.carID;
                his.position = camc.Getposition(car.carID).ToString();
                his.timeIn = DateTime.Now;
                his.userID = car.userID;
                Random rd = new Random();
                his.keyCode = rd.Next(1000, 9999).ToString();

                db.tblHistories.InsertOnSubmit(his);
                db.SubmitChanges();

                string phone = (from table in db.tblUsers
                                where table.userID
                                == car.userID
                                select table.phoneNumber).Single();
                SMSSender sms = new SMSSender();
                bool checksended = sms.sendSMS(phone, his.keyCode);
                if (checksended == true)
                {
                    System.Windows.Forms.MessageBox.Show("your keycode is already sended!!!");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("you have no place in plan");
            }
            
        }
    }
}
