using Tamagotchi.Model;

namespace Tamagotchi.View
{
    public class TamagotchiView
    {
        public string NomeJogador { get; set; }

        public TamagotchiView()
        {
            BoasVindas();
        }

        public void BoasVindas()
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
            Console.WriteLine();
            Console.WriteLine("-------------------- Menu --------------------");
            Console.WriteLine($"O que deseja fazer, {NomeJogador}?");
            Console.WriteLine("1 - Adotar um mascote virtual");
            Console.WriteLine("2 - Ver seus mascotes");
            Console.WriteLine("3 - Sair");
            Console.Write("A: ");
        }

        public string EscolhaMascote(List<string> opcoesPokemon)
        {
            Console.WriteLine();
            Console.WriteLine("------------- Adotar um mascote --------------");
            Console.WriteLine("Escolha o mascote: ");
            foreach(var poke in opcoesPokemon)
            {
                Console.WriteLine(poke);
            }
            Console.Write("A: ");
            return Console.ReadLine();
        }

        public int InfoPokemonMensagem(string opcaoMascote)
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"{NomeJogador}, você deseja...");
            Console.WriteLine($"1 - Saber mais sobre o {opcaoMascote}");
            Console.WriteLine($"2 - Adotar o {opcaoMascote}");
            Console.WriteLine("3 - Voltar para o menu principal");
            Console.Write("A: ");
            return int.Parse(Console.ReadLine());
        }

        public void InfosSobrePokemon(Pokemon pokeDados)
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(pokeDados);
        }

        public void AdocaoMensagem()
        {
            Console.WriteLine();
            Console.WriteLine($"O mascote foi adotado com sucesso!");
            Console.WriteLine($"{NomeJogador}, o ovo está chocando!");
            Console.WriteLine("  ,'\"`.\r\n /     \\\r\n:       :\r\n:       :\r\n `.___,' ");
            Console.WriteLine();
        }

        public void ListaPokemonsMensagem(List<Mascote> mascotesAdotados)
        {
            Console.WriteLine();
            Console.WriteLine("Você possui os seguintes mascotes: ");
            foreach (var adotados in mascotesAdotados)
            {                
                Console.WriteLine(adotados.Name);
            }
        }

    }
}
