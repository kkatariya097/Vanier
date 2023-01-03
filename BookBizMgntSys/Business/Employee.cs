using BookBizMgntSys.Data_IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBizMgntSys.Business
{
    public class Employee
    {
        public int EmployeeID
        { get; set; }

        public string EmployeeFName
        { get; set; }

        public string EmployeeLName
        { get; set; }

        public string EmployeeRole
        { get; set; }

        public string EmployeeEmail
        { get; set; }

        public string EmployeePhone
        { get; set; }

        //Save new Employee
        public void SaveaEmployee(Employee emp)
        {
            MISManagerIO.SaveEmployee(emp);
        }

        //Update Employee
        public bool UpdateaEmployee(Employee emp)
        {
            return MISManagerIO.UpdateEmployee(emp);
        }

        //List all Employee
        public void ListAllEmployee(ListView listview)
        {
            MISManagerIO.ListEmployee(listview);
        }

    }
}
