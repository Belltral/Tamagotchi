
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Security.Cryptography.X509Certificates;
using Tamagotchi.Pokemon;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ID do Pokemon");
            string pokemonId = "1";

            Mascote mascote = new Mascote();
            mascote.Name = (string)GetParse($"https://pokeapi.co/api/v2/pokemon/{pokemonId}")["name"];
            mascote.Heigth = (float)GetParse($"https://pokeapi.co/api/v2/pokemon/{pokemonId}")["height"];
            mascote.Weight = (float)GetParse($"https://pokeapi.co/api/v2/pokemon/{pokemonId}")["weight"];
            PokemonAbilities pokemonAbilities = new PokemonAbilities();
            pokemonAbilities.Abilities = new List<string>();

            JArray abilities = (JArray)GetParse($"https://pokeapi.co/api/v2/pokemon/{pokemonId}")["abilities"];

            Console.WriteLine(mascote);

            foreach (JObject ablt in abilities)
            {
                var pokeablt = ablt["ability"]["name"].ToString();
                pokemonAbilities.Abilities.Add(pokeablt);
                Console.WriteLine(pokeablt);
            }
            mascote.Abilities = new List<PokemonAbilities>
            {
                pokemonAbilities
            };
        }

        public static JObject GetParse(string link)
        {
            // Cria a requisição GET do link da API
            var client = new RestClient(link);
            var request = new RestRequest("", Method.Get);
            var response = client.Execute(request);

            // Converte o resultado da API para o formato JSON legível
            JToken token = JToken.Parse(response.Content);
            string formattedJson = token.ToString(Formatting.Indented);
            JObject obj = JObject.Parse(formattedJson); // Converte o retorno em um JObjet para ser manipulado
            return obj;
        }
    }
}