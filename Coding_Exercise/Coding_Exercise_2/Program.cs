using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] arr = {"parts", "traps", "arts", "rats", "starts", "tarts", "rat", "art", "tar", "tars", "stars", "stray"};
            
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i].Length == 4 && arr[i].IndexOf('s') != -1 && arr[i].IndexOf('t') != -1 && arr[i].IndexOf('a') != -1 && arr[i].IndexOf('r') != -1)
                {
                    Console.WriteLine(arr[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
