 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_referens_to_texbox_22_03_2022
{
    public static class Class_ref
    {
        //public string text_texbox { get; set; }
        //Class_ref() { }
        //Class_ref(string _text)
        //{ 
        //text_texbox = _text;
        //}
        public static List <string> text_ref(ref string text_str)
        {
           List<string> list = new List<string>();
            string[] separator = { "\n", "\r" };
            string [] mass_str = text_str.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in mass_str) 
            {
                list.Add(s);
            }
            return list;
        }
       
    }
}
