using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sales = { 1, 2, 1, 1, 0, 3, 1, 0, 0, 2, 4, 1, 0, 0, 0, 0, 2, 1, 0, 3, 1, 0, 0, 0, 6, 1, 3, 0, 0, 0, };
            int count = 0;
            int count2 = 0;

            for (int i = 0; i < sales.Length; i++)
            {
                if (sales[i] == 0)
                {
                    count++;
                }
                if (count > count2)
                {
                    count2 = count;
                }
                if (sales[i] != 0)
                {
                    count = 0;
                }
            }
            Console.WriteLine(count2);
            Console.ReadLine();
        }
    }
}
