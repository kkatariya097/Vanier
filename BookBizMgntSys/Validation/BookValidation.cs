using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BookBizMgntSys.Validation
{
    public static class BookValidation
    {


        //Book ISBN should be not more than 5 Digits 
        // No Letters are accepted, only numbers.

        public static bool checkBookISBN(TextBox input)
        {
            int id;
            if ((input.TextLength != 5) || !((Int32.TryParse(input.Text, out id))))
            {
                MessageBox.Show("ISBN should be of 5 digits. Please try again.");
                input.Clear();
                input.Focus();
                return false;
            }
            return true;

        }

        // no number validation, only stings 

        //Client Name should be all letters. No Numbers accepted.
        public static bool checkstring(TextBox input)
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


        public static bool checkYear(TextBox input)
        {
            if (Regex.Match(input.Text, @"^[12][0-9]{3}$").Success)
            {
                return true;
            }
            else
            {
                MessageBox.Show( "invalid year. Please try again.");
                return false;
            }

        }

        //  if (!Regex.Match(input.Text, @"^[12][0-9]{3}$").Success)


        public static bool checkEmail(TextBox input)
        {
            if (Regex.IsMatch(input.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
                return false;
        }


        //bool isEmail = Regex.IsMatch(emailString, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);








    }
}
