
using Newtonsoft.Json.Linq;
using System.Text;
using Tamagotchi.Controller;
using Tamagotchi.Model;

namespace Tamagotchi.View
{
    public class TamagotchiView
    {
        public string NomeJogador { get; set; }
        public static PokemonsDoJogador PokemonsJogador { get; set; } = new PokemonsDoJogador(); // Classe estática e inicia a instância para armazenar os Pokemons do jogador.

        // Cria um construtor estático para a classe para instanciar a List de Pokemons da classe PokemonsDoJogador.
        static TamagotchiView()
        {
            TamagotchiView.PokemonsJogador.Pokemons = new List<string>();
        }

        public void Mensagem()
        {
            Console.WriteLine("░▄▀▄▀▀▀▀▄▀▄░░░░░░░░░\r\n░█░░░░░░░░▀▄░░░░░░▄░\r\n█░░▀░░▀░░░░░▀▄▄░░█░█\r\n█░▄░█▀░▄░░░" +
            "░░░░▀▀░░█\r\n█░░▀▀▀▀░░░░░░░░░░░░█\r\n█░░░░░░░░░░░░░░░░░░█\r\n█░░░░░░░░░░░░░░░░░░█\r\n░█░░▄▄░░▄▄▄" +
            "▄░░▄▄░░█░\r\n░█░▄▀█░▄▀░░█░▄▀█░▄▀░\r\n░░▀░░░▀░░░░░▀░░░▀░░░");
            Console.WriteLine("╔══╗╔══╗╔═╦═╗╔══╗╔══╗╔═╗╔══╗╔═╗╔╗╔╗╔══╗\r\n╚╗╔╝║╔╗║║║║║║║╔╗║║╔═╣║║║╚╗" +
            "╔╝║╔╝║╚╝║╚║║╝\r\n─║║─║╠╣║║║║║║║╠╣║║╚╗║║║║─║║─║╚╗║╔╗║╔║║╗\r\n─╚╝─╚╝╚╝╚╩═╩" +
            "╝╚╝╚╝╚══╝╚═╝─╚╝─╚═╝╚╝╚╝╚══╝\r\n───────────────────────────────────────");
            Console.WriteLine();
            Console.WriteLine("Olá!");
            Console.WriteLine("Qual seu nome?");
            Console.Write("A: ");
            string nomeJogador = Console.ReadLine();
            NomeJogador = nomeJogador;
            Console.WriteLine();
            Console.WriteLine($"Bem vindo(a) {NomeJogador}!");
            Console.WriteLine();
        }

        public void MenuPrincipal()
        {
            Console.WriteLine("-------------------- Menu --------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Adotar um mascote virtual");
            Console.WriteLine("2 - Ver seus mascotes");
            Console.WriteLine("3 - Sair");
            Console.Write("A: ");
        }

        public void Adotar()
        {
            int escolhaFazer = 0;

            //TamagotchiView.PokemonsJogador = new PokemonsDoJogador(); // Cria uma instância da classe PokemonsDoJogador.
            //TamagotchiView.PokemonsJogador.Pokemons = new List<string>(); // Cria uma instância de List.

            while (true)
            {
                Console.WriteLine("------------- Adotar um mascote --------------");
                Console.WriteLine("Escolha o mascote: ");
                for (int i = 1; i < 4; i++)
                {
                    string opcoesPokemon = (string)new Pokemon().GetParse($"https://pokeapi.co/api/v2/pokemon/{i}")["name"];
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
                        new TamagotchiController().DadosPokemon(escolhaPokemon);
                        Console.WriteLine();
                    }
                    if (escolhaFazer == 2)
                    {
                        PokemonsJogador.AddPoke(escolhaPokemon);

                        Console.WriteLine($"O mascote foi adotado com sucesso!");
                        Console.WriteLine($"{NomeJogador}, o ovo está chocando!");
                        Console.WriteLine("  ,'\"`.\r\n /     \\\r\n:       :\r\n:       :\r\n `.___,' ");
                        Console.WriteLine();
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

        public void ListaPokemons()
        {
            if (PokemonsJogador.Pokemons != null)
            {
                Console.WriteLine();
                Console.WriteLine("Você possui os seguintes Pokemons:");
                foreach (var poke in PokemonsJogador.Pokemons)
                {
                    Console.WriteLine(poke);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Sua lista de Pokemons está vazia atualmente.");
                Console.WriteLine();
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
