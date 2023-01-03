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
    public static class SalesManagerIO
    {
        private static string filePath = Application.StartupPath + @"\SalesManager.dat";
        private static string fileTemp = Application.StartupPath + @"\Temp.dat";

        //Save New Client 
        public static void SaveClient(Client client)
        {
            StreamWriter sw = new StreamWriter(filePath, true);
            sw.WriteLine(client.ClientID + "," + client.ClientName + "," + client.ClientStreet + "," +client.ClientCity + "," + client.ClientPostal + "," + client.ClientPhone + "," + client.ClientFax + "," + client.ClientEmail);
            sw.Close();
            MessageBox.Show("New Client Data Saved.");
        }

        //Update Client data 
        public static bool UpdateClient(Client client)
        {
            try
            {
                StreamReader sr = new StreamReader(filePath);
                StreamWriter sw = new StreamWriter(fileTemp, true);
                string line = sr.ReadLine();

                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if ((Convert.ToInt32(fields[0]) != (client.ClientID)))
                    {
                        sw.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6] + "," + fields[7]);
                    }
                    line = sr.ReadLine();
                }
                sw.WriteLine(client.ClientID + "," + client.ClientName + "," + client.ClientStreet + "," + client.ClientCity + "," + client.ClientPostal + "," + client.ClientPhone + "," + client.ClientFax + "," + client.ClientEmail);
                sw.Close();
                sr.Close();
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

        //List all Clients
        public static void ListClients(ListView listViewClient)
        {
            StreamReader sr = new StreamReader(filePath);
            listViewClient.Items.Clear();
            string line = sr.ReadLine();

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
                listViewClient.Items.Add(item);
                line = sr.ReadLine();
            }
            sr.Close();
        }

        //Search Client by Client ID 
        public static Client SearchbyClientID(int clientid)
        {
            Client client = new Client();
            StreamReader streamReader = new StreamReader(filePath);
            string line = streamReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (clientid == Convert.ToInt32(fields[0]))
                {
                    client.ClientID = Convert.ToInt32(fields[0]);
                    client.ClientName = fields[1];
                    client.ClientStreet = fields[2];
                    client.ClientCity =  fields[3];
                    client.ClientPostal = fields[4];
                    client.ClientPhone = fields[5];
                    client.ClientFax = fields[6];
                    client.ClientEmail = fields[7];
                    streamReader.Close();
                    return client;
                }
                line = streamReader.ReadLine();
            }
            streamReader.Close();


            return null;
        }



        //Search Client by Client Name
        public static Client SearchbyClientName(string name)
        {
            Client client = new Client();
            StreamReader streamReader = new StreamReader(filePath);
            string line = streamReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (name.Equals(fields[1]))
                {
                    client.ClientID = Convert.ToInt32(fields[0]);
                    client.ClientName = fields[1];
                    client.ClientStreet = fields[2];
                    client.ClientCity = fields[3];
                    client.ClientPostal = fields[4];
                    client.ClientPhone = fields[5];
                    client.ClientFax = fields[6];
                    client.ClientEmail = fields[7];
                    streamReader.Close();
                    return client;
                }
                line = streamReader.ReadLine();
            }
            streamReader.Close();


            return null;
        }


        //Search Client by Client Postal Code
        public static Client SearchbyClientPostal(string pos)
        {
            Client client = new Client();
            StreamReader streamReader = new StreamReader(filePath);
            string line = streamReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (pos.Equals(fields[4]))
                {
                    client.ClientID = Convert.ToInt32(fields[0]);
                    client.ClientName = fields[1];
                    client.ClientStreet = fields[2];
                    client.ClientCity = fields[3];
                    client.ClientPostal = fields[4];
                    client.ClientPhone = fields[5];
                    client.ClientFax = fields[6];
                    client.ClientEmail = fields[7];
                    streamReader.Close();
                    return client;
                }
                line = streamReader.ReadLine();
            }
            streamReader.Close();


            return null;
        }








    }
}
