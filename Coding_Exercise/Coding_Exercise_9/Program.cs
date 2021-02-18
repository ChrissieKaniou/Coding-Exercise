using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 3;
            int num = 0;
            int count = 0;
            while (count < input)
            {
                count += 1;
                num = num + 1;
                for (int i = 1; i <= num / 2; i++)
                {
                    if (num % (i + 1) == 0)
                    {
                        count -= 1;
                        break;
                    }
                }
            }
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
