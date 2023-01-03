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
    public static class MISManagerIO
    {

        private static string filePath = Application.StartupPath + @"\MISManager.dat";
        private static string fileTemp = Application.StartupPath + @"\Temp.dat";

        //Save New Employee
        public static void SaveEmployee(Employee emp)
        {
            StreamWriter sw = new StreamWriter(filePath, true);
            sw.WriteLine(emp.EmployeeID + "," + emp.EmployeeFName + "," + emp.EmployeeLName + "," + emp.EmployeeRole + "," + emp.EmployeeEmail + "," + emp.EmployeePhone);
            sw.Close();
            MessageBox.Show("New Employee Data Saved.");
        }


        //Update Employee data 
        public static bool UpdateEmployee(Employee emp)
        {
            try
            {
                StreamReader sr = new StreamReader(filePath);
                StreamWriter sw = new StreamWriter(fileTemp, true);
                string line = sr.ReadLine();

                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if ((Convert.ToInt32(fields[0]) != (emp.EmployeeID)))
                    {
                        sw.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5]);
                    }
                    line = sr.ReadLine();
                }
                sw.WriteLine(emp.EmployeeID + "," + emp.EmployeeFName + "," + emp.EmployeeLName + "," + emp.EmployeeRole + "," + emp.EmployeeEmail + "," + emp.EmployeePhone);
                sw.Close();
                sr.Close();
                File.Delete(filePath);
                File.Move(fileTemp, filePath);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false; 
            }
        }


        //List all Employees
        public static void ListEmployee(ListView listViewEmployee)
        {
            StreamReader sr = new StreamReader(filePath);
            listViewEmployee.Items.Clear();
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
                listViewEmployee.Items.Add(item);
                line = sr.ReadLine();
            }
            sr.Close();
        }


        //Search Employee by Employee ID 
        public static Employee SearchbyEmpID(int empid)
        {
            Employee emp = new Employee();
            StreamReader streamReader = new StreamReader(filePath);
            string line = streamReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (empid == Convert.ToInt32(fields[0]))
                {
                    emp.EmployeeID = Convert.ToInt32(fields[0]);
                    emp.EmployeeFName = fields[1];
                    emp.EmployeeLName = fields[2];
                    emp.EmployeeRole = fields[3];
                    emp.EmployeeEmail = fields[4];
                    emp.EmployeePhone = fields[5];
                    streamReader.Close();
                    return emp;
                }
                line = streamReader.ReadLine();
            }
            streamReader.Close();
            
            
            return null;
        }


        //Search Employee by Employee First Name
        public static Employee SearchbyEmpFName(string name)
        {
            Employee emp = new Employee();
            StreamReader streamReader = new StreamReader(filePath);
            string line = streamReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (name.Equals(fields[1]))
                {
                    emp.EmployeeID = Convert.ToInt32(fields[0]);
                    emp.EmployeeFName = fields[1];
                    emp.EmployeeLName = fields[2];
                    emp.EmployeeRole = fields[3];
                    emp.EmployeeEmail = fields[4];
                    emp.EmployeePhone = fields[5];
                    streamReader.Close();
                    return emp;
                }
                line = streamReader.ReadLine();
            }
            streamReader.Close();


            return null;
        }

        //Search Employee by Employee First Name
        public static Employee SearchbyEmpLName(string name)
        {
            Employee emp = new Employee();
            StreamReader streamReader = new StreamReader(filePath);
            string line = streamReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (name.Equals(fields[2]))
                {
                    emp.EmployeeID = Convert.ToInt32(fields[0]);
                    emp.EmployeeFName = fields[1];
                    emp.EmployeeLName = fields[2];
                    emp.EmployeeRole = fields[3];
                    emp.EmployeeEmail = fields[4];
                    emp.EmployeePhone = fields[5];
                    streamReader.Close();
                    return emp;
                }
                line = streamReader.ReadLine();
            }
            streamReader.Close();


            return null;
        }

        //Search Employee by Employee Role
        public static Employee SearchbyEmpRole(string name)
        {
            Employee emp = new Employee();
            StreamReader streamReader = new StreamReader(filePath);
            string line = streamReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (name.Equals(fields[3]))
                {
                    emp.EmployeeID = Convert.ToInt32(fields[0]);
                    emp.EmployeeFName = fields[1];
                    emp.EmployeeLName = fields[2];
                    emp.EmployeeRole = fields[3];
                    emp.EmployeeEmail = fields[4];
                    emp.EmployeePhone = fields[5];
                    streamReader.Close();
                    return emp;
                }
                line = streamReader.ReadLine();
            }
            streamReader.Close();


            return null;
        }








    }
}
