using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            String x = "";
            int num = 5;
            for (int i = 1; i <= num; i++)
            {
                for (int j = num - i; j > 0; j--)
                {
                    x = x + "1";
                }
                for (int j = 0; j < i; j++)
                {
                    x = x + "*";
                    if (j != 0)
                    {
                        x = x + "*";
                    }
                }
                Console.WriteLine(x);
                x = "";
            }
            for (int i = 1; i < num; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    x = x + "1";
                }
                for (int j = num - i; j > 0; j--)
                {
                    x = x + "*";
                    if (j != 1)
                    {
                        x = x + "*";
                    }
                }
                Console.WriteLine(x);
                x = "";
            }
            Console.ReadLine();
        }
    }
}
