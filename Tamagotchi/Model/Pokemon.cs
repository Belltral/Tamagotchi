using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.ComponentModel.DataAnnotations;

namespace Tamagotchi.Model
{
    public class Pokemon
    {
        [Display]
        public string Name { get; set; }
        public float Heigth { get; set; }
        public float Weight { get; set; }
        public List<PokemonAbilities> Abilities { get; set; }

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

        public override string ToString()
        {
            return $"Nome do Pokemon: {Name}\nAltura: {Heigth}\nPeso: {Weight}\nHabilidades:";
        }
    }
}
