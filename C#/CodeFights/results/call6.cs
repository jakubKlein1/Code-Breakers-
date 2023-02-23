using System;
using System.Collections.Generic;

namespace CodeFights
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 2, 3, 5, 6, 7, 8, 10 };
            var result = RangeSolution(numbers);
            Console.WriteLine(result); // 1-3,5-8,10

            numbers = new[] { -10, -9, -8, -7, -5, -4, -2, 0, 1, 2, 3 };
            result = RangeSolution(numbers);
            Console.WriteLine(result); // -10--7,-5,-4,-2,0-3

            numbers = new[] { 1, 2 };
            result = RangeSolution(numbers);
            Console.WriteLine(result); // 1,2

            numbers = new[] { 1, 2, 3 };
            result = RangeSolution(numbers);
            Console.WriteLine(result); // 1-3

            numbers = new[] { -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 };
            result = RangeSolution(numbers);
            Console.WriteLine(result); // -6,-3-1,3-5,7-11,14,15,17-20

            numbers = new[] { -3, -2, -1, 2, 10, 15, 16, 18, 19, 20 };
            result = RangeSolution(numbers);
            Console.WriteLine(result); // -3--1,2,10,15,16,18-20
        }

        public static string RangeSolution(int[] args)
        {
            var ranges = new List<string>();
            var start = args[0];

            for (var i = 1; i < args.Length; i++)
            {
                if (args[i] - args[i - 1] != 1)
                {
                    if (i - start >= 3)
                    {
                        ranges.Add(start + "-" + args[i - 1]);
                    }
                    else
                    {
                        for (var j = start; j < i; j++)
                        {
                            ranges.Add(args[j].ToString());
                        }
                    }

                    start = i;
                }
            }

            if (args.Length - start >= 3)
            {
                ranges.Add(start + "-" + args[args.Length - 1]);
            }
            else
            {
                for (var j = start; j < args.Length; j++)
                {
                    ranges.Add(args[j].ToString());
                }
            }

            return String.Join(",", ranges);
        }
    }
}
