using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingScreen.DTO
{
    class CarInfo
    {
        public string carID { get; set; }
        public string carName { get; set; }
        public string licensePlate { get; set; }
        public string userId { get; set; }

        public CarInfo()
        {

        }
        public CarInfo(string carid, string name, string licenseP, string userid)
        {
            this.carID = carid;
            this.carName = name;
            this.licensePlate = licenseP;
            this.userId = userid;
        }
    }
}
