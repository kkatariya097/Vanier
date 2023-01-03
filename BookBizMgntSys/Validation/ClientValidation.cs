using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBizMgntSys.Validation
{
    public static class ClientValidation
    {
        //Client ID should be not more than 4 Digits 
        // No Letters are accepted, only numbers.

        public static bool checkClientID(TextBox input)
        {
            int id;
            if ((input.TextLength != 4) || !((Int32.TryParse(input.Text, out id))))
            {
                MessageBox.Show("Client ID should be of four digits. Please try again.");
                input.Clear();
                input.Focus();
                return false;
            }
            return true;

        }

        //Client Name should be all letters. No Numbers accepted.
        public static bool checkCLientName(TextBox input)
        {
            for (int i = 0; i < input.TextLength; i++)
            {
                if (char.IsDigit(input.Text, i) || (char.IsWhiteSpace(input.Text, i)))
                {
                    MessageBox.Show(input + " is invalid(No number excepted). Please try again.");
                    input.Clear();
                    input.Focus();
                    return false;
                }

            }
            return true;

        }

        //postal code validation 
        public static bool checkPostal(TextBox input)
        {
            int id;
            if ((input.TextLength != 6) || !((Int32.TryParse(input.Text, out id))))
            {
                MessageBox.Show("Postal Code should be of 6 digits. Please try again.");
                input.Clear();
                input.Focus();
                return false;
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
