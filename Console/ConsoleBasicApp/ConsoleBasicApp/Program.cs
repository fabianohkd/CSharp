using System;

namespace ConsoleBasicApp
{
    class Program
    {

        static void Main(string[] args)
        {

            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Inicio(); //chama o metodo de perguntas e seta na variavel a opção selecionada
                Console.Clear(); //limpa o console

                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Opção 1 selecionada");
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine("Opção 2 selecionada");
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine("Opção 3 selecionada");
                        break;

                    default:
                        Console.WriteLine("Opção invalida!");
                        break;
                }

            } while (keyInfo.Key != ConsoleKey.Escape);

        }


        static ConsoleKeyInfo Inicio()
        {
            Console.WriteLine(
@"Digite uma das opções para continuar:

    1. Cadastro basico
    2. Calculando sua idade
    3. Contar uma piada
");
            return Console.ReadKey();
        }



    }
}
