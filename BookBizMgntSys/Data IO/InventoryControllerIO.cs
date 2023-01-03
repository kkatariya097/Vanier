using BookBizMgntSys.Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBizMgntSys.Data_IO
{
    public class InventoryControllerIO
    {

        private static string filePath = Application.StartupPath + @"\BookInventory.dat";
        private static string fileTemp = Application.StartupPath + @"\Temp.dat";


        //Save record
        public static void SaveBook(Book book)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(book.ISBN + "," + book.Title + "," + book.UnitPrice + "," + book.YearPublished + "," + book.QuantityOnHand + "," + book.PublisherName + "," + book.AuthorName);
            sWriter.Close();
            MessageBox.Show("New Book has been saved.");
        }


        // list all data from file to Form List View
        public static void ListBook(ListView listview)
        {

            StreamReader sReader = new StreamReader(filePath);
            listview.Items.Clear();
            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                ListViewItem item = new ListViewItem(fields[0]);
                item.SubItems.Add(fields[1]);
                item.SubItems.Add(fields[2]);
                item.SubItems.Add(fields[3]);
                item.SubItems.Add(fields[4]);
                item.SubItems.Add(fields[5]);
                item.SubItems.Add(fields[6]);

                listview.Items.Add(item);
                line = sReader.ReadLine();
            }
            sReader.Close();
        }


        //update record in file
        public static bool UpdateBook(Book book)
        {
            try
            {
                StreamReader sReader = new StreamReader(filePath);
                StreamWriter sWriter = new StreamWriter(fileTemp, true);
                string line = sReader.ReadLine();

                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if ((Convert.ToInt32(fields[0]) != (book.ISBN)))
                    {
                        sWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6]);
                    }

                    line = sReader.ReadLine();       
                }
                sWriter.WriteLine(book.ISBN + "," + book.Title + "," + book.UnitPrice + "," + book.YearPublished + "," + book.QuantityOnHand + "," + book.PublisherName + "," + book.AuthorName);
                sReader.Close();
                sWriter.Close();
                File.Delete(filePath);
                File.Move(fileTemp, filePath);
                return true;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        //search BookInventory from file
        public static Book SearchISBN(int book)
        {
            Book bk = new Book();

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (book == Convert.ToInt32(fields[0]))
                {
                    bk.ISBN = Convert.ToInt32(fields[0]);
                    bk.Title = fields[1];
                    bk.UnitPrice = Convert.ToInt32(fields[2]);
                    bk.YearPublished = Convert.ToInt32(fields[3]);
                    bk.QuantityOnHand = Convert.ToInt32(fields[4]);
                    bk.PublisherName = fields[5];
                    bk.AuthorName = fields[6];
                 
                    sReader.Close();
                    return bk;
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            return null;
        }


        //search book title
        public static Book SearchBookTitle(string book)
        {
            Book bk = new Book();

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (book.Equals(fields[1]))
                {
                    bk.ISBN = Convert.ToInt32(fields[0]);
                    bk.Title = fields[1];
                    bk.UnitPrice = Convert.ToInt32(fields[2]);
                    bk.YearPublished = Convert.ToInt32(fields[3]);
                    bk.QuantityOnHand = Convert.ToInt32(fields[4]);
                    bk.PublisherName = fields[5];
                    bk.AuthorName = fields[6];
                    sReader.Close();
                    return bk;
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            return null;
        }


        //search book Publisher name
        public static Book SearchBookPublisher(string book)
        {
            Book bk = new Book();

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (book.Equals(fields[5]))
                {
                    bk.ISBN = Convert.ToInt32(fields[0]);
                    bk.Title = fields[1];
                    bk.UnitPrice = Convert.ToInt32(fields[2]);
                    bk.YearPublished = Convert.ToInt32(fields[3]);
                    bk.QuantityOnHand = Convert.ToInt32(fields[4]);
                    bk.PublisherName = fields[5];
                    bk.AuthorName = fields[6];
                    sReader.Close();
                    return bk;
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            return null;
        }

        //search book Author name
        public static Book SearchBookAuthor(string book)
        {
            Book bk = new Book();

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (book.Equals(fields[6]))
                {
                    bk.ISBN = Convert.ToInt32(fields[0]);
                    bk.Title = fields[1];
                    bk.UnitPrice = Convert.ToInt32(fields[2]);
                    bk.YearPublished = Convert.ToInt32(fields[3]);
                    bk.QuantityOnHand = Convert.ToInt32(fields[4]);
                    bk.PublisherName = fields[5];
                    bk.AuthorName = fields[6];
                    sReader.Close();
                    return bk;
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            return null;
        }

      


    }
}
