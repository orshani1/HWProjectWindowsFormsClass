using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWProjectWindowsFormsClass
{
    public static class ValidationClass
    {
        public static bool IsNotNumber(this TextBox text)
        {
            foreach (var item in text.Text)
            {
                if(char.IsNumber(item)== false)
                {
                    return true;   
                }
                else
                    return false;
            }
            return false;

        }
        public static bool IsLessThanNine(this TextBox text)
        {
            if(text.Text.Length <9)
            {
                return true;
            }
            return false;
        }
        public static bool IsLessThanTen(this TextBox text)
        {
            if (text.Text.Length < 10)
            {
                return true;
            }
            return false;
        }
        public static bool IsNotRealName(this TextBox text)
        {
            if(text.Text == string.Empty)
                return true;
            if(text.Text.Length < 2)
            {
                return true;
            }
            foreach (var item in text.Text)
            {
                if(char.IsNumber(item) == true)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
