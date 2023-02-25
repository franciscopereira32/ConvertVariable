using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertStringToInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = "1234";
            int b = Convert.ToInt32(number);
            Console.WriteLine(b);
        }
    }
}
