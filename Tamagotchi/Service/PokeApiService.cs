using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Tamagotchi.Service
{
    internal class PokeApiService
    {
        public JObject GetParse(string link)
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
