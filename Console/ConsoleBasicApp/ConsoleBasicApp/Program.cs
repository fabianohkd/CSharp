using System;

namespace ConsoleBasicApp
{
    class Program
    {

        static void Main(string[] args)
        {
            var opcao = Inicio(); //chama o metodo de perguntas e seta na variavel a opção selecionada

            Console.Clear(); //limpa o console

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Opção 1 selecionada");
                    break;

                case "2":
                    Console.WriteLine("Opção 2 selecionada");
                    break;

                case "3":
                    Console.WriteLine("Opção 3 selecionada");
                    break;

                default:
                    Console.WriteLine("Opção invalida!");
                    Console.ReadKey();
                    break;
            }

            Inicio();
        
        }


        static string Inicio()
        {
            Console.WriteLine(
@"Digite uma das opções para continuar:

    1. Cadastro basico
    2. Calculando sua idade
    3. Contar uma piada
");
            return Console.ReadLine();
        }



    }
}
