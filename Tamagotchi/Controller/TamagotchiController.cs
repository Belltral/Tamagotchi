using Newtonsoft.Json.Linq;
using Tamagotchi.Model;
using Tamagotchi.View;
using Tamagotchi.Service;
using AutoMapper;

namespace Tamagotchi.Controller
{
    public class TamagotchiController
    {
        public string NomeJogador { get; set; }
        public List<string> opcoesPokemon { get; set; }
        public List<Mascote> Adotados { get; set; }
        public TamagotchiView TView { get; set; }

        private readonly IMapper _mapper;
        private int tempoRestante;
        private Timer timer;
        
        public TamagotchiController()
        {
            TView = new TamagotchiView();
            Adotados = new List<Mascote>();
            _mapper = MapperConfigurator.ConfigureMapper();
        }

        public Pokemon DadosPokemon(string nome)
        {
            PokeApiService pokeApi = new PokeApiService();
            Pokemon poke = new Pokemon();
            poke.Name = (string)pokeApi.GetParse($"https://pokeapi.co/api/v2/pokemon/{nome}")["name"];
            poke.Heigth = (float)pokeApi.GetParse($"https://pokeapi.co/api/v2/pokemon/{nome}")["height"];
            poke.Weight = (float)pokeApi.GetParse($"https://pokeapi.co/api/v2/pokemon/{nome}")["weight"];
            PokemonAbilities pokemonAbilities = new PokemonAbilities();
            //pokemonAbilities.Abilities = new List<string>();

            JArray abilities = (JArray)pokeApi.GetParse($"https://pokeapi.co/api/v2/pokemon/{nome}")["abilities"];

            poke.Abilities.Add(pokemonAbilities);

            foreach (JObject ablt in abilities)
            {
                var pokeablt = ablt["ability"]["name"].ToString();
                pokemonAbilities.Abilities.Add(pokeablt);
            }
            return poke;
        }

        public void Jogo()
        {
            while (true)
            {
                TView.MenuPrincipal();
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        EscolhaMascote();
                        break;
                    case 2:
                        Interacao();
                        break;
                    case 3:
                        Console.WriteLine();
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

        public void ListaPokemonsDisponiveis()
        {
            opcoesPokemon = new List<string>();
            for (int i = 1; i < 4; i++)
            {
                opcoesPokemon.Add((string)new PokeApiService().GetParse($"https://pokeapi.co/api/v2/pokemon/{i}")["name"]);
            }
        }

        public void EscolhaMascote()
        {
            ListaPokemonsDisponiveis();
            string pokemonEscolhido = TView.EscolhaMascote(opcoesPokemon);
            while (true)
            {
                int opcao = TView.OpcoesPokemonMensagem(pokemonEscolhido);

                if (opcao == 1)
                {
                    TView.InfosSobrePokemon(DadosPokemon(pokemonEscolhido));
                }
                if (opcao == 2)
                {
                    Adotar(pokemonEscolhido);
                    TView.AdocaoMensagem();
                }
                if (opcao == 3)
                {
                    break;
                }
                if (opcao == 4)
                {
                    Environment.Exit(0);
                }
            }
            
        }

        public void Adotar(string pokemonEscolhido)
        {
            Pokemon pokemon = new Pokemon();
            Mascote mascote = new Mascote();

            pokemon = DadosPokemon(pokemonEscolhido);
            mascote = _mapper.Map<Mascote>(pokemon);
            Adotados.Add(mascote);
        }

        public void Interacao()
        {
            int mascoteInteracao = TView.ListaPokemonsMensagem(Adotados) - 1;
            while (true)
            {
                int interagir = TView.Interagir(Adotados[mascoteInteracao]);
                if (interagir == 1)
                {
                    TView.InfosPokemonsAdotados(Adotados[mascoteInteracao]);
                }
                else if (interagir == 2)
                {
                    Adotados[mascoteInteracao].Alimentar();
                    TView.Alimentado();
                    if (!Adotados[mascoteInteracao].MascoteVivo())
                    {
                        TView.FoiDeBase(Adotados[mascoteInteracao]);
                    }
                }
                else if (interagir == 3)
                {
                    Adotados[mascoteInteracao].Brincar();
                    TView.Brincando();
                    if (!Adotados[mascoteInteracao].MascoteVivo())
                    {
                        TView.FoiDeBase(Adotados[mascoteInteracao]);
                    }
                    else if (Adotados[mascoteInteracao].MascoteDormiu())
                    {
                        TView.DormiuDoNada(Adotados[mascoteInteracao]);
                        TView.Zzz();
                        Thread.Sleep(1000);
                        TView.Zzz();
                        Thread.Sleep(1000);
                        TView.Zzz();
                        Adotados[mascoteInteracao].Sono = 7;
                    }
                }
                else if (interagir == 4)
                {
                    Adotados[mascoteInteracao].Dormir();
                    TView.Dormindo();
                    TView.Zzz();
                    Thread.Sleep(1000);
                    TView.Zzz();
                    Thread.Sleep(1000);
                    TView.Zzz();
                }
                else if (interagir == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }
            }
        }
    }
}
