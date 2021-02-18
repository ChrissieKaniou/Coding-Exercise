using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "hello world";
            String reverse = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse = reverse + str[i];
            }
            Console.WriteLine(reverse);
            Console.ReadLine();
        }
    }
}
