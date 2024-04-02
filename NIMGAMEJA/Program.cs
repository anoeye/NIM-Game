using System;
using System.ComponentModel.Design;
using System.Net.Http.Headers;

namespace NIM
{
    class NIM
    {
        static void Main(string[] args)
        {

            //Loading Animation
            //Loading Animation
            //Loading Animation

            Console.WriteLine("Loading .");
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine("Loading .  .");
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine("Loading .  .  .");
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine("Loading .  .  .  .");
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine("Loading .");
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine("Loading .  .");
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine("Loading .  .  .");
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine("Loading .  .  .  .");
            Thread.Sleep(500);
            Console.Clear();

            //Welcome Screen
            //Welcome Screen
            //Welcome Screen

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" _____ _              _                       _                   __ _____           ___                     \r\n/__   \\ |__   ___    /_\\  _ __ ___   __ _ ___(_)_ __   __ _    /\\ \\ \\\\_   \\/\\/\\     / _ \\__ _ _ __ ___   ___ \r\n  / /\\/ '_ \\ / _ \\  //_\\\\| '_ ` _ \\ / _` |_  / | '_ \\ / _` |  /  \\/ / / /\\/    \\   / /_\\/ _` | '_ ` _ \\ / _ \\\r\n / /  | | | |  __/ /  _  \\ | | | | | (_| |/ /| | | | | (_| | / /\\  /\\/ /_/ /\\/\\ \\ / /_\\\\ (_| | | | | | |  __/\r\n \\/   |_| |_|\\___| \\_/ \\_/_| |_| |_|\\__,_/___|_|_| |_|\\__, | \\_\\ \\/\\____/\\/    \\/ \\____/\\__,_|_| |_| |_|\\___|\r\n                                                      |___/                                                  ");
            Console.ResetColor();
            Console.WriteLine("1. Singleplayer (Play with CPU)\n \n2. Multiplayer (Play with your Friend Localy)\n \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Press the Number for the Gamemode you want to play!");
            Console.ResetColor();
            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    Singleplayer();
                    break;
                case '2':
                    Multiplayer();
                    break;
            } 


        }


        public static void Singleplayer()
        {
            //CPU EASY GAMEMODE

            string stick1 = "1";  //Wählt 1 Sticks aus
            string stick2 = "2";  //Wählt 2 Sticks aus
            string stick3 = "3";  //Wählt 3 Sticks aus

            string[] easy = { stick1, stick2, stick3 };
            string[] shuffled = easy.OrderBy(n => Guid.NewGuid()).ToArray();
            Random plays = new Random();
            int index = plays.Next(easy.Length);
            int index2 = plays.Next(easy.Length);

            Console.Clear();

            //Game/Player Configuration

            Console.WriteLine("Player Configuration");
            Console.WriteLine("How is your name Player?");
            string player = Console.ReadLine();
            string cpu = "CPU";
            Console.Clear();
            Console.WriteLine("Hello " + player);
            Thread.Sleep(2000);
            Console.Clear();

            //GAME

            Console.WriteLine("With how many sticks do you want to play?");
            int sticks = int.Parse(Console.ReadLine());
            Console.Clear();

            //Zufällige asuwahl der cpu
            string auswahl1 = "1";
            string auswahl2 = "2";
            string auswahl3 = "3";
            string[] cpuauswahl = { auswahl1, auswahl2, auswahl3 };

            int[] drawn = new int[cpuauswahl.Length];

            while (0 < sticks)
            {

                //Zufällige asuwahl der cpu
                string auswahl11 = "1";
                string auswahl22 = "2";
                string auswahl33 = "3";
                string[] cpuauswahl1 = { auswahl1, auswahl2, auswahl3 };
                string[] shuffledcpu = cpuauswahl1.OrderBy(n => Guid.NewGuid()).ToArray();
                Random playscpu = new Random();

                int randomNumber;
                Random RNG = new Random();
                randomNumber = RNG.Next(1, 3);

                int[] ran = new int[cpuauswahl.Length];

                Console.WriteLine("--<[The Amazing NIM-Game]>--");
                Console.WriteLine("Leaderboard:\n" + player + ": " + drawn[1] + " Sticks\n" + "CPU" + ": " + drawn[0] + " Sticks\n" + sticks + " sticks laying on the table\n \n \n");
                Console.WriteLine("CPU" + " is on the Turn");

                //Zug 1 Wieviele stöcke weggenommen werden wird hier eingegeben

                Console.WriteLine("Zug 1 | How many Sticks do you want? (1, 2, 3)\n \n");
                Console.WriteLine("Meine auswahl: " + $"{randomNumber}");
                int zug1 = int.Parse($"{randomNumber}");

                sticks -= zug1;

                drawn[0] += zug1;


                Console.WriteLine("CPU" + " took " + zug1 + " sticks");
                Thread.Sleep(3000);
                Console.Clear();

                //prüfung ob alle sticks aufgebraucht sind

                if (0 >= sticks)
                {
                    break;
                }

                //Zug 2

                // Überschrift und LeaderBoard für Zug2

                Console.WriteLine("--<[The Amazing NIM-Game]>--");
                Console.WriteLine("Leaderboard:\n" + player + ": " + drawn[1] + " Sticks\n" + cpu + ": " + drawn[0] + " Sticks\n" + sticks + " sticks laying on the table\n \n \n");
                Console.WriteLine(player + " is on the Turn");

                Console.WriteLine($"Zug 2 | How many Sticks do you want? (1, 2, 3) {Environment.NewLine} {Environment.NewLine}");
                int zug2 = int.Parse(Console.ReadLine());

                sticks -= zug2;

                drawn[1] += zug2;
                Console.WriteLine(player + " took " + zug2 + " sticks");
                Thread.Sleep(3000);
                Console.Clear();

            }

            Console.WriteLine($"Start again = 1 {Environment.NewLine}Everything other = Exit");
            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    Singleplayer();
                    break;
            }

        }

        public static void cpunormal()
        {
            //CPU NORMAL GAMEMODE
        }

        public static void cpuhard()
        {
            //CPU HARD GAMEMODE
        }

        public static void Multiplayer()
        {

            //Player Configuration

            Console.Clear();
            Console.WriteLine("Player Configuration");
            Console.WriteLine("How is your name Player1?");
            string player1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hello " + player1);
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Player Configuration");
            Console.WriteLine("How is you name Player2?");
            string player2 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Hello " + player2);
            Thread.Sleep(2000);
            Console.Clear();

            //Game Configuration

            Console.WriteLine("With how many sticks do you want to play?");
            int sticks = int.Parse(Console.ReadLine());
            Console.Clear();

            //Game

            //Start spieler wird zufällig ausgesucht
            string[] players = { player1, player2 };
            string[] shuffled = players.OrderBy(n => Guid.NewGuid()).ToArray();
            Random plays = new Random();

            int[] drawn = new int[players.Length];

            //Zug 1

            while (0 < sticks)
            {

                Console.WriteLine("--<[The Amazing NIM-Game]>--");
                Console.WriteLine("Leaderboard:\n" + player1 + ": " + drawn[0] + " Sticks\n" + player2 + ": " + drawn[1] + " Sticks\n" + sticks + " sticks laying on the table\n \n \n");
                Console.WriteLine($"{players[0]}" + " is on the Turn");

                //Zug 1 Wieviele stöcke weggenommen werden wird hier eingegeben

                Console.WriteLine("Zug 1 | How many Sticks do you want? (1, 2, 3)\n \n");
                int zug1 = int.Parse(Console.ReadLine());

                sticks -= zug1;

                drawn[0] += zug1;


                Console.WriteLine($"{players[0]}" + " took " + zug1 + " sticks");
                Thread.Sleep(3000);
                Console.Clear();

                //prüfung ob alle sticks aufgebraucht sind

                if (0 >= sticks)
                {
                    break;
                }

                //Zug 2

                // Überschrift und LeaderBoard für Zug2

                Console.WriteLine("--<[The Amazing NIM-Game]>--");
                Console.WriteLine("Leaderboard:\n" + player1 + ": " + drawn[0] + " Sticks\n" + player2 + ": " + drawn[1] + " Sticks\n" + sticks + " sticks laying on the table\n \n \n");
                Console.WriteLine($"{players[1]}" + " is on the Turn");

                Console.WriteLine($"Zug 2 | How many Sticks do you want? (1, 2, 3) {Environment.NewLine} {Environment.NewLine}");
                int zug2 = int.Parse(Console.ReadLine());

                sticks -= zug2;

                drawn[1] += zug2;
                Console.WriteLine($"{players[1]}" + " took " + zug2 + " sticks");
                Thread.Sleep(3000);
                Console.Clear();

            }
            bool win = sticks == null;
            if (win == true)
            {
                Console.WriteLine(players[0] + " won!");
            } else if (win == false)
            {
                Console.WriteLine(players[1] + " won!");
            }

            Console.WriteLine($"Start again = 1 {Environment.NewLine}Everything other = Exit");
            switch (Console.ReadKey().KeyChar) {
                case '1':
                    Multiplayer();
                    break;
            }

        }

        
    }

}