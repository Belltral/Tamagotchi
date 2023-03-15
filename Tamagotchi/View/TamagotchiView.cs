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
            /*Console.WriteLine("╔══╗╔══╗╔═╦═╗╔══╗╔══╗╔═╗╔══╗╔═╗╔╗╔╗╔══╗\r\n╚╗╔╝║╔╗║║║║║║║╔╗║║╔═╣║║║╚╗" +
            "╔╝║╔╝║╚╝║╚║║╝\r\n─║║─║╠╣║║║║║║║╠╣║║╚╗║║║║─║║─║╚╗║╔╗║╔║║╗\r\n─╚╝─╚╝╚╝╚╩═╩" +
            "╝╚╝╚╝╚══╝╚═╝─╚╝─╚═╝╚╝╚╝╚══╝\r\n───────────────────────────────────────");*/
            Console.WriteLine("\r\n _________  ________   ___ __ __   ________   _______    ______   _________  ______   ___   ___" +
                "    ________     \r\n/________/\\/_______/\\ /__//_//_/\\ /_______/\\ /______/\\  /_____/\\ /________/\\/_____/\\ /" +
                "__/\\ /__/\\  /_______/\\    \r\n\\__.::.__\\/\\::: _  \\ \\\\::\\| \\| \\ \\\\::: _  \\ \\\\::::__\\/__\\:::_ \\ \\\\_" +
                "_.::.__\\/\\:::__\\/ \\::\\ \\\\  \\ \\ \\__.::._\\/    \r\n   \\::\\ \\   \\::(_)  \\ \\\\:.      \\ \\\\::(_)  \\ \\" +
                "\\:\\ /____/\\\\:\\ \\ \\ \\  \\::\\ \\   \\:\\ \\  __\\::\\/_\\ .\\ \\   \\::\\ \\     \r\n    \\::\\ \\   \\:: __  \\ \\\\:" +
                ".\\-/\\  \\ \\\\:: __  \\ \\\\:\\\\_  _\\/ \\:\\ \\ \\ \\  \\::\\ \\   \\:\\ \\/_/\\\\:: ___::\\ \\  _\\::\\ \\__  \r\n     \\:" +
                ":\\ \\   \\:.\\ \\  \\ \\\\. \\  \\  \\ \\\\:.\\ \\  \\ \\\\:\\_\\ \\ \\  \\:\\_\\ \\ \\  \\::\\ \\   \\:\\_\\ \\ \\\\: \\ \\\\:" +
                ":\\ \\/__\\::\\__/\\ \r\n      \\__\\/    \\__\\/\\__\\/ \\__\\/ \\__\\/ \\__\\/\\__\\/ \\_____\\/   \\_____\\/   \\__\\/    \\__" +
                "___\\/ \\__\\/ \\::\\/\\________\\/ \r\n                                  " +
                "                                                                              \r\n");
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

        public int OpcoesPokemonMensagem(string opcaoMascote)
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

        public void InfosPokemonsAdotados(Mascote mascote)
        {
            Console.WriteLine(mascote);
            if (mascote.Humor >= 5)
            {
                Console.WriteLine("O mascote está feliz! :D");
            }

            else
            {
                Console.WriteLine("O mascote está triste... :(");
            }

            if (mascote.Sono >= 5)
            {
                Console.WriteLine("O mascote está descansado.");
            }
            else
            {
                Console.WriteLine("O mascote está com sono.");
            }

            if (mascote.Fome >= 5)
            {
                Console.WriteLine("O mascote está alimentado.");
            }
            else
            {
                Console.WriteLine("O mascote está com fome!");
            }
        }

        public void AdocaoMensagem()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"O mascote foi adotado com sucesso!");
            Console.WriteLine($"{NomeJogador}, o ovo está chocando!");
            Console.WriteLine("  ,'\"`.\r\n /     \\\r\n:       :\r\n:       :\r\n `.___,' ");
            Console.WriteLine();
        }

        public int ListaPokemonsMensagem(List<Mascote> mascotesAdotados)
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Você possui os seguintes mascotes: ");
            for (int i = 0; i < mascotesAdotados.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {mascotesAdotados[i].Name}");
            }
            Console.WriteLine("Com qual mascote deseja interagir?");
            Console.Write("A: ");
            return int.Parse(Console.ReadLine());
        }

        public int Interagir(Mascote mascote)
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Você deseja...");
            Console.WriteLine($"1 - Saber como o {mascote.Name} está");
            Console.WriteLine($"2 - Alimentar o {mascote.Name}");
            Console.WriteLine($"3 - Brincar com o {mascote.Name}");
            Console.WriteLine($"4 - Colocar o {mascote.Name} para dormir");
            Console.WriteLine($"5 - Voltar");
            Console.Write("A: ");
            return int.Parse(Console.ReadLine());
        }

        public void Alimentado()
        {
            Console.WriteLine();
            Console.WriteLine("O mascote foi alimentado!");
        }

        public void Brincando()
        {
            Console.WriteLine();
            Console.WriteLine("O mascote está feliz porque está bricando!");
        }

        public void Dormindo()
        {
            Console.WriteLine();
            Console.WriteLine("O mascote agora está a mimir.");
            Console.WriteLine("Não faça barulho!");
            Console.WriteLine();
            Console.WriteLine("      |\\      _,,,---,,_\r\nZZZzz /,`.-'`'    -.  ;-;;,_\r\n     |,4-  ) )-" +
                ",_. ,\\ (  `'-'\r\n    '---''(_/--'  `-'\\_) ");
        }

        public void FoiDeBase(Mascote mascote)
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"O mascote morreu de" + (mascote.Fome > 0 ? "fome!" : "tristeza!"));
            Console.WriteLine("\r\n  ______                                            ______                         " +
                "       \r\n /      \\                                          /      \\                        " +
                "       \r\n/$$$$$$  |  ______   _____  ____    ______        /$$$$$$  | __     __  ______    _____" +
                "_  \r\n$$ | _$$/  /      \\ /     \\/    \\  /      \\       $$ |  $$ |/  \\   /  |/      \\  /   " +
                "   \\ \r\n$$ |/    | $$$$$$  |$$$$$$ $$$$  |/$$$$$$  |      $$ |  $$ |$$  \\ /$$//$$$$$$  |/$$$$$$" +
                "  |\r\n$$ |$$$$ | /    $$ |$$ | $$ | $$ |$$    $$ |      $$ |  $$ | $$  /$$/ $$    $$ |$$ |  $$/ \r\n$$ \\__$$" +
                " |/$$$$$$$ |$$ | $$ | $$ |$$$$$$$$/       $$ \\__$$ |  $$ $$/  $$$$$$$$/ $$ |      \r\n$$    $$/ $$    $$ |$$ | $" +
                "$ | $$ |$$       |      $$    $$/    $$$/   $$       |$$ |      \r\n $$$$$$/   $$$$$$$/ $$/  $$/  $$/  $$$$$$$/   " +
                "     $$$$$$/      $/     $$$$$$$/ $$/       \r\n                                                                " +
                "                          \r\n                                                                             " +
                "             \r\n                                                                                          \r\n");
            //Console.WriteLine("\r\n          ,.-·^*ª'` ·,                        ,.,   '          ,·'´¨;.  '                                  _,.,  °                              , ·. ,.-·~·.,   ‘        ,.-.                                 _,.,  °         ,. -  .,              \r\n       .·´ ,·'´:¯'`·,  '\\‘                   ;´   '· .,         ;   ';:\\           .·´¨';\\           ,.·'´  ,. ,  `;\\ '                           /  ·'´,.-·-.,   `,'‚       /   ';\\ '                       ,.·'´  ,. ,  `;\\ '     ,' ,. -  .,  `' ·,       \r\n     ,´  ,'\\:::::::::\\,.·\\'                .´  .-,    ';\\      ;     ';:'\\      .'´     ;:'\\        .´   ;´:::::\\`'´ \\'\\                          /  .'´\\:::::::'\\   '\\ °    ';    ;:'\\      ,·'´';          .´   ;´:::::\\`'´ \\'\\     '; '·~;:::::'`,   ';\\    \r\n    /   /:::\\;·'´¯'`·;\\:::\\°             /   /:\\:';   ;:'\\'    ;   ,  '·:;  .·´,.´';  ,'::;'       /   ,'::\\::::::\\:::\\:'                      ,·'  ,'::::\\:;:-·-:';  ';\\‚     ';   ;::;     ,'  ,''\\        /   ,'::\\::::::\\:::\\:'     ;   ,':\\::;:´  .·´::\\'  \r\n   ;   ;:::;'          '\\;:·´           ,'  ,'::::'\\';  ;::';   ;   ;'`.    ¨,.·´::;'  ;:::;       ;   ;:;:-·'~^ª*';\\'´                       ;.   ';:::;´       ,'  ,':'\\‚    ';   ';::;   ,'  ,':::'\\'     ;   ;:;:-·'~^ª*';\\'´       ;  ·'-·'´,.-·'´:::::::'; \r\n  ';   ;::/      ,·´¯';  °         ,.-·'  '·~^*'´¨,  ';::;   ;  ';::; \\*´\\:::::;  ,':::;‘       ;  ,.-·:*'´¨'`*´\\::\\ '                       ';   ;::;       ,'´ .'´\\::';‚    ';   ;:;  ,'  ,':::::;'     ;  ,.-·:*'´¨'`*´\\::\\ '    ;´    ':,´:::::::::::·´'  \r\n  ';   '·;'   ,.·´,    ;'\\           ':,  ,·:²*´¨¯'`;  ;::';  ';  ,'::;   \\::\\;:·';  ;:::; '      ;   ;\\::::::::::::'\\;'                        ';   ':;:   ,.·´,.·´::::\\;'°     ;   ;:;'´ ,'::::::;'  '   ;   ;\\::::::::::::'\\;'      ';  ,    `·:;:-·'´       \r\n  \\'·.    `'´,.·:´';   ;::\\'         ,'  / \\::::::::';  ;::';  ;  ';::;     '*´  ;',·':::;‘        ;  ;'_\\_:;:: -·^*';\\                         \\·,   `*´,.·'´::::::;·´        ';   '´ ,·':::::;'        ;  ;'_\\_:;:: -·^*';\\      ; ,':\\'`:·.,  ` ·.,      \r\n   '\\::\\¯::::::::';   ;::'; ‘      ,' ,'::::\\·²*'´¨¯':,'\\:;   \\´¨\\::;          \\¨\\::::;         ';    ,  ,. -·:*'´:\\:'\\°                        \\\\:¯::\\:::::::;:·´            ,'   ,.'\\::;·´          ';    ,  ,. -·:*'´:\\:'\\°    \\·-;::\\:::::'`:·-.,';    \r\n     `·:\\:::;:·´';.·´\\::;'         \\`¨\\:::/          \\::\\'    '\\::\\;            \\:\\;·'           \\`*´ ¯\\:::::::::::\\;' '                        `\\:::::\\;::·'´  °             \\`*´\\:::\\;     ‘        \\`*´ ¯\\:::::::::::\\;' '    \\::\\:;'` ·:;:::::\\::\\'  \r\n         ¯      \\::::\\;'‚          '\\::\\;'            '\\;'  '    '´¨               ¨'               \\:::::\\;::-·^*'´                                 ¯                         '\\:::\\;'                  \\:::::\\;::-·^*'´          '·-·'       `' · -':::'' \r\n                  '\\:·´'              `¨'                                                           `*´¯                                           ‘                           `*´‘                     `*´¯                                         \r\n");
        }

        public void DormiuDoNada(Mascote mascote)
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("O mascote se cansou tanto que caiu de sono!");
            Console.WriteLine();
            Console.WriteLine("      |\\      _,,,---,,_\r\nZZZzz /,`.-'`'    -.  ;-;;,_\r\n     |,4-  ) )-" +
                ",_. ,\\ (  `'-'\r\n    '---''(_/--'  `-'\\_) ");
        }

        public void Zzz()
        {
            Console.WriteLine();
            Console.Write("Z");
            Thread.Sleep(600);
            Console.Write("Z");
            Thread.Sleep(600);
            Console.Write("z");
            Thread.Sleep(600);
            Console.Write("z");
        }
    }
}
