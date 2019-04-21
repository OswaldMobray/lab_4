using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab_4
{
    public partial class CheckWeb
    {
        public int Min(int a, int b, int c)
        {
            int min = a;
            if (min > b) min = b;
            if (min > c) min = c;
            return min;
        }
        public int Max(int a, int b, int c)
        {
            int max = a;
            if (max > b) max = b;
            if (max > c) max = c;
            return max;
        }
        public bool Check(string userWebAddress)
        {
            string pattern = @"^http(s)?://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$";
            Regex reg = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

            if(reg.IsMatch(userWebAddress))
            {
                Console.WriteLine("Это корректный Web-адрес.\n");
                return true;
            }
            else
            {
                Console.WriteLine("Это не корректный Web-адрес.\n");
                return false;
            }
        }

        public string CreateRightAddress(string str,string type)
        {
            string newAddress = $"http://{str}.{type}";

            return newAddress;
        }
    }
}
