using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numTournaments = int.Parse(Console.ReadLine());
            int pointsInitial = int.Parse(Console.ReadLine());
            string stage;
            int winnedTournaments = 0;
            int pointsWon = 0;
            int pointsW = 0;
            int pointsF = 0;
            int pointsSF = 0;
            int totalPoints = 0;

            for (int i = 1; i <= numTournaments; i++)
            {
                stage = Console.ReadLine();

                if (stage == "W")
                {
                    pointsW += 2000;
                    winnedTournaments++;
                }
                else if (stage == "F")
                {
                    pointsF += 1200;
                }
                else
                {
                    pointsSF += 720;
                }
            }

            totalPoints = pointsInitial + pointsF + pointsSF + pointsW;
            pointsWon = pointsW + pointsSF + pointsF;

            double averagePoints = Math.Floor((double)pointsWon / numTournaments);

            double percentWon = (double)winnedTournaments / numTournaments * 100;

            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{percentWon:f2}%") ;


        }
    }
}
