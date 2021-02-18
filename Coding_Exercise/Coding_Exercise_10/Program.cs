using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 6;
            bool prime = false;
            while (prime == false)
            {
                prime = true;
                num = num + 1;
                for (int i = 1; i <= num / 2; i++){
                    if (num % (i + 1) == 0)
                    {
                        prime = false;
                        break;
                    }
                }
            }
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
