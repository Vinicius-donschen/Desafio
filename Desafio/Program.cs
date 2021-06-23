using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OFERTA 1");
            Console.WriteLine("Empréstimo 2.000");
            Console.WriteLine("");
            Console.WriteLine("--------------------");

            Console.WriteLine("OFERTA 2");
            Console.WriteLine("Empréstimo 6.000");
            Console.WriteLine("");
            Console.WriteLine("--------------------");

            Console.WriteLine("OFERTA 3");
            Console.WriteLine("Empréstimo 8.000");
            Console.WriteLine("");
            Console.WriteLine("---------------------");

            int escolha = 0;

            while (escolha != 4)
            {
                Console.WriteLine("Escolha uma opção para ver os detalhes");
                escolha = int.Parse(Console.ReadLine());


                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("------------------------------------------------------");
                        Console.WriteLine("Empréstimo de 2.000 reais, com a opção de");
                        Console.WriteLine("parcelamento em até 6x");
                        Console.WriteLine("------------------------------------------------------");
                        Console.WriteLine("deseja ver os empréstimos novamente? Então");
                        Console.WriteLine("digite 1 = 2.000, 2 = 6.000, 3 = 8.000, 4 para sair ou");
                        Console.WriteLine("para contratar esse empréstimo digite 5 para sim");
                        int contratar = int.Parse(Console.ReadLine());
                        if (contratar == 5)
                        {
                            Console.WriteLine("O valor das suas parcelas é de 542,53 reais");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("------------------------------------------------------");
                            Console.WriteLine("digite 1 = 2.000, 2 = 6.000, 3 = 8.000, 4 para sair");
                        }

                        break;
                    case 2:
                        Console.WriteLine("------------------------------------------------------");
                        Console.WriteLine("Empréstimo de 6.000 reais, com a opção de");
                        Console.WriteLine("parcelamento em até 12x");
                        Console.WriteLine("------------------------------------------------------");
                        Console.WriteLine("deseja ver os empréstimos novamente? Então");
                        Console.WriteLine("digite 1 = 2.000, 2 = 6.000, 3 = 8.000 ou 4 para sair ou");
                        Console.WriteLine("para contratar esse empréstimo digite 5 para sim");
                        contratar = int.Parse(Console.ReadLine());
                        if (contratar == 5)
                        {
                            Console.WriteLine("O valor das suas parcelas é de 717,73 reais");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("------------------------------------------------------");
                            Console.WriteLine("digite 1 = 2.000, 2 = 6.000, 3 = 8.000, 4 para sair");
                        }
                        break;
                    case 3:
                        Console.WriteLine("------------------------------------------------------");
                        Console.WriteLine("Empréstimo de 20.000 reais, com a opção de");
                        Console.WriteLine("parcelamento em até 48x");
                        Console.WriteLine("------------------------------------------------------");
                        Console.WriteLine("deseja ver os empréstimos novamente? Então");
                        Console.WriteLine("digite 1 = 2.000, 2 = 6.000, 3 = 8.000 ou 4 para sair ou");
                        Console.WriteLine("para contratar esse empréstimo digite 5 para sim");
                        contratar = int.Parse(Console.ReadLine());
                        if (contratar == 5)
                        {
                            Console.WriteLine("O valor das suas parcelas é de 841,12 reais");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("------------------------------------------------------");
                            Console.WriteLine("digite 1 = 2.000, 2 = 6.000, 3 = 8.000, 4 para sair");
                        }

                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Selecione uma opção válida!");
                        Console.WriteLine("digite 1 = 2.000, 2 = 6.000, 3 = 8.000 ou 4 para fechar o programa");
                        break;
                }
            }
        }
    }
}
