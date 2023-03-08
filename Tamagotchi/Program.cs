
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Security.Cryptography.X509Certificates;
using Tamagotchi.Interacao;
using Tamagotchi.Pokemon;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            AdocaoDeMascote adocao = new AdocaoDeMascote();
            Console.WriteLine(adocao);
            adocao.Menu();
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