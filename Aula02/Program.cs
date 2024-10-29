using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aula02
{
    public class Program
    {
        static void Main(string[] args)
        {
            ExibirCabeçalho();
            ExibirOpcoesMenu();
        }





        public static void ExibirCabeçalho()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("║Autor: Vitor Barduco                    ║");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"
░██████╗███████╗███╗░░██╗░█████╗░░█████╗░
██╔════╝██╔════╝████╗░██║██╔══██╗██╔══██╗
╚█████╗░█████╗░░██╔██╗██║███████║██║░░╚═╝
░╚═══██╗██╔══╝░░██║╚████║██╔══██║██║░░██╗
██████╔╝███████╗██║░╚███║██║░░██║╚█████╔╝
╚═════╝░╚══════╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("║                                        ║");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.ResetColor();
        }





        public static void ExibirOpcoesMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Digite 1 para registrar informações");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Digite 2 para listar informações");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Digite 3 para deletar informações");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Digite 0 para sair");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nDigite a opção Escolhida: \n");
            Console.ForegroundColor = ConsoleColor.DarkGray;

            int opcaoEscolhidaNumero = int.Parse(Console.ReadLine());
            //int opcaoEscolhidaNumero = int.Parse(opcaoEscolhida);
            /*
            if (opcaoEscolhidaNumero == 1)
            {
                Console.WriteLine("Voce escolheu a opcão 1");
            }
            if (opcaoEscolhidaNumero == 2)
            {
                Console.WriteLine("Voce escolheu a opção 2");
            }
            */

            switch (opcaoEscolhidaNumero)
            {
                case 1:
                    CadInfo();
                    break;

                case 2:
                    Console.WriteLine("\n Voce escolheu a opção 2");
                    Thread.Sleep(2000);
                    Console.Clear();
                    ExibirCabeçalho();
                    ExibirOpcoesMenu();
                    break;

                case 3:
                    Console.WriteLine("\n Voce escolheu a opção 3");
                    Thread.Sleep(2000);
                    Console.Clear();
                    ExibirCabeçalho();
                    ExibirOpcoesMenu();
                    break;

                case 0:
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(@"
░██████╗░█████╗░██╗███╗░░██╗██████╗░░█████╗░
██╔════╝██╔══██╗██║████╗░██║██╔══██╗██╔══██╗░
╚█████╗░███████║██║██╔██╗██║██║░░██║██║░░██║░
░╚═══██╗██╔══██║██║██║╚████║██║░░██║██║░░██║░
██████╔╝██║░░██║██║██║░╚███║██████╔╝╚█████╔╝██╗██╗██╗
╚═════╝░╚═╝░░╚═╝╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░╚═╝╚═╝╚═╝");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;



                default:
                    Console.WriteLine("\n Você digitou a opção invalida");
                    Thread.Sleep(1000);
                    Console.Clear();
                    ExibirCabeçalho();
                    ExibirOpcoesMenu();
                    break;
            }

        }







        private static void CadInfo()
        {
            Console.Clear();
            Console.WriteLine("\n Cadastro de Cliente");
            Console.WriteLine("\n Digite seu Nome: ");
            string NomeDoUsuario = Console.ReadLine();
            Console.WriteLine($"\n Nome Cadastrado com Sucesso! {NomeDoUsuario}");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirCabeçalho();
            ExibirOpcoesMenu();
        }





    }

}