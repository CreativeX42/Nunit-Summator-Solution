using System;

namespace Summator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Summator.Sum(new int[] { 1, 2, 3, 4, 5, 6, });
            if (result == 21)
            {
                Console.WriteLine("Test Pass");
            }
            else
            {
                Console.WriteLine("Test fail");
            }
        }
    }
}