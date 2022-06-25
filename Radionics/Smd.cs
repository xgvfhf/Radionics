using System;
using System.Windows.Forms;

namespace Radionics
{
    class Smd
    {
        protected string value1;
        protected string value2;

        public string DefineParameters(string text)
        {
            if (text.Length == 3)
            {               
                value2 = text[2].ToString();
                if (text.StartsWith("0"))
                    value1 = text[1].ToString();
                else
                    value1 = text.Substring(0, 2);
                return GetValue();
            }
            else
                MessageBox.Show("Потрібно ввести 3 цифри!");
            return "";
                
        }
        public virtual string GetValue()
        { 
             return (Convert.ToInt32(value1) * Math.Pow(10, Convert.ToInt32(value2))).ToString() + " Oм";            
        }
        public virtual string GetCode(string text)
        {
            value1 = text[0].ToString();
            value2 = text[1].ToString();
            string value3 = Math.Log10(Convert.ToInt32(text) / Convert.ToDouble(value1 + value2)).ToString();
            return value1 + value2 + value3;
        }

    }
}
