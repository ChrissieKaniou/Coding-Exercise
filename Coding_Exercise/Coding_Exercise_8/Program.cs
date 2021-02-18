using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>() { 3, 1, 5, 7, 5, 9 };
            int[] nums = new int[] { 3, 1, 5, 7, 5, 9 };
            int target = 10;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                for (int j = 0; j <= nums.Length - 1; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine("({0},{1})", i, j);
                        Console.ReadLine();
                    }
                }
            }
            Console.WriteLine("null");
            Console.ReadLine();
        }
    }
}
