using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingScreen.DAO
{
    class tblCarDAO
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

        public int getCarIdByCarName(string carName)
        {
            int result = 0;
            DataClasses1DataContext db = new DataClasses1DataContext();
            var com = from table in db.tblCars where table.carName == carName select table;
            foreach (var item in com)
            {
                result = item.carID;
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
        
        public string Getposition(int carID)
        {
            string result = null;
            DataClasses1DataContext db = new DataClasses1DataContext();
            var com =( from table in db.tblCarParks where table.carID == carID select table).Single();
            if (com != null)
            {
                result = com.position;
            }
            return result;
        }

        
    }
}
