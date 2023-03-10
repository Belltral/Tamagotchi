using Newtonsoft.Json.Linq;
using Tamagotchi.Model;
using Tamagotchi.View;

namespace Tamagotchi.Controller
{
    public class TamagotchiController
    {
        public void DadosPokemon(string nome)
        {
            Pokemon mascote = new Pokemon();
            mascote.Name = (string)new Pokemon().GetParse($"https://pokeapi.co/api/v2/pokemon/{nome}")["name"];
            mascote.Heigth = (float)new Pokemon().GetParse($"https://pokeapi.co/api/v2/pokemon/{nome}")["height"];
            mascote.Weight = (float)new Pokemon().GetParse($"https://pokeapi.co/api/v2/pokemon/{nome}")["weight"];
            PokemonAbilities pokemonAbilities = new PokemonAbilities();
            pokemonAbilities.Abilities = new List<string>();

            JArray abilities = (JArray)new Pokemon().GetParse($"https://pokeapi.co/api/v2/pokemon/{nome}")["abilities"];

            Console.WriteLine(mascote);

            mascote.Abilities = new List<PokemonAbilities>
            {
                pokemonAbilities
            };
            foreach (JObject ablt in abilities)
            {
                var pokeablt = ablt["ability"]["name"].ToString();
                pokemonAbilities.Abilities.Add(pokeablt);
                Console.WriteLine(pokeablt);
            }
        }

        public void Jogo()
        {
            TamagotchiView tView = new TamagotchiView();
            tView.Mensagem();
            while (true)
            {
                tView.MenuPrincipal();
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        tView.Adotar();
                        break;
                    case 2:
                        tView.ListaPokemons();
                        break;
                    case 3:
                        Console.WriteLine("Até logo!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine(" ----------------- ");
                        Console.WriteLine("| Opção inválida! |");
                        Console.WriteLine(" ----------------- ");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
