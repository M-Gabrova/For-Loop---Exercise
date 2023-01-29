using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int sum = 0;
            int number;
            for (int i = 1; i <= n; i++)
            {
                number= int.Parse(Console.ReadLine());  
                sum += number;
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
               
            }
            sum -= maxNumber;
            if (sum == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");

            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNumber-sum)}");

            }
        }
    }
}
