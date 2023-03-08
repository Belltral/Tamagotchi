using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tamagotchi.Pokemon
{
    public class Mascote
    {
        [Display]
        public string Name { get; set; }
        public float Heigth { get; set; }
        public float Weight { get; set; }
        public List<PokemonAbilities> Abilities { get; set; }

        public  void DadosPokemon(string nome)
        {
            Mascote mascote = new Mascote();
            mascote.Name = (string)Program.GetParse($"https://pokeapi.co/api/v2/pokemon/{nome}")["name"];
            mascote.Heigth = (float)Program.GetParse($"https://pokeapi.co/api/v2/pokemon/{nome}")["height"];
            mascote.Weight = (float)Program.GetParse($"https://pokeapi.co/api/v2/pokemon/{nome}")["weight"];
            PokemonAbilities pokemonAbilities = new PokemonAbilities();
            pokemonAbilities.Abilities = new List<string>();

            JArray abilities = (JArray)Program.GetParse($"https://pokeapi.co/api/v2/pokemon/{nome}")["abilities"];

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

        public override string ToString()
        {
            return $"Nome do Pokemon: {Name}\nAltura: {Heigth}\nPeso: {Weight}\nHabilidades:";
        }
    }
}
