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
    public static class OrderClerkIO
    {
        private static string filePath = Application.StartupPath + @"\OrderInventory.dat";
        private static string fileTemp = Application.StartupPath + @"\Temp.dat";

        //Save record
        public static void SaveClerk(OrderClerk oc)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(oc.OrderID + "," + oc.ModeOfOrder + "," + oc.Publisher + "," + oc.BookName + "," + oc.OrderedBy + "," + oc.Quantity + "," + oc.OrderClrk + "," + oc.Author);
            sWriter.Close();
            MessageBox.Show("OrderClerk Data has been saved.");

        }


        // list all data from file to Form List View
        public static void ListOrderClerk(ListView lOC)
        {

            StreamReader sReader = new StreamReader(filePath);
            lOC.Items.Clear();

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
                item.SubItems.Add(fields[7]);
                lOC.Items.Add(item);
                line = sReader.ReadLine();
            }
            sReader.Close();
        }


        //populates list<> from file
        public static List<OrderClerk> ListOrderClerk()
        {
            List<OrderClerk> listoc = new List<OrderClerk>();
            StreamReader sReader = new StreamReader(filePath);

            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                OrderClerk oc = new OrderClerk();
                oc.OrderID = Convert.ToInt32(fields[0]);
                oc.ModeOfOrder = fields[1];
                oc.Publisher = fields[2];
                oc.BookName = fields[3];
                oc.OrderedBy = fields[4];
                oc.Quantity = Convert.ToInt32(fields[5]);
                oc.OrderClrk = fields[6];
                oc.Author = fields[7];
                listoc.Add(oc);
                line = sReader.ReadLine();
            }
            sReader.Close();
            return listoc;
        }

        //search OrderClerk from file
        public static OrderClerk SearchClerk(int ocId)
        {
            OrderClerk oc = new OrderClerk();

            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (ocId == Convert.ToInt32(fields[0]))
                {
                    oc.OrderID = Convert.ToInt32(fields[0]);
                    oc.ModeOfOrder = fields[1];
                    oc.Publisher = fields[2];
                    oc.BookName = fields[3];
                    oc.OrderedBy = fields[5];
                    oc.Quantity = Convert.ToInt32(fields[6]);
                    oc.OrderClrk = fields[6];
                    oc.Author = fields[7];
                    sReader.Close();
                    return oc;
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            return null;
        }

        //delete record from file
        public static bool DeleteClerk(int ocId)
        {
            try
            {
                StreamReader sReader = new StreamReader(filePath);
                string line = sReader.ReadLine();
                StreamWriter sWriter = new StreamWriter(fileTemp, true);
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if ((ocId) != (Convert.ToInt32(fields[0])))
                    {

                        sWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6] + "," + fields[7]);


                    }
                    line = sReader.ReadLine();
                }
                sReader.Close();
                sWriter.Close();
                File.Delete(filePath);
                File.Move(fileTemp, filePath);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        //update record in file
        public static bool UpdateClerk(OrderClerk oc)
        {
            try
            {
                StreamReader sReader = new StreamReader(filePath);
                StreamWriter sWriter = new StreamWriter(fileTemp, true);
                string line = sReader.ReadLine();

                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if ((Convert.ToInt32(fields[0]) != (oc.OrderID)))
                    {
                        sWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6] + "," + fields[7]);
                    }

                    line = sReader.ReadLine();      
                }
                sWriter.WriteLine(oc.OrderID + "," + oc.ModeOfOrder + "," + oc.Publisher + "," + oc.BookName + "," + oc.OrderedBy + "," + oc.Quantity + "," + oc.OrderClrk + "," + oc.Author);
                sReader.Close();
                sWriter.Close();
                File.Delete(filePath);
                File.Move(fileTemp, filePath);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
