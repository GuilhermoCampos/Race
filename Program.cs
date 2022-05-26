using System;
using System.Threading;
using System.Threading.Tasks;

namespace corridaSO{
    internal class Program{
        public static class Position{
            static int track = 0;
            static int maxspeed = 0;
            static int minspeed = 0;
            static int winner = 0;
            static int second = 0;
            static int third = 0;
            static int car1 = 0;
            static int car2 = 0;
            static int car3 = 0;
            static int car4 = 0;
            static int car5 = 0;
            static int car6 = 0;

            public static int Maxspeed{ get; set;}
            public static int Minspeed{ get; set;}
            public static int Track{ get; set;}
            public static int Winner{ get; set;}
            public static int Second{ get; set;}
            public static int Third{ get; set;}
            public static int Car1{ get; set;}
            public static int Car2{ get; set;}
            public static int Car3{ get; set;}
            public static int Car4{ get; set;}
            public static int Car5{ get; set;}
            public static int Car6{ get; set;}
        }

        static void car1(){
            Thread.Sleep(3000);
            Random num = new Random();
            int interval = num.Next(Position.Maxspeed,Position.Minspeed);
            while(Position.Car1 < Position.Track){
                interval = num.Next(Position.Maxspeed,Position.Minspeed);
                Position.Car1 += 1;
                Thread.Sleep(interval);
            }
            if(Position.Winner == 0){
                Position.Winner = 44;
            }
            else if(Position.Second == 0){
                Position.Second = 44;
            }
            else if(Position.Third == 0){
                Position.Third = 44;
            }
        }

        static void car2(){
            Thread.Sleep(3000);
            Random num = new Random();
            int interval = num.Next(Position.Maxspeed,Position.Minspeed);
            while(Position.Car2 < Position.Track){
                interval = num.Next(Position.Maxspeed,Position.Minspeed);
                Position.Car2 += 1;
                Thread.Sleep(interval);
            }
            if(Position.Winner == 0){
                Position.Winner = 16;
            }
            else if(Position.Second == 0){
                Position.Second = 16;
            }
            else if(Position.Third == 0){
                Position.Third = 16;
            }
        }
        static void car3(){
            Thread.Sleep(3000);
            Random num = new Random();
            int interval = num.Next(Position.Maxspeed,Position.Minspeed);
            while(Position.Car3 < Position.Track){
                interval = num.Next(Position.Maxspeed,Position.Minspeed);
                Position.Car3 += 1;
                Thread.Sleep(interval);
            }
            if(Position.Winner == 0){
                Position.Winner = 1;
            }
            else if(Position.Second == 0){
                Position.Second = 1;
            }
            else if(Position.Third == 0){
                Position.Third = 1;
            }
        }
        static void car4(){
            Thread.Sleep(3000);
            Random num = new Random();
            int interval = num.Next(Position.Maxspeed,Position.Minspeed);
            while(Position.Car4 < Position.Track){
                interval = num.Next(Position.Maxspeed,Position.Minspeed);
                Position.Car4 += 1;
                Thread.Sleep(interval);
            }
            if(Position.Winner == 0){
                Position.Winner = 63;
            }
            else if(Position.Second == 0){
                Position.Second = 63;
            }
            else if(Position.Third == 0){
                Position.Third = 63;
            }
        }
        static void car5(){
            Thread.Sleep(3000);
            Random num = new Random();
            int interval = num.Next(Position.Maxspeed,Position.Minspeed);
            while(Position.Car5 < Position.Track){
                interval = num.Next(Position.Maxspeed,Position.Minspeed);
                Position.Car5 += 1;
                Thread.Sleep(interval);
            }
            if(Position.Winner == 0){
                Position.Winner = 11;
            }
            else if(Position.Second == 0){
                Position.Second = 11;
            }
            else if(Position.Third == 0){
                Position.Second = 11;
            }
        }
        
