using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validate
{
    public class Validate
    {
        public static bool IsPresent(TextBox tb, string name)
        {
            bool isValid = true; // 'innocent until proven guilty
            if (tb.Text == "") //"bad dog"
            {
                isValid = false;
                MessageBox.Show(name + " is required", "Input Error");//MessageBox belongs to Forms and we are not here. in this case, right click on the bulb and use the option 
                tb.Focus();
            }
            return isValid;
        }

        public static bool IsInt32(TextBox tb, string name)
        {
            bool isValid = true;
            int val;
            if (!Int32.TryParse(tb.Text, out val))
            {
                isValid = false;
                MessageBox.Show(name + "must be a whole number", "Input Error");
                tb.SelectAll();//highlight the entire content in the textbox
                tb.Focus();
            }
            return isValid;
        }

        public static bool IsDouble(TextBox tb, string name)
        {
            bool isValid = true;
            double val;

            if (!Double.TryParse(tb.Text, out val))
            {
                isValid = false;
                MessageBox.Show(name + "must be a number", "Input Error");
                tb.SelectAll();//highlight the entire content in the textbox
                tb.Focus();
            }
            return isValid;
        }

        public static bool IsNonNegativeInt32(TextBox tb, string name)
        {
            bool isValid = true;
            int val;
            if (!Int32.TryParse(tb.Text, out val))
            {
                isValid = false;
                MessageBox.Show(name + "must be a whole number", "Input Error");
                tb.SelectAll();//highlight the entire content in the textbox
                tb.Focus();
            }
            else if (val < 0)
            {
                isValid = false;
                MessageBox.Show(name + "must be positive or zero", "Input Error");
                tb.SelectAll();//highlight the entire content in the textbox
                tb.Focus();
            }
            return isValid;
        }

        public static bool IsNonNegativeDouble(TextBox tb, string name)
        {
            bool isValid = true;
            double val;
            if (!Double.TryParse(tb.Text, out val))
            {
                isValid = false;
                MessageBox.Show(name + "must be a number", "Input Error");
                tb.SelectAll();//highlight the entire content in the textbox
                tb.Focus();
            }
            else if (val < 0)
            {
                isValid = false;
                MessageBox.Show(name + "must be positive or zero", "Input Error");
                tb.SelectAll();//highlight the entire content in the textbox
                tb.Focus();
            }
            return isValid;
        }

        public static bool IsNonNegativeDecimal(TextBox tb, string name)
        {
            bool isValid = true;
            decimal val;
            if (!Decimal.TryParse(tb.Text, out val))
            {
                isValid = false;
                MessageBox.Show(name + "must be a number", "Input Error");
                tb.SelectAll();//highlight the entire content in the textbox
                tb.Focus();
            }
            else if (val < 0)
            {
                isValid = false;
                MessageBox.Show(name + "must be positive or zero", "Input Error");
                tb.SelectAll();//highlight the entire content in the textbox
                tb.Focus();
            }
            return isValid;
        }





    }
}
