using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBizMgntSys.Validation
{
    public static class EmployeeValidation
    {
        //Employee ID should be not more than 4 Digits 
        // No Letters are accepted, only numbers.

        public static bool checkEmpID(TextBox input)
        {
            int id;
            if ((input.TextLength != 4) || !((Int32.TryParse(input.Text, out id))))
            {
                MessageBox.Show("Employee ID should be of four digits.Please try again.");
                input.Clear();
                input.Focus();
                return false;
            }
            return true;

        }

        //Employee First Name should be all letters. No Numbers accepted.
        public static bool checkEmpFName(TextBox input)
        {
            for (int i = 0; i < input.TextLength; i++)
            {
                if (char.IsDigit(input.Text, i) || (char.IsWhiteSpace(input.Text, i)))
                {
                    MessageBox.Show("First Name should be all text(no number excepted). Please try again.");
                    input.Clear();
                    input.Focus();
                    return false;
                }

            }
            return true;

        }

        //Employee  Last Name should be all letters. No Numbers accepted.
        public static bool checkEmpLName(TextBox input)
        {
            for (int i = 0; i < input.TextLength; i++)
            {
                if (char.IsDigit(input.Text, i) || (char.IsWhiteSpace(input.Text, i)))
                {
                    MessageBox.Show("Last Name should be all text(no number excepted). Please try again.");
                    input.Clear();
                    input.Focus();
                    return false;
                }

            }
            return true;

        }

        public static bool checkEmail(TextBox input)
        {
            if (Regex.IsMatch(input.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Email. Please try again.");
                input.Clear();
                input.Focus();
                return false;
            }
        }










    }
}
