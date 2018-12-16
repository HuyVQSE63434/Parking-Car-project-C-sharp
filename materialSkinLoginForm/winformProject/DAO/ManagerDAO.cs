using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winformProject.DTO;
using winformProject.Utis;

namespace winformProject.DAO
{
    class ManagerDAO
    {
        private int caculate(DateTime? timeIn, DateTime? timeOut)
        {
            int a = (timeOut.Value.Year - timeIn.Value.Year) * 12 * 30 * 24 * 60 +
                (timeOut.Value.Month - timeIn.Value.Month) * 30 * 24 * 60 +
                (timeOut.Value.Day - timeIn.Value.Day) * 24 * 60 +
                (timeOut.Value.Hour - timeIn.Value.Hour) * 60 +
                (timeOut.Value.Minute - timeIn.Value.Minute);

            return a;
        }
        public manageDTO getManageDTO(string id)
        {
            manageDTO dto = new manageDTO();
            DataClasses1DataContext db = new DataClasses1DataContext();
            var user = (from table in db.tblUsers where table.userID == id select table).SingleOrDefault();
            if (user != null)
            {
                dto.FullName = user.firstName + " " + user.lastName;
            }
            var carcount = (from table in db.tblCars where table.userID == id select table).Count();
            if (carcount > 0)
            {
                dto.numberOfCars = carcount;
            }
            double gio = 0;
            double phut = 0;
            double ngay = 0;
            var totalhis = (from table in db.tblHistories where table.userID == id select table);
            if (totalhis != null)
            {
                foreach (var item in totalhis)
                {
                    if(item.timeIn!=null && item.timeOut != null)
                    {
                        phut += (item.timeOut - item.timeIn).Value.TotalMinutes;
                        gio += (item.timeOut - item.timeIn).Value.TotalHours;
                        ngay += (item.timeOut - item.timeIn).Value.TotalDays;

                    }

                }
            }
            dto.numberOfTimes = ngay + " ngay " + gio + " gio " + phut + " phut ";
            dto.numberOfParked = totalhis.Count();
            dto.HistoryLists = totalhis.ToList();
            return dto;
        }

        public Hashtable GetDataParked(string id)
        {
            Hashtable result = new Hashtable();
            DataClasses1DataContext db = new DataClasses1DataContext();

            var his = (from table in db.tblHistories where table.userID == id select table).ToList();
            foreach (var item in his)
            {
                int itemMonth = item.timeIn.Value.Month;
                if (result.ContainsKey(itemMonth))
                {
                    result[itemMonth] = (int)result[itemMonth] + 1;
                }
                else
                {
                    result.Add(itemMonth, 1);
                }
            }
            return result;
        }
        public Hashtable GetDataMoney(string id)
        {
            Hashtable result = new Hashtable();
            DataClasses1DataContext db = new DataClasses1DataContext();

            var his = (from table in db.tblHistories where table.userID == id select table).ToList();
            foreach (var item in his)
            {
                int itemMonth = item.timeIn.Value.Month;
                if (result.ContainsKey(itemMonth))
                {
                    result[itemMonth] = (int)result[itemMonth] + (int)item.money;
                }
                else
                {
                    result.Add(itemMonth, (int)(item.money==null?0:item.money));
                }
            }
            return result;
        }
    }
}
