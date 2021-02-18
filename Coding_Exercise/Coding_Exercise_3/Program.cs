using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*String x = "";
            int num = 5;
            for (int i = 1; i <= num; i++)
            {
                for (int j = num - i; j > 0; j--)
                {
                    x = x + " ";
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
            Console.ReadLine();*/
            var numbers = new[] { 12.7, 10.3, 6.11, 4.1 };
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);

            var result = 0.0;
            foreach (var number in grades)
            {
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine(result);
            //Console.WriteLine(grades.Count);
            //Console.WriteLine(grades.Capacity);
            Console.ReadLine();
        }
    }
}
