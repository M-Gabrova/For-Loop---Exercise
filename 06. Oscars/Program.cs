using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int juryCount = int.Parse(Console.ReadLine());


            for (int i = 0; i < juryCount; i++)
            {
                string juryName = Console.ReadLine();
                double juryPoints = double.Parse(Console.ReadLine());

                points += juryName.Length * juryPoints / 2;

                if (points > 1250.49)
                {
                    break;
                }
            }

            if (points > 1250.49)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:f1}!");
            }
            else
            {
                double pointsNeeded = 1250.50 - points;
                Console.WriteLine($"Sorry, {actorName} you need {pointsNeeded:f1} more!");
            }
        }


    }
}
