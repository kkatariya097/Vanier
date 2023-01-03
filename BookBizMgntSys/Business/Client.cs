using BookBizMgntSys.Data_IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBizMgntSys.Business
{
    public class Client
    {
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public string ClientStreet { get; set; }
        public string ClientCity { get; set; }
        public string ClientPostal { get; set; }
        public string ClientPhone { get; set; }
        public string ClientFax { get; set; }
        public string ClientEmail { get; set; }



        //Save new Client Info
        public void SaveaClient(Client client)
        {
            SalesManagerIO.SaveClient(client);
        }

        //Update Client
        public bool UpdateaClient(Client client)
        {
            return SalesManagerIO.UpdateClient(client);
        }

        //List all Clients
        public void ListAllClients(ListView listview)
        {
            SalesManagerIO.ListClients(listview);
        }









    }
}
