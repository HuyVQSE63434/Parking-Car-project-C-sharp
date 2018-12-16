using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformProject.DTO
{
    class UserIF
    {
        public string userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNum { get; set; }
        public string mail { get; set; }
        public string role { get; set; }
        public string status { get; set; }
        private Image image;
       public void SetImage(byte[] bytemap)
        {
            MemoryStream ms = new MemoryStream(bytemap);
            image = Image.FromStream(ms);
        }
        public Image GetImage()
        {
            return image;
        }

        public UserIF(string userId, string firstName, string lastName, string phoneNum, string mail,string rol,string sta ,byte[] image)
        {
            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNum = phoneNum;
            this.mail = mail;
            role = rol;
            status = sta;
            SetImage(image);
        }

        public UserIF()
        {
        }
    }
}
