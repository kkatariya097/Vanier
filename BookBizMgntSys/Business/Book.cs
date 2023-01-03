using BookBizMgntSys.Data_IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBizMgntSys.Business
{
    public class Book
    {

        public int ISBN { get; set; }
        public string Title { get; set; }
        public double UnitPrice { get; set; }
        public int YearPublished { get; set; }
        public int QuantityOnHand { get; set; }

        public string PublisherName { get; set; }

        public string AuthorName { get; set; }


        //Save new Book Info
        public void SaveaBook(Book book)
        {
            InventoryControllerIO.SaveBook(book);
        }

        //Update Book
        public bool UpdateaBook(Book book)
        {
            return InventoryControllerIO.UpdateBook(book);
        }

        //List all Books
        public void ListAllBook(ListView listview)
        {
            InventoryControllerIO.ListBook(listview);
        }




















    }
}
