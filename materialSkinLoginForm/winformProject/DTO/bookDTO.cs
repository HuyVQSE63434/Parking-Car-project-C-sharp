using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformProject.DTO
{
    class bookDTO
    {

        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public float BookPrice { get; set; }
        public int Bookquantity { get; set; }

        public bookDTO(int bookID, string bookTitle, float bookPrice, int bookquantity)
        {
            BookID = bookID;
            BookTitle = bookTitle;
            BookPrice = bookPrice;
            Bookquantity = bookquantity;
        }

        public bookDTO()
        {
        }
    }
}
