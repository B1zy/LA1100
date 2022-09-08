using System;

namespace Number_guessing_game
{
    class Program
    {
       

         public static void  Main(string[] args)
        {

        start:

            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            int Guesses = 0;
            int Guess;
            int winCount = 0;
            Random rnd = new Random();
            int Generated = rnd.Next(1, 100);
            Console.WriteLine(Generated);

            Console.WriteLine("Eine zufällige Zahl zwischen 1-100 wurde Generiert");
            Console.WriteLine("Probieren Sie es zu erraten");
           
            
            do
            {


                Console.ForegroundColor = ConsoleColor.Yellow;
                string strGuess =Console.ReadLine();
                Guess = Convert.ToInt32(strGuess);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(winCount + ":Wincount");
                if (winCount == 5)
                {
                 
                    Console.WriteLine("Wollen Sie ein schwieriegeres Modus spielen? [Ja|Nein]");
                    string winCountInput = Console.ReadLine();
                    if (winCountInput == "Ja"|| winCountInput == "ja")
                    {
                        Random rnd2 = new Random();
                        int Generated2 = rnd2.Next(1, 1000);
                        Console.WriteLine(Generated2);
                        Console.WriteLine("Eine zufällige Zahl zwischen 1-1000 wurde Generiert");
                        Console.WriteLine("Probieren Sie es zu erraten");


                    }
                    if (winCountInput == "Nein" || winCountInput == "nein") 
                    {
                        Console.WriteLine("Schade");
                    }
                }


                if (Guess > 100)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Bitte geben Sie eine Zahl ZWISCHEN 1-100");
                }
                if (Guess < Generated)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Probieren sie höcher ↑");
                    
                    Guesses++;
                }
                else if ( Guess > Generated) 
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Probieren sie tiefer ↓");
               
                    Guesses++;
                }

                else if (Guess == Generated)
                    
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Gut gemacht, Sie haben es geschafft");
                    Console.WriteLine("Sie haben " + Guesses + " Versuche gebraucht");


                    
                    Console.WriteLine("Möchten Sie nochmal spielen?[Ja|Nein]");

                    string restart = Console.ReadLine();

                    if (restart == "ja"|| restart == "Ja")
                    {
                        winCount++;
                        Console.WriteLine(winCount);
                        goto start ;
                        
                    }
                    if (restart == "nein"|| restart == "Nein")
                    {
                        Environment.Exit(1);

                    }
                    else
                    {
                        Console.WriteLine("Falsche Eingabe");
                    }



                }
            } while (Guess != Generated|| winCount != 5 );
            




        }
    }
}
//