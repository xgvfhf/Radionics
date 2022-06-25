using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Radionics
{
    class Ceramic : Smd
    {
        public override string GetValue()
        {
            if (Convert.ToInt32(value2) == 8)
            {
                return (Convert.ToInt32(value1) * Math.Pow(10, -2)).ToString() + " пФ";
               
            }
            else if (Convert.ToInt32(value2) == 9)
            {
                return (Convert.ToInt32(value1) * Math.Pow(10, -1)).ToString() + " пФ";
            }
            else
                return (Convert.ToInt32(value1) * Math.Pow(10, Convert.ToInt32(value2))).ToString() + " пФ";
        }
        public override string GetCode(string text)
        {
           
                List<char> arr = new List<char>();
                if (text.Contains("."))
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (text[i].CompareTo('0') != 0 && text[i].CompareTo('.') != 0)
                        {
                            arr.Add(text[i]);
                        }
                    }
                    arr.Add('0');
                    arr.Add('0');
                    value1 = arr[0].ToString();
                    value2 = arr[1].ToString();
                    string value = Math.Log10(Convert.ToDouble(text, CultureInfo.InvariantCulture) / Convert.ToDouble(value1 + value2)).ToString();
                    string value3 = "";
                    switch (value)
                    {
                        case "-1":
                            value3 = "9";
                            break;
                        case "-2":
                            value3 = "8";
                            break;
                    }
                    return value1 + value2 + value3;

                }
                else if (text.Length == 1)
                    return text + "09";

                else
                    return text[0].ToString() + text[1].ToString() + (text.Length - 2).ToString();
        }
           
            
            
           
    }
}
