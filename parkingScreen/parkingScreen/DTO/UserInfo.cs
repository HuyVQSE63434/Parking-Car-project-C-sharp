using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingScreen.DTO
{
 
    class UserInfo
    {
        public string userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string mail { get; set; }
        public string phoneNumber { get; set; }
        public string urlImage { get; set; }
        public UserInfo()
        {

        }
        public UserInfo(string id, string fname, string lname, string mail, string pnumber, string urlI)
        {
            this.userId = id;
            this.firstName = fname;
            this.lastName = lname;
            this.mail = mail;
            this.phoneNumber = pnumber;
            this.urlImage = urlI;
        }
    }
}
