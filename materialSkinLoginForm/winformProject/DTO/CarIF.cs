using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformProject.DTO
{
    class CarIF
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string licensePlate { get; set; }
        public string UserId { get; set; }
        public string Status { get; set; }
        private Image Image;
        public void SetImage(byte[] bytemap)
        {
            if (bytemap != null)
            {
                MemoryStream ms = new MemoryStream(bytemap);
                Image = Image.FromStream(ms);
            }
            else
            {
                Image = null;
            }
        }
        public Image GetImage()
        {
            return Image;
        }

        public CarIF(int carId, string carName, string licensePlate, string userId,string status, byte[] image)
        {
            CarId = carId;
            CarName = carName;
            this.licensePlate = licensePlate;
            UserId = userId;
            this.Status = status;
            this.SetImage(image);
        }

        public CarIF()
        {
        }
    }
}