        static void Main(string[] args){
            Console.Clear();
            Console.WriteLine(@"
 _____ ______   ________  ___  __    _______            ___    ___ ________  ___  ___  ________          ________  _______  _________   
|\   _ \  _   \|\   __  \|\  \|\  \ |\  ___ \          |\  \  /  /|\   __  \|\  \|\  \|\   __  \        |\   __  \|\  ___ \|\___   ___\ 
\ \  \\\__\ \  \ \  \|\  \ \  \/  /|\ \   __/|         \ \  \/  / | \  \|\  \ \  \\\  \ \  \|\  \       \ \  \|\ /\ \   __/\|___ \  \_| 
 \ \  \\|__| \  \ \   __  \ \   ___  \ \  \_|/__        \ \    / / \ \  \\\  \ \  \\\  \ \   _  _\       \ \   __  \ \  \_|/__  \ \  \  
  \ \  \    \ \  \ \  \ \  \ \  \\ \  \ \  \_|\ \        \/  /  /   \ \  \\\  \ \  \\\  \ \  \\  \|       \ \  \|\  \ \  \_|\ \  \ \  \ 
   \ \__\    \ \__\ \__\ \__\ \__\\ \__\ \_______\     __/  / /      \ \_______\ \_______\ \__\\ _\        \ \_______\ \_______\  \ \__\
    \|__|     \|__|\|__|\|__|\|__| \|__|\|_______|    |\___/ /        \|_______|\|_______|\|__|\|__|        \|_______|\|_______|   \|__|
                                                      \|___|/                                                                           
 
  ________  ___  ___  ________  ________  ________  _______            ___    ___ ________  ___  ___  ________          ________  ________  ________     
|\   ____\|\  \|\  \|\   __  \|\   __  \|\   ____\|\  ___ \          |\  \  /  /|\   __  \|\  \|\  \|\   __  \        |\   ____\|\   __  \|\   __  \    
\ \  \___|\ \  \\\  \ \  \|\  \ \  \|\  \ \  \___|\ \   __/|         \ \  \/  / | \  \|\  \ \  \\\  \ \  \|\  \       \ \  \___|\ \  \|\  \ \  \|\  \   
 \ \  \    \ \   __  \ \  \\\  \ \  \\\  \ \_____  \ \  \_|/__        \ \    / / \ \  \\\  \ \  \\\  \ \   _  _\       \ \  \    \ \   __  \ \   _  _\  
  \ \  \____\ \  \ \  \ \  \\\  \ \  \\\  \|____|\  \ \  \_|\ \        \/  /  /   \ \  \\\  \ \  \\\  \ \  \\  \|       \ \  \____\ \  \ \  \ \  \\  \| 
   \ \_______\ \__\ \__\ \_______\ \_______\____\_\  \ \_______\     __/  / /      \ \_______\ \_______\ \__\\ _\        \ \_______\ \__\ \__\ \__\\ _\ 
    \|_______|\|__|\|__|\|_______|\|_______|\_________\|_______|    |\___/ /        \|_______|\|_______|\|__|\|__|        \|_______|\|__|\|__|\|__|\|__|
                                           \|_________|             \|___|/                                                                             
   




   _    _                _    _                _    _                _    _                _    _           
  \`../ |o_..__         \`../ |o_..__         \`../ |o_..__         \`../ |o_..__        \`../ |o_..__        
`.,(_)______(_).>     `.,(_)______(_).>     `.,(_)______(_).>     `.,(_)______(_).>     `.,(_)______(_).>     
  _____  _____          ____   ______         ______ ____           ______ ______        ____   ____   
 |  |  ||  |  |        |_   | |    __|       |      |_   |         |    __|__    |      |_   | |_   |  
 |__    |__    |        _|  |_|  __  |       |  --  |_|  |_        |  __  |__    |       _|  |_ _|  |_ 
    |__|   |__|        |______|______|       |______|______|       |______|______|      |______|______|  
            ");
            int bet = 0;
            Console.Write("Witch you will choose?:");
            bet = int.Parse(Console.ReadLine());

            Position.Track = 150;
            Position.Maxspeed = 50;
            Position.Minspeed = 150;
            int tam = -1*(Position.Track + 15);
            Thread Car1 = new Thread(new ThreadStart(car1));
            Thread Car2 = new Thread(new ThreadStart(car2));
            Thread Car3 = new Thread(new ThreadStart(car3));
            Thread Car4 = new Thread(new ThreadStart(car4));
            Thread Car5 = new Thread(new ThreadStart(car5));
            string space1 = "";
            string space12 = "";
            string space13 = "";
            string space14 = "";
            string space2 = "";
            string space22 = "";
            string space23 = "";
            string space24 = "";
            string space3 = "";
            string space32 = "";
            string space33 = "";
            string space34 = "";
            string space4 = "";
            string space42 = "";
            string space43 = "";
            string space44 = "";
            string space5 = "";
            string space52 = "";
            string space53 = "";
            string space54 = "";
            string space6 = "";

            string city1 = "                                                 ..======.                                                               ..======.                                                               ..======.                                                               ..======.               ";
            string city2 = "                                                 ||::: : |                                                               ||::: : |                                                               ||::: : |                                                               ||::: : |               ";
            string city3 = "    .====.                                  .~.===: : : :|   ..===.         .====.                                  .~.===: : : :|   ..===.         .====.                                  .~.===: : : :|   ..===.         .====.                                  .~.===: : : :|   ..===.      ";
            string city4 = "    |.::'||      .=====.,     .=======.~,   | |: :|::::::|   ||:::|=====|   |.::'||      .=====.,     .=======.~,   | |: :|::::::|   ||:::|=====|   |.::'||      .=====.,     .=======.~,   | |: :|::::::|   ||:::|=====|   |.::'||      .=====.,     .=======.~,   | |: :|::::::|   ||:::|=====|";
            string city5 = " ___| :::|!__.,  |:::::|!_,   |: :: ::| |l_l| |:: |:;;:::|___!| ::|: : :|___| :::|!__.,  |:::::|!_,   |: :: ::| |l_l| |:: |:;;:::|___!| ::|: : :|___| :::|!__.,  |:::::|!_,   |: :: ::| |l_l| |:: |:;;:::|___!| ::|: : :|___| :::|!__.,  |:::::|!_,   |: :: ::| |l_l| |:: |:;;:::|___!| ::|: : :|";
            string city6 = "|: :|::: |:: |!__|; :: |: |===::: :: :| ||_|| | : |: :: :|: : |:: |:::::|: :|::: |:: |!__|; :: |: |===::: :: :| ||_|| | : |: :: :|: : |:: |:::::|: :|::: |:: |!__|; :: |: |===::: :: :| ||_|| | : |: :: :|: : |:: |:::::|: :|::: |:: |!__|; :: |: |===::: :: :| ||_|| | : |: :: :|: : |:: |:::::|";
            string city7 = "|:::| _::|: :|:::|:===:|::|:::|:===F=:| !/| ! |::F|:====:|::_:|: :|::__:|:::| _::|: :|:::|:===:|::|:::|:===F=:| !/| ! |::F|:====:|::_:|: :|::__:|:::| _::|: :|:::|:===:|::|:::|:===F=:| !/| ! |::F|:====:|::_:|: :|::__:|:::| _::|: :|:::|:===:|::|:::|:===F=:| !/| ! |::F|:====:|::_:|: :|::__:|";
            string city8 = "!_[]![_]_!_[]![]_!_[__]![]![_]![_][I_]!//_:_  ![]I![_][_]!_[_]![]_!_[__]!_[]![_]_!_[]![]_!_[__]![]![_]![_][I_]!//_:_  ![]I![_][_]!_[_]![]_!_[__]!_[]![_]_!_[]![]_!_[__]![]![_]![_][I_]!//_:_  ![]I![_][_]!_[_]![]_!_[__]!_[]![_]_!_[]![]_!_[__]![]![_]![_][I_]!//_:_  ![]I![_][_]!_[_]![]_!_[__]!";
            string city9 = "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            string city10 = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
            string city11 = "_________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________";

            string winner1 = @" _____  _____  
|  |  ||  |  | 
|__    |__    |
   |__|   |__| ";
        string winner2 = @" ____   ______ 
|_   | |    __|
 _|  |_|  __  |
|______|______|";
        string winner3 = @" ______ ____   
|      |_   |  
|  --  |_|  |_ 
|______|______|";
        string winner4 = @" ______ ______ 
|    __|__    |
|  __  |__    |
|______|______|";
        string winner5 = @" ____   ____   
|_   | |_   |  
 _|  |_ _|  |_ 
|______|______|";
            
            
            Car1.Start();
            Car2.Start();
            Car3.Start();
            Car4.Start();
            Car5.Start();


            while(Car1.IsAlive || Car2.IsAlive || Car3.IsAlive || Car4.IsAlive || Car5.IsAlive){
                Console.Clear();
                space1 = String.Concat(Enumerable.Repeat(" ", Position.Car1));
                space2 = String.Concat(Enumerable.Repeat(" ", Position.Car2));
                space3 = String.Concat(Enumerable.Repeat(" ", Position.Car3));
                space4 = String.Concat(Enumerable.Repeat(" ", Position.Car4));
                space5 = String.Concat(Enumerable.Repeat(" ", Position.Car5));
                space6 = String.Concat(Enumerable.Repeat(" ", Position.Car6));

                Console.WriteLine(city1.Substring(0, (Position.Track + 35)));
                Console.WriteLine(city2.Substring(0, (Position.Track + 35)));
                Console.WriteLine(city3.Substring(0, (Position.Track + 35)));
                Console.WriteLine(city4.Substring(0, (Position.Track + 35)));
                Console.WriteLine(city5.Substring(0, (Position.Track + 35)));
                Console.WriteLine(city6.Substring(0, (Position.Track + 35)));
                Console.WriteLine(city7.Substring(0, (Position.Track + 35)));
                Console.WriteLine(city8.Substring(0, (Position.Track + 35)));
                Console.WriteLine($"{city9.Substring(0, (Position.Track + 35))}");


                space12 = String.Concat(space1, "  \\`./44|o_..__  ");
                space13 = String.Concat(space1, "`.,(_)______(_).>");
                space14 = String.Concat(space1, "                 ");
                space1 = String.Concat(space1, "    _    _       ");
                
                space22 = String.Concat(space2, "  \\`./16|o_..__  ");
                space23 = String.Concat(space2, "`.,(_)______(_).>");
                space24 = String.Concat(space2, "                 ");
                space2 = String.Concat(space2, "    _    _       ");
                
                space32 = String.Concat(space3, "  \\`./01|o_..__  ");
                space33 = String.Concat(space3, "`.,(_)______(_).>");
                space34 = String.Concat(space3, "                 ");
                space3 = String.Concat(space3, "    _    _       ");
                

                space42 = String.Concat(space4, "  \\`./63|o_..__  ");
                space43 = String.Concat(space4, "`.,(_)______(_).>");
                space44 = String.Concat(space4, "                 ");
                space4 = String.Concat(space4, "    _    _       ");

                space52 = String.Concat(space5, "  \\`./11|o_..__  ");
                space53 = String.Concat(space5, "`.,(_)______(_).>");
                space54 = String.Concat(space5, "                 ");
                space5 = String.Concat(space5, "    _    _       ");

                

                Console.WriteLine($"{space1,-167}░░░ _____  _____  ");
                Console.WriteLine($"{space12,-167}░░░|  |  ||  |  | ");
                Console.WriteLine($"{space13,-167}░░░|__    |__    |");
                Console.WriteLine($"{space14,-167}░░░   |__|   |__| ");

                Console.WriteLine($"{city10.Substring(0, (Position.Track + 17))}░░░");

                Console.WriteLine($"{space2,-167}░░░ ____   ______ ");
                Console.WriteLine($"{space22,-167}░░░|_   | |    __|");
                Console.WriteLine($"{space23,-167}░░░ _|  |_|  __  |");
                Console.WriteLine($"{space24,-167}░░░|______|______|");

                Console.WriteLine($"{city10.Substring(0, (Position.Track + 17))}░░░");

                Console.WriteLine($"{space3,-167}░░░ ______ ____   ");
                Console.WriteLine($"{space32,-167}░░░|      |_   |  ");
                Console.WriteLine($"{space33,-167}░░░|  --  |_|  |_ ");
                Console.WriteLine($"{space34,-167}░░░|______|______|");

                Console.WriteLine($"{city10.Substring(0, (Position.Track + 17))}░░░");

                Console.WriteLine($"{space4,-167}░░░ ______ ______ ");
                Console.WriteLine($"{space42,-167}░░░|    __|__    |");
                Console.WriteLine($"{space43,-167}░░░|  __  |__    |");
                Console.WriteLine($"{space44,-167}░░░|______|______|");

                Console.WriteLine($"{city10.Substring(0, (Position.Track + 17))}░░░");

                Console.WriteLine($"{space5,-167}░░░ ____   ____   ");
                Console.WriteLine($"{space52,-167}░░░|_   | |_   |  ");
                Console.WriteLine($"{space53,-167}░░░ _|  |_ _|  |_ ");
                Console.WriteLine($"{space54,-167}░░░|______|______|");

                Console.WriteLine(city9.Substring(0, (Position.Track + 18)));
                Console.WriteLine(city11.Substring(0, (Position.Track + 18)));

                Thread.Sleep(60);
            }
            Console.Clear();
            Console.WriteLine(@" _________  ___  ___  _______           ___       __   ___  ________   ________   _______   ________          ___  ________      
|\___   ___\\  \|\  \|\  ___ \         |\  \     |\  \|\  \|\   ___  \|\   ___  \|\  ___ \ |\   __  \        |\  \|\   ____\     
\|___ \  \_\ \  \\\  \ \   __/|        \ \  \    \ \  \ \  \ \  \\ \  \ \  \\ \  \ \   __/|\ \  \|\  \       \ \  \ \  \___|_    
     \ \  \ \ \   __  \ \  \_|/__       \ \  \  __\ \  \ \  \ \  \\ \  \ \  \\ \  \ \  \_|/_\ \   _  _\       \ \  \ \_____  \   
      \ \  \ \ \  \ \  \ \  \_|\ \       \ \  \|\__\_\  \ \  \ \  \\ \  \ \  \\ \  \ \  \_|\ \ \  \\  \|       \ \  \|____|\  \  
       \ \__\ \ \__\ \__\ \_______\       \ \____________\ \__\ \__\\ \__\ \__\\ \__\ \_______\ \__\\ _\        \ \__\____\_\  \ 
        \|__|  \|__|\|__|\|_______|        \|____________|\|__|\|__| \|__|\|__| \|__|\|_______|\|__|\|__|        \|__|\_________\
                                                                                                                     \|_________|");
            
            switch(Position.Winner){
                case 44:
                    Console.WriteLine(winner1);
                    break;
                case 16:
                    Console.WriteLine(winner2);
                    break;
                case 1:
                    Console.WriteLine(winner3);
                    break;
                case 63:
                    Console.WriteLine(winner4);
                    break;
                case 11:
                    Console.WriteLine(winner5);
                    break;
            }

            Console.WriteLine(@" _________  ___  ___  _______           ________  _______   ________  ________  ________   ________          ___  ________      
|\___   ___\\  \|\  \|\  ___ \         |\   ____\|\  ___ \ |\   ____\|\   __  \|\   ___  \|\   ___ \        |\  \|\   ____\     
\|___ \  \_\ \  \\\  \ \   __/|        \ \  \___|\ \   __/|\ \  \___|\ \  \|\  \ \  \\ \  \ \  \_|\ \       \ \  \ \  \___|_    
     \ \  \ \ \   __  \ \  \_|/__       \ \_____  \ \  \_|/_\ \  \    \ \  \\\  \ \  \\ \  \ \  \ \\ \       \ \  \ \_____  \   
      \ \  \ \ \  \ \  \ \  \_|\ \       \|____|\  \ \  \_|\ \ \  \____\ \  \\\  \ \  \\ \  \ \  \_\\ \       \ \  \|____|\  \  
       \ \__\ \ \__\ \__\ \_______\        ____\_\  \ \_______\ \_______\ \_______\ \__\\ \__\ \_______\       \ \__\____\_\  \ 
        \|__|  \|__|\|__|\|_______|       |\_________\|_______|\|_______|\|_______|\|__| \|__|\|_______|        \|__|\_________\
                                          \|_________|                                                              \|_________|");

            switch(Position.Second){
                case 44:
                    Console.WriteLine(winner1);
                    break;
                case 16:
                    Console.WriteLine(winner2);
                    break;
                case 1:
                    Console.WriteLine(winner3);
                    break;
                case 63:
                    Console.WriteLine(winner4);
                    break;
                case 11:
                    Console.WriteLine(winner5);
                    break;
            }

            Console.WriteLine(@" _________  ___  ___  _______           ___       ________  _________  _______           ___  ________      
|\___   ___\\  \|\  \|\  ___ \         |\  \     |\   __  \|\___   ___\\  ___ \         |\  \|\   ____\     
\|___ \  \_\ \  \\\  \ \   __/|        \ \  \    \ \  \|\  \|___ \  \_\ \   __/|        \ \  \ \  \___|_    
     \ \  \ \ \   __  \ \  \_|/__       \ \  \    \ \   __  \   \ \  \ \ \  \_|/__       \ \  \ \_____  \   
      \ \  \ \ \  \ \  \ \  \_|\ \       \ \  \____\ \  \ \  \   \ \  \ \ \  \_|\ \       \ \  \|____|\  \  
       \ \__\ \ \__\ \__\ \_______\       \ \_______\ \__\ \__\   \ \__\ \ \_______\       \ \__\____\_\  \ 
        \|__|  \|__|\|__|\|_______|        \|_______|\|__|\|__|    \|__|  \|_______|        \|__|\_________\
                                                                                                \|_________|");

            switch(Position.Third){
                case 44:
                    Console.WriteLine(winner1);
                    break;
                case 16:
                    Console.WriteLine(winner2);
                    break;
                case 1:
                    Console.WriteLine(winner3);
                    break;
                case 63:
                    Console.WriteLine(winner4);
                    break;
                case 11:
                    Console.WriteLine(winner5);
                    break;
            }

            Console.WriteLine(@" ___  ________            ___    ___ ________  ___  ___  ________          ________  _______  _________         ___    ___ ________  ___  ___     
|\  \|\   ___  \         |\  \  /  /|\   __  \|\  \|\  \|\   __  \        |\   __  \|\  ___ \|\___   ___\      |\  \  /  /|\   __  \|\  \|\  \    
\ \  \ \  \\ \  \        \ \  \/  / | \  \|\  \ \  \\\  \ \  \|\  \       \ \  \|\ /\ \   __/\|___ \  \_|      \ \  \/  / | \  \|\  \ \  \\\  \   
 \ \  \ \  \\ \  \        \ \    / / \ \  \\\  \ \  \\\  \ \   _  _\       \ \   __  \ \  \_|/__  \ \  \        \ \    / / \ \  \\\  \ \  \\\  \  
  \ \  \ \  \\ \  \        \/  /  /   \ \  \\\  \ \  \\\  \ \  \\  \|       \ \  \|\  \ \  \_|\ \  \ \  \        \/  /  /   \ \  \\\  \ \  \\\  \ 
   \ \__\ \__\\ \__\     __/  / /      \ \_______\ \_______\ \__\\ _\        \ \_______\ \_______\  \ \__\     __/  / /      \ \_______\ \_______\
    \|__|\|__| \|__|    |\___/ /        \|_______|\|_______|\|__|\|__|        \|_______|\|_______|   \|__|    |\___/ /        \|_______|\|_______|
                        \|___|/                                                                               \|___|/                             ");
            if(bet == Position.Winner){
                Console.WriteLine(@" ___       __   ___  ________           ________   ________  _________  ___  ___  ___  ________   ________     
|\  \     |\  \|\  \|\   ___  \        |\   ___  \|\   __  \|\___   ___\\  \|\  \|\  \|\   ___  \|\   ____\    
\ \  \    \ \  \ \  \ \  \\ \  \       \ \  \\ \  \ \  \|\  \|___ \  \_\ \  \\\  \ \  \ \  \\ \  \ \  \___|    
 \ \  \  __\ \  \ \  \ \  \\ \  \       \ \  \\ \  \ \  \\\  \   \ \  \ \ \   __  \ \  \ \  \\ \  \ \  \  ___  
  \ \  \|\__\_\  \ \  \ \  \\ \  \       \ \  \\ \  \ \  \\\  \   \ \  \ \ \  \ \  \ \  \ \  \\ \  \ \  \|\  \ 
   \ \____________\ \__\ \__\\ \__\       \ \__\\ \__\ \_______\   \ \__\ \ \__\ \__\ \__\ \__\\ \__\ \_______\
    \|____________|\|__|\|__| \|__|        \|__| \|__|\|_______|    \|__|  \|__|\|__|\|__|\|__| \|__|\|_______|");
            }
            else{
                Console.WriteLine(@" ___       ________  ________  _________         ___    ___ ________  ___  ___  ________          ___  ___  ________  ___  ___  ________  _______      
|\  \     |\   __  \|\   ____\|\___   ___\      |\  \  /  /|\   __  \|\  \|\  \|\   __  \        |\  \|\  \|\   __  \|\  \|\  \|\   ____\|\  ___ \     
\ \  \    \ \  \|\  \ \  \___|\|___ \  \_|      \ \  \/  / | \  \|\  \ \  \\\  \ \  \|\  \       \ \  \\\  \ \  \|\  \ \  \\\  \ \  \___|\ \   __/|    
 \ \  \    \ \  \\\  \ \_____  \   \ \  \        \ \    / / \ \  \\\  \ \  \\\  \ \   _  _\       \ \   __  \ \  \\\  \ \  \\\  \ \_____  \ \  \_|/__  
  \ \  \____\ \  \\\  \|____|\  \   \ \  \        \/  /  /   \ \  \\\  \ \  \\\  \ \  \\  \|       \ \  \ \  \ \  \\\  \ \  \\\  \|____|\  \ \  \_|\ \ 
   \ \_______\ \_______\____\_\  \   \ \__\     __/  / /      \ \_______\ \_______\ \__\\ _\        \ \__\ \__\ \_______\ \_______\____\_\  \ \_______\
    \|_______|\|_______|\_________\   \|__|    |\___/ /        \|_______|\|_______|\|__|\|__|        \|__|\|__|\|_______|\|_______|\_________\|_______|
                       \|_________|            \|___|/                                                                            \|_________|         ");
            }
        }
    }

}