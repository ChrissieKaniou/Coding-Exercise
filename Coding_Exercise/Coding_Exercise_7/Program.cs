using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input:");
                String input = Console.ReadLine();
                int result = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    result += input[i] - '0';
                }
                Console.WriteLine("Output:");
                Console.WriteLine(result);
            }
        }
    }
}
