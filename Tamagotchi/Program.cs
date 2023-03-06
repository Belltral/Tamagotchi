
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria a requisição GET do link da API
            var client = new RestClient("https://pokeapi.co/api/v2/pokemon/");
            var request = new RestRequest("", Method.Get);
            var response = client.Execute(request);

            // Converte o resultado da API para o formato JSON legível
            JToken token = JToken.Parse(response.Content);
            string formattedJson = token.ToString(Formatting.Indented);
            Console.WriteLine(formattedJson);
        }
    }
}