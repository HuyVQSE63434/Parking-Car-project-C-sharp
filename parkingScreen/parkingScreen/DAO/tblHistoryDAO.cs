using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingScreen.DAO
{
    class tblHistoryDAO
    {
        public void UpdateFullHistory(string carname)
        {

            DataClasses1DataContext db = new DataClasses1DataContext();
            var id = (from table in db.tblCars where table.carName == carname select table.carID).Single();
            var his = (from table in db.tblHistories where table.carID == id && table.timeOut == null select table).Single();
            his.timeOut = DateTime.Now;
            his.money = calculateMoney(his.timeIn, his.timeOut);

            System.Windows.Forms.MessageBox.Show("your fee is " + his.money);
            db.SubmitChanges();
            var car = (from table in db.tblCars where table.carName == carname select table).Single();
            car.status = "available";
            db.SubmitChanges();
            db.Dispose();

        }


        private double? calculateMoney(DateTime? timeIn, DateTime? timeOut)
        {
            int a = (timeOut.Value.Year - timeIn.Value.Year) * 12 * 30 * 24 * 60 +
                (timeOut.Value.Month - timeIn.Value.Month) * 30 * 24 * 60 +
                (timeOut.Value.Day - timeIn.Value.Day) * 24 * 60 +
                (timeOut.Value.Hour - timeIn.Value.Hour) * 60 +
                (timeOut.Value.Minute - timeIn.Value.Minute);

            return a * 1000;
        }
        public void CreateHistory(string carname)
        {
            tblCarDAO dao = new tblCarDAO();
            tblCar car = dao.getCarByName(carname);
            if (dao.Getposition(car.carID) != null)
            {
                DataClasses1DataContext db = new DataClasses1DataContext();

                var carpark =( from table in db.tblCarParks where table.position == dao.Getposition(car.carID) select table).SingleOrDefault();
                if(carpark.timeIn == null)
                {
                    carpark.timeIn = DateTime.Now;
                }
                db.SubmitChanges();

                tblHistory his = new tblHistory();
                his.carID = car.carID;
                his.position = dao.Getposition(car.carID);
                his.timeIn = DateTime.Now;
                his.userID = car.userID;
                Random rd = new Random();
                his.keyCode = rd.Next(1000, 9999).ToString();

                db.tblHistories.InsertOnSubmit(his);
                db.SubmitChanges();
                var caru = (from table in db.tblCars where table.carName == carname select table).Single();
                caru.status = "activated";
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
