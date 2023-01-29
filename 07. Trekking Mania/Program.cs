using System;

namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numGroups = int.Parse(Console.ReadLine());
            int mussala = 0;
            int montblan = 0;
            int kilimandjaro = 0;
            int k2 = 0;
            int everest = 0;

            int numPeopleInAGroup;

            for (int i = 0; i < numGroups; i++)
            {
                numPeopleInAGroup = int.Parse(Console.ReadLine());

                if (numPeopleInAGroup < 6)
                    mussala += numPeopleInAGroup;
                else if (numPeopleInAGroup < 13)
                    montblan += numPeopleInAGroup;
                else if (numPeopleInAGroup < 26)
                    kilimandjaro += numPeopleInAGroup;
                else if (numPeopleInAGroup < 41)
                    k2 += numPeopleInAGroup;
                else
                    everest += numPeopleInAGroup;

            }

            int sumPeople = mussala + montblan + kilimandjaro + k2 + everest;

            Console.WriteLine($"{(double)mussala / sumPeople * 100:f2}%");
            Console.WriteLine($"{(double)montblan / sumPeople * 100:f2}%");
            Console.WriteLine($"{(double)kilimandjaro / sumPeople * 100:f2}%");
            Console.WriteLine($"{(double)k2 / sumPeople * 100:f2}%");
            Console.WriteLine($"{(double)everest / sumPeople * 100:f2}%");


        }
    }
}
