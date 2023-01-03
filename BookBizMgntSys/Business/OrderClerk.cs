using BookBizMgntSys.Data_IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBizMgntSys.Business
{
    public class OrderClerk
    {
        public int OrderID { get; set; }
        public string ModeOfOrder { get; set; }
        public string Publisher { get; set; }
        public string BookName { get; set; }
        public string OrderedBy { get; set; }
        public int Quantity { get; set; }
        public string OrderClrk { get; set; }
        public string Author { get; set; }





        public List<OrderClerk> ListAllOrder()
        {
            return OrderClerkIO.ListOrderClerk();
        }
        public OrderClerk SearchBy(int id)
        {
            return OrderClerkIO.SearchClerk(id);
        }
        public void Save(OrderClerk mis)
        {
            OrderClerkIO.SaveClerk(mis);
        }
        public bool Delete(int id)
        {
            return OrderClerkIO.DeleteClerk(id);
        }
        public bool Update(OrderClerk mis)
        {
            return OrderClerkIO.UpdateClerk(mis);
        }
       
    }
    }
