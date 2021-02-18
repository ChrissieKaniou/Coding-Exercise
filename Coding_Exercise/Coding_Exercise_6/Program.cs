using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                String reverse = "";
                String str = Console.ReadLine();
                char[] strArr = str.ToCharArray();
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    reverse = reverse + strArr[i];
                }
                if (reverse.Equals(str))
                {
                    Console.WriteLine("Palindrome");
                }
                else
                {
                    Console.WriteLine("Not Palindrome");
                }
            }
        }
    }
}
