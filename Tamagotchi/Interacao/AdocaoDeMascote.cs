
using System.Text;
using Tamagotchi.Pokemon;

namespace Tamagotchi.Interacao
{
    public class AdocaoDeMascote
    {
        public string NomeJogador { get; set; }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("Olá!");
                Console.WriteLine("Qual seu nome?");
                Console.Write("A: ");
                string nomeJogador = Console.ReadLine();
                NomeJogador = nomeJogador;
                Console.WriteLine();
                Console.WriteLine("-------------------- Menu --------------------");
                Console.WriteLine($"Bem vindo(a) {NomeJogador}!");
                Console.WriteLine();
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine("1 - Adotar um mascote virtual");
                Console.WriteLine("NÂO HABILITADO! 2 - Ver seus mascotes");
                Console.WriteLine("3 - Sair");
                Console.Write("A: ");
                int opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (opcao == 1)
                {
                    Adotar();
                }
                if (opcao == 2)
                {
                    Console.WriteLine("Opção ainda não habilitada.");
                }
                if (opcao == 3)
                {
                    Console.WriteLine("Até logo!");
                    Environment.Exit(0);
                }
            }
        }

        public void Adotar()
        {
            int escolhaFazer = 0;
            while (true)
            {
                Console.WriteLine("------------- Adotar um mascote --------------");
                Console.WriteLine("Escolha o mascote: ");
                for (int i = 1; i < 4; i++)
                {
                    string opcoesPokemon = (string)Program.GetParse($"https://pokeapi.co/api/v2/pokemon/{i}")["name"];
                    Console.WriteLine(opcoesPokemon);
                }
                Console.Write("A: ");
                string escolhaPokemon = Console.ReadLine();
                Console.WriteLine();

                
                while (true)
                {
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Você deseja...");
                    Console.WriteLine($"1 - Saber mais sobre o {escolhaPokemon}");
                    Console.WriteLine($"2 - Adotar o {escolhaPokemon}");
                    Console.WriteLine("3 - Voltar para a seleção de mascote");
                    Console.WriteLine("4 - Voltar para o menu principal");
                    Console.WriteLine("5 - Finalizar");
                    Console.Write("A: ");
                    escolhaFazer = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (escolhaFazer == 1)
                    {
                        Console.WriteLine("----------------------------------------------");
                        new Mascote().DadosPokemon(escolhaPokemon);
                        Console.WriteLine();
                    }
                    if (escolhaFazer == 2)
                    {
                        Console.WriteLine($"O mascote foi adotado com sucesso!");
                        Console.WriteLine($"{NomeJogador}, o ovo está chocando!");
                        Console.WriteLine("  ,'\"`.\r\n /     \\\r\n:       :\r\n:       :\r\n `.___,' ");
                        Console.WriteLine();
                        Environment.Exit(0);
                    }
                    if (escolhaFazer == 3)
                    {
                        break;
                    }
                    if (escolhaFazer == 4)
                    {
                        return;
                    }
                    if (escolhaFazer == 5)
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("░▄▀▄▀▀▀▀▄▀▄░░░░░░░░░\r\n░█░░░░░░░░▀▄░░░░░░▄░\r\n█░░▀░░▀░░░░░▀▄▄░░█░█\r\n█░▄░█▀░▄░░░" +
                "░░░░▀▀░░█\r\n█░░▀▀▀▀░░░░░░░░░░░░█\r\n█░░░░░░░░░░░░░░░░░░█\r\n█░░░░░░░░░░░░░░░░░░█\r\n░█░░▄▄░░▄▄▄" +
                "▄░░▄▄░░█░\r\n░█░▄▀█░▄▀░░█░▄▀█░▄▀░\r\n░░▀░░░▀░░░░░▀░░░▀░░░");
            sb.AppendLine("╔══╗╔══╗╔═╦═╗╔══╗╔══╗╔═╗╔══╗╔═╗╔╗╔╗╔══╗\r\n╚╗╔╝║╔╗║║║║║║║╔╗║║╔═╣║║║╚╗" +
                "╔╝║╔╝║╚╝║╚║║╝\r\n─║║─║╠╣║║║║║║║╠╣║║╚╗║║║║─║║─║╚╗║╔╗║╔║║╗\r\n─╚╝─╚╝╚╝╚╩═╩" +
                "╝╚╝╚╝╚══╝╚═╝─╚╝─╚═╝╚╝╚╝╚══╝\r\n───────────────────────────────────────");
            return sb.ToString();
        }

    }
}
