using BookBizMgntSys.Business;
using BookBizMgntSys.Data_IO;
using BookBizMgntSys.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBizMgntSys.GUI
{
    public partial class FormMISManager : Form
    {
        //lists 
        List<Employee> empList = new List<Employee>();
        List<Employee> empListTemp = new List<Employee>();


        public FormMISManager()
        {
            InitializeComponent();
        }

        //clear all textboxes mentioned below
        public void ClearAll()
        {
            textBoxEmpID.Clear();
            textBoxEmpFName.Clear();
            textBoxEmpLName.Clear();
            textBoxEmpRole.Clear();
            textBoxEmpEmail.Clear();
            maskedTextBoxEmpPhone.Clear();
        }


        //this method will add data to listviewEmployee
        public void addintoListView(Employee emp)
        {
            ListViewItem item = new ListViewItem(emp.EmployeeID.ToString());
            item.SubItems.Add(emp.EmployeeFName);
            item.SubItems.Add(emp.EmployeeLName);
            item.SubItems.Add(emp.EmployeeRole);
            item.SubItems.Add(emp.EmployeeEmail);
            item.SubItems.Add(emp.EmployeePhone);
            listViewMIS.Items.Add(item);
        }

        //No duplicate values check function
        private bool checkEmpData(Employee emp)
        {
            foreach (Employee empobj in empListTemp)
            {
                if (empobj.EmployeeID.Equals(emp.EmployeeID))
                {
                    return false;
                }
            }
            return true;

        }


        //Focus on Emp ID when form load
        private void FormMISManager_Load(object sender, EventArgs e)
        {
            textBoxEmpID.Focus();
            buttonSearchEmp.Enabled = false;
        }


        //Exit to Home Page
        private void buttonhome_Click(object sender, EventArgs e)
        {
            FormHome homeobj = new FormHome();
            homeobj.Show();
            this.Close();
        }

        private void labelEPhone_Click(object sender, EventArgs e)
        {

        }


        //Save Button Code - Saving new Employee
        private void buttonSaveEmp_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            if((EmployeeValidation.checkEmpID(textBoxEmpID)) 
                && EmployeeValidation.checkEmpFName(textBoxEmpFName) 
                && EmployeeValidation.checkEmpLName(textBoxEmpLName)
                && EmployeeValidation.checkEmail(textBoxEmpEmail))
            {
                employee.EmployeeID = Convert.ToInt32(textBoxEmpID.Text);
                employee.EmployeeFName = textBoxEmpFName.Text;
                employee.EmployeeLName = textBoxEmpLName.Text;
                employee.EmployeeRole = textBoxEmpRole.Text;
                employee.EmployeeEmail = textBoxEmpEmail.Text;
                employee.EmployeePhone = maskedTextBoxEmpPhone.Text;
                // employee.SaveaEmployee(employee);
                //ClearAll();
                listViewMIS.Items.Clear();

                //immediate add to listview while saving 
                if (empListTemp.Count > 0)
                {
                    if (checkEmpData(employee))
                    {
                        employee.SaveaEmployee(employee);
                    }
                    else
                    {
                         employee.UpdateaEmployee(employee);
                        MessageBox.Show("Employee Already Exist. Data Updated Successfully.");
                    }
                }
                else
                {
                    empListTemp.Add(employee);
                    employee.SaveaEmployee(employee);
                }
                addintoListView(employee);
                employee.ListAllEmployee(listViewMIS);
                ClearAll();

            }
        }

        private void buttonSearchEmp_Click(object sender, EventArgs e)
        {
            int option = comboBoxSearch.SelectedIndex;

            switch (option)
            {
                case -1:
                    MessageBox.Show("Select a option to search from Combo Box.");
                    break;

                //search by Employee id
                case 0:
                    {
                        Employee employee = MISManagerIO.SearchbyEmpID(Convert.ToInt32(textBoxSearchInfo.Text));
                        if (employee != null)
                        {
                            textBoxEmpID.Text = employee.EmployeeID.ToString();
                            textBoxEmpFName.Text = employee.EmployeeFName;
                            textBoxEmpLName.Text = employee.EmployeeLName;
                            textBoxEmpRole.Text = employee.EmployeeRole;
                            textBoxEmpEmail.Text = employee.EmployeeEmail;
                            maskedTextBoxEmpPhone.Text = employee.EmployeePhone;
                        }
                        else
                        {
                            MessageBox.Show("Employee Not Found. Enter Valid Employee ID or try again.");
                            ClearAll();
                            textBoxSearchInfo.Focus();
                        }
                        break;
                    }

                //search by Employee First Name
                case 1:
                    {
                        Employee employee = MISManagerIO.SearchbyEmpFName(textBoxSearchInfo.Text);
                        if (employee != null)
                        {
                            textBoxEmpID.Text = employee.EmployeeID.ToString();
                            textBoxEmpFName.Text = employee.EmployeeFName;
                            textBoxEmpLName.Text = employee.EmployeeLName;
                            textBoxEmpRole.Text = employee.EmployeeRole;
                            textBoxEmpEmail.Text = employee.EmployeeEmail;
                            maskedTextBoxEmpPhone.Text = employee.EmployeePhone;
                        }
                        else
                        {
                            MessageBox.Show("Employee Not Found. Enter Valid Employee Name or try again.");
                            ClearAll();
                            textBoxSearchInfo.Focus();
                        }
                        break;
                    }

                //search by Employee Last Name

                case 2:
                    {
                        Employee employee = MISManagerIO.SearchbyEmpLName(textBoxSearchInfo.Text);
                        if (employee != null)
                        {
                            textBoxEmpID.Text = employee.EmployeeID.ToString();
                            textBoxEmpFName.Text = employee.EmployeeFName;
                            textBoxEmpLName.Text = employee.EmployeeLName;
                            textBoxEmpRole.Text = employee.EmployeeRole;
                            textBoxEmpEmail.Text = employee.EmployeeEmail;
                            maskedTextBoxEmpPhone.Text = employee.EmployeePhone;
                        }
                        else
                        {
                            MessageBox.Show("Employee Not Found. Enter Valid Employee Name or try again.");
                            ClearAll();
                            textBoxSearchInfo.Focus();
                        }
                        break;
                    }
                //search by Employee role 

                case 3:
                    {
                        Employee employee = MISManagerIO.SearchbyEmpRole(textBoxSearchInfo.Text);
                        if (employee != null)
                        {
                            textBoxEmpID.Text = employee.EmployeeID.ToString();
                            textBoxEmpFName.Text = employee.EmployeeFName;
                            textBoxEmpLName.Text = employee.EmployeeLName;
                            textBoxEmpRole.Text = employee.EmployeeRole;
                            textBoxEmpEmail.Text = employee.EmployeeEmail;
                            maskedTextBoxEmpPhone.Text = employee.EmployeePhone;
                        }
                        else
                        {
                            MessageBox.Show("Employee Not Found. Enter Valid Employee Name or try again.");
                            ClearAll();
                            textBoxSearchInfo.Focus();
                        }
                        break;
                    }

            }
        }


        //List to ListView from file
        private void buttonListEmp_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            listViewMIS.Items.Clear();
            emp.ListAllEmployee(listViewMIS);
           
        }

        private void textBoxSearchInfo_TextChanged(object sender, EventArgs e)
        {
            buttonSearchEmp.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSearchEmp.Enabled = true;
            int option = comboBoxSearch.SelectedIndex;
            switch (option)
            {
                case 0:
                    {
                        labelSearchInfo.Text = "Enter Employee ID :";
                        textBoxSearchInfo.Focus();
                        break;
                    }

                case 1:
                    {
                        labelSearchInfo.Text = "Enter Employee First Name :";
                        textBoxSearchInfo.Focus();
                        break;
                    }

                case 2:
                    {
                        labelSearchInfo.Text = "Enter Employee's Last Name :";
                        textBoxSearchInfo.Focus();
                        break;
                    }

                case 3:
                    {
                        labelSearchInfo.Text = "Enter Employee's Role :";
                        textBoxSearchInfo.Focus();
                        break;
                    }

            }
        }

        private void listViewMIS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
