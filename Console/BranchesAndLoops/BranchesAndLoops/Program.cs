using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://docs.microsoft.com/pt-br/dotnet/csharp/tutorials/intro-to-csharp/branches-and-loops?tutorial-step=6

            // Agora que você viu a instrução if e as construções de loop na linguagem C#, verifique se você pode escrever o código C# para encontrar a soma de todos os inteiros de 1 a 20 divisíveis por 3. Veja algumas dicas:

            // O operador % retorna o restante de uma operação de divisão.
            // A instrução if retorna a condição para ver se um número deve ser parte da soma.
            // O loop for pode ajudar você a repetir uma série de etapas para todos os números de 1 a 20.

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
