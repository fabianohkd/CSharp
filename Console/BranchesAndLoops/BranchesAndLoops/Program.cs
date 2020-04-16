using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://docs.microsoft.com/pt-br/dotnet/csharp/tutorials/intro-to-csharp/branches-and-loops?tutorial-step=6

            int sum = 0;
            for (int number = 1; number < 21; number++)
            {
                if (number % 3 == 0)
                {
                    sum = sum + number;
                }
            }
            Console.WriteLine($"The sum is {sum}");
        }
    }
}
