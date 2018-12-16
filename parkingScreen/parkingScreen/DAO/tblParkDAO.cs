using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingScreen.DAO
{
    class tblParkDAO
    {
        public bool CheckBooked(string carName)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var cId = (from table in db.tblCars where table.carName == carName select table.carID).Single();
            var item = (from table in db.tblCarParks where table.carID == cId && table.note == "booked" select table).FirstOrDefault();
            if (item != null)
            {
                if (item.note.Equals("booked"))
                {
                    item.note = "parked";
                    db.SubmitChanges();
                    db.Dispose();
                    return true;
                }

            }

            return false;
        }

        public bool CreateRamdomPlace(string carName)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var park = from table in db.tblCarParks select table;
            bool result = false;
            foreach (var item in park)
            {
                if (item.carID == null)
                {
                    var carid = (from table in db.tblCars where table.carName == carName select table.carID).Single();
                    item.carID = carid;
                    item.note = "booked";
                    db.SubmitChanges();
                    db.Dispose();
                    return result = true ;
                }
            }
            return result;
        }

        internal void UpdateParkingSlot(string carName)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var cId = (from table in db.tblCars where table.carName == carName select table.carID).Single();
            var item = (from table in db.tblCarParks where table.carID == cId && table.note == "parked" select table).Single();

            if (item.note.Equals("parked"))
            {
                item.note = "available";
                item.carID = null;
                item.timeIn = null;
                db.SubmitChanges();
                db.Dispose();
            }
        }
    }
}
