using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://docs.microsoft.com/pt-br/dotnet/csharp/tutorials/intro-to-csharp/list-collection?tutorial-step=6

            //FibonacciVeja se você consegue combinar alguns dos conceitos 
            //desta lição e de lições anteriores. Expanda o que você compilou 
            //até o momento com números Fibonacci.Tente escrever o código para
            //gerar os 20 primeiros números na sequência.
            //(Como uma dica, o vigésimo número Fibonacci é 6765.)

            var fibonacciNumbers = new List<int> { 1, 1 };

            while (fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }
            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);

        }
    }
}
