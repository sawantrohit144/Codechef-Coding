using System;
using System.Collections.Generic;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());

        while (T-- > 0)
        {
            string[] input = Console.ReadLine().Split();

            int A=int.Parse(input[0]);
            int B=int.Parse(input[1]);
            int C=int.Parse(input[2]);

            if ((A+B)/2.0>C)
                 Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

        }
    }
}
