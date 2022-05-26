using System;
using System.Threading;
using System.Threading.Tasks;
using System.Media;

namespace corridaSO{
    internal class Program{
        public static class Position{
            static int rythm= 0;
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
            public static int Winner{ get; set;}
            public static int Second{ get; set;}
            public static int Track{ get; set;}
            public static int Third{ get; set;}
            public static int Rythm{ get; set;}
            public static int Car1{ get; set;}
            public static int Car2{ get; set;}
            public static int Car3{ get; set;}
            public static int Car4{ get; set;}
            public static int Car5{ get; set;}
            public static int Car6{ get; set;}
        }

        static void car1(){
            int distance = 0;
            Thread.Sleep(3000);
            Random num = new Random();
            int interval = num.Next(Position.Maxspeed,Position.Minspeed);
            while(Position.Car1 < Position.Track){
                if(distance == Position.Rythm){
                    interval = num.Next(Position.Maxspeed,Position.Minspeed);
                    distance = 0;
                }
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
            int distance = 0;
            Thread.Sleep(3000);
            Random num = new Random();
            int interval = num.Next(Position.Maxspeed,Position.Minspeed);
            while(Position.Car2 < Position.Track){
                if(distance == Position.Rythm){
                    interval = num.Next(Position.Maxspeed,Position.Minspeed);
                    distance = 0;
                }
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
            int distance = 0;
            Thread.Sleep(3000);
            Random num = new Random();
            int interval = num.Next(Position.Maxspeed,Position.Minspeed);
            while(Position.Car3 < Position.Track){
                if(distance == Position.Rythm){
                    interval = num.Next(Position.Maxspeed,Position.Minspeed);
                    distance = 0;
                }
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
            int distance = 0;
            Thread.Sleep(3000);
            Random num = new Random();
            int interval = num.Next(Position.Maxspeed,Position.Minspeed);
            while(Position.Car4 < Position.Track){
                if(distance == Position.Rythm){
                    interval = num.Next(Position.Maxspeed,Position.Minspeed);
                    distance = 0;
                }
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
            int distance = 0;
            Thread.Sleep(3000);
            Random num = new Random();
            int interval = num.Next(Position.Maxspeed,Position.Minspeed);
            while(Position.Car5 < Position.Track){
                if(distance == Position.Rythm){
                    interval = num.Next(Position.Maxspeed,Position.Minspeed);
                    distance = 0;
                }
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
            // try{
            //     System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"./TopGear1.mp3");
            //     player.Play();
            // }
            // catch(Exception ex){

            // }
            Console.Clear();
            Console.WriteLine(@"╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗
║                                                                                                                     ║
║                                                                                                                     ║
║                                                                                                                     ║
║                              ::::::::::::::    :::::::::::: ::::::::::    :::    :::::::::                          ║
║                                 :+:    :+:    :+::+:    :+::+:         :+: :+:  :+:    :+:                          ║
║                                +:+    +:+    +:++:+    +:++:+        +:+   +:+ +:+    +:+                           ║
║                               +#+    +#++:++#+++#++:++#: +#++:++#  +#++:++#++:+#+    +:+                            ║
║                              +#+    +#+    +#++#+    +#++#+       +#+     +#++#+    +#+                             ║
║                             #+#    #+#    #+##+#    #+##+#       #+#     #+##+#    #+#                              ║
║                            ###    ###    ######    ################     ############                                ║
║                                                                                                                     ║
║                                  :::::::: :::    :::    :::     :::::::: :::::::::::::::::::                        ║
║                                 :+:    :+::+:    :+:  :+: :+:  :+:    :+::+:       :+:    :+:                       ║
║                                +:+       +:+    +:+ +:+   +:+ +:+       +:+       +:+    +:+                        ║
║                               +#+       +#++:++#+++#++:++#++:+#++:++#+++#++:++#  +#++:++#:                          ║
║                              +#+       +#+    +#++#+     +#+       +#++#+       +#+    +#+                          ║
║                             #+#    #+##+#    #+##+#     #+##+#    #+##+#       #+#    #+#                           ║
║                            ######## ###    ######     ### ######## #############    ###                             ║
║                                                                                                                     ║
║                                                                                                                     ║
║                                                                                                                     ║
║                                                                                                                     ║
╠═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╣
║                                                                                                                     ║
║                                                                                                                     ║
║                                                 PRESS ENTER TO START                                                ║
║                                                                                                                     ║
║                                                                                                                     ║
╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ReadKey();
            int bet = 0;
            while(true){
            Console.Clear();
            Console.WriteLine(@"╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗
║                                                                                                                     ║
║                                                                                                                     ║
║                                                                                                                     ║
║             _____ _    _  ____   ____   _____ ______  __     ______  _    _ _____     _____          _____          ║
║            / ____| |  | |/ __ \ / __ \ / ____|  ____| \ \   / / __ \| |  | |  __ \   / ____|   /\   |  __ \         ║
║           | |    | |__| | |  | | |  | | (___ | |__     \ \_/ / |  | | |  | | |__) | | |       /  \  | |__) |        ║
║           | |    |  __  | |  | | |  | |\___ \|  __|     \   /| |  | | |  | |  _  /  | |      / /\ \ |  _  /         ║
║           | |____| |  | | |__| | |__| |____) | |____     | | | |__| | |__| | | \ \  | |____ / ____ \| | \ \         ║
║            \_____|_|  |_|\____/ \____/|_____/|______|    |_|  \____/ \____/|_|  \_\  \_____/_/    \_\_|  \_\        ║
║                                                                                                                     ║
║                                                                                                                     ║
║                                                                                                                     ║
║                                                                                                                     ║
║                                                                                                                     ║
║           _    _                _    _                _    _                _    _                _    _            ║
║       \`../ |o_..__         \`../ |o_..__         \`../ |o_..__         \`../ |o_..__        \`../ |o_..__          ║
║       `.,(_)______(_).>     `.,(_)______(_).>     `.,(_)______(_).>     `.,(_)______(_).>     `.,(_)______(_).>     ║
║          _____  _____          ____   ______         ______ ____           ______ ______        ____   ____         ║
║         |  |  ||  |  |        |_   | |    __|       |      |_   |         |    __|__    |      |_   | |_   |        ║
║         |__    |__    |        _|  |_|  __  |       |  --  |_|  |_        |  __  |__    |       _|  |_ _|  |_       ║
║            |__|   |__|        |______|______|       |______|______|       |______|______|      |______|______|      ║
║                                                                                                                     ║
║                                                                                                                     ║
║                                                                                                                     ║
║                                                                                                                     ║
║                                                                                                                     ║
║                                                                                                                     ║
╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.Write("Witch you will choose?:");
                try{
                    bet = int.Parse(Console.ReadLine());
                }
                catch(Exception ex){
                    
                }
                if(bet == 44){
                    break;
                }
                else if(bet == 16){
                    break;
                }
                else if(bet == 1){
                    break;
                }
                else if(bet == 63){
                    break;
                }
                else if(bet == 11){
                    break;
                }
                Console.WriteLine("Choose a Valid number!, come on try again!");
                Thread.Sleep(5000);
                continue;
            }


            Position.Track = 81;
            Position.Rythm = 0;
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

            string city0 = "╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗";
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

            string winner1 = @"║                                                    _____  _____                                                     ║ 
║                                                   |  |  ||  |  |                                                    ║
║                                                   |__    |__    |                                                   ║
║                                                      |__|   |__|                                                    ║";
            string winner2 = @"║                                                    ____   ______                                                    ║ 
║                                                   |_   | |    __|                                                   ║
║                                                    _|  |_|  __  |                                                   ║
║                                                   |______|______|                                                   ║";
            string winner3 = @"║                                                    ______ ____                                                      ║  
║                                                   |      |_   |                                                     ║
║                                                   |  --  |_|  |_                                                    ║
║                                                   |______|______|                                                   ║";
            string winner4 = @"║                                                    ______ ______                                                    ║
║                                                   |    __|__    |                                                   ║
║                                                   |  __  |__    |                                                   ║
║                                                   |______|______|                                                   ║";
            string winner5 = @"║                                                    ____   ____                                                      ║  
║                                                   |_   | |_   |                                                     ║
║                                                    _|  |_ _|  |_                                                    ║
║                                                   |______|______|                                                   ║";
            
            
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

                Console.WriteLine(city0);
                Console.WriteLine($"║{city1.Substring(0, (Position.Track + 36))}║");
                Console.WriteLine($"║{city2.Substring(0, (Position.Track + 36))}║");
                Console.WriteLine($"║{city3.Substring(0, (Position.Track + 36))}║");
                Console.WriteLine($"║{city4.Substring(0, (Position.Track + 36))}║");
                Console.WriteLine($"║{city5.Substring(0, (Position.Track + 36))}║");
                Console.WriteLine($"║{city6.Substring(0, (Position.Track + 36))}║");
                Console.WriteLine($"║{city7.Substring(0, (Position.Track + 36))}║");
                Console.WriteLine($"║{city8.Substring(0, (Position.Track + 36))}║");
                Console.WriteLine($"║{city9.Substring(0, (Position.Track + 36))}║");


                space12 = String.Concat(space1, "  \\`./44|o_..__  ");
                space13 = String.Concat(space1, "`.,(_)______(_).>");
                space1 = String.Concat(space1, "    _    _       ");
                
                space22 = String.Concat(space2, "  \\`./16|o_..__  ");
                space23 = String.Concat(space2, "`.,(_)______(_).>");
                space2 = String.Concat(space2, "    _    _       ");
                
                space32 = String.Concat(space3, "  \\`./01|o_..__  ");
                space33 = String.Concat(space3, "`.,(_)______(_).>");
                space3 = String.Concat(space3, "    _    _       ");
                

                space42 = String.Concat(space4, "  \\`./63|o_..__  ");
                space43 = String.Concat(space4, "`.,(_)______(_).>");
                space4 = String.Concat(space4, "    _    _       ");

                space52 = String.Concat(space5, "  \\`./11|o_..__  ");
                space53 = String.Concat(space5, "`.,(_)______(_).>");
                space5 = String.Concat(space5, "    _    _       ");

                

                Console.WriteLine($"║{space1,-99}░░░|  |  ||  |  | ║");
                Console.WriteLine($"║{space12,-99}░░░|__    |__    |║");
                Console.WriteLine($"║{space13,-99}░░░   |__|   |__| ║");

                Console.WriteLine($"║{city10.Substring(0, (Position.Track + 18))}░░░ ____   ______ ║");

                Console.WriteLine($"║{space2,-99}░░░|_   | |    __|║");
                Console.WriteLine($"║{space22,-99}░░░ _|  |_|  __  |║");
                Console.WriteLine($"║{space23,-99}░░░|______|______|║");

                Console.WriteLine($"║{city10.Substring(0, (Position.Track + 18))}░░░ ______ ____   ║");

                Console.WriteLine($"║{space3,-99}░░░|      |_   |  ║");
                Console.WriteLine($"║{space32,-99}░░░|  --  |_|  |_ ║");
                Console.WriteLine($"║{space33,-99}░░░|______|______|║");

                Console.WriteLine($"║{city10.Substring(0, (Position.Track + 18))}░░░ ______ ______ ║");

                Console.WriteLine($"║{space4,-99}░░░|    __|__    |║");
                Console.WriteLine($"║{space42,-99}░░░|  __  |__    |║");
                Console.WriteLine($"║{space43,-99}░░░|______|______|║");

                Console.WriteLine($"║{city10.Substring(0, (Position.Track + 18))}░░░ ____   ____   ║");

                Console.WriteLine($"║{space5,-99}░░░|_   | |_   |  ║");
                Console.WriteLine($"║{space52,-99}░░░ _|  |_ _|  |_ ║");
                Console.WriteLine($"║{space53,-99}░░░|______|______|║");

                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");

                Thread.Sleep(60);
            }
            Console.Clear();
            // Console.WriteLine(city0);
            if(bet == Position.Winner){
                Console.WriteLine(@"║                               __     ______  _    _     __          _______ _   _                                   ║
║                               \ \   / / __ \| |  | |    \ \        / /_   _| \ | |                                  ║
║                                \ \_/ / |  | | |  | |     \ \  /\  / /  | | |  \| |                                  ║
║                                 \   /| |  | | |  | |      \ \/  \/ /   | | | . ` |                                  ║
║                                  | | | |__| | |__| |       \  /\  /   _| |_| |\  |                                  ║
║                                  |_|  \____/ \____/         \/  \/   |_____|_| \_|                                  ║");
            }
            else{
                Console.WriteLine(@"║                               __     ______  _    _      _      ____   _____ _______                                ║ 
║                               \ \   / / __ \| |  | |    | |    / __ \ / ____|__   __|                               ║
║                                \ \_/ / |  | | |  | |    | |   | |  | | (___    | |                                  ║
║                                 \   /| |  | | |  | |    | |   | |  | |\___ \   | |                                  ║
║                                  | | | |__| | |__| |    | |___| |__| |____) |  | |                                  ║
║                                  |_|  \____/ \____/     |______\____/|_____/   |_|                                  ║");
            }
            Console.WriteLine(@"║                            _______ _    _ ______   ______ _____ _____   _____ _______                               ║
║                           |__   __| |  | |  ____| |  ____|_   _|  __ \ / ____|__   __|                              ║
║                              | |  | |__| | |__    | |__    | | | |__) | (___    | |                                 ║
║                              | |  |  __  |  __|   |  __|   | | |  _  / \___ \   | |                                 ║
║                              | |  | |  | | |____  | |     _| |_| | \ \ ____) |  | |                                 ║
║                              |_|  |_|  |_|______| |_|    |_____|_|  \_\_____/   |_|                                 ║");
            
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

            Console.WriteLine(@"║                                             ___   _  __ _ _ _      _                                                ║
║                                              ||_||_ (_ |_/ / \|\ || \                                               ║
║                                              || ||_ __)|_\_\_/| \||_/                                               ║");

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

            Console.WriteLine(@"║                                              ___   _ ___  ___ _  _                                                  ║
║                                               ||_||_  ||_| | |_)| \                                                 ║
║                                               || ||_  || |_|_| \|_/                                                 ║");

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
            // Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ReadKey();
        }
    }

}