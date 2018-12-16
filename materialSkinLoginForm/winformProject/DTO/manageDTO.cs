using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winformProject.Utis;

namespace winformProject.DTO
{
    class manageDTO
    {
        public string FullName { get; set; }
        public int numberOfCars { get; set; }
        public string numberOfTimes { get; set; }
        public int numberOfParked { get; set; }
        public List<tblHistory> HistoryLists { get; set; }

        public manageDTO(string fullName, int numberOfCars, string numberOfTimes, int numberOfParked, List<tblHistory> historyLists)
        {
            FullName = fullName;
            this.numberOfCars = numberOfCars;
            this.numberOfTimes = numberOfTimes;
            this.numberOfParked = numberOfParked;
            HistoryLists = historyLists;
        }

        public manageDTO()
        {
        }
    }
}
