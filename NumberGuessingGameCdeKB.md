#Code

`
using System;

namespace Number_guessing_game
{
    class Program
    {
       

         public static void  Main(string[] args)
        {

            int Guesses = 0;
            int Guess;
            Random rnd = new Random();
            int Generated = rnd.Next(1, 100);
            Console.WriteLine(Generated);

            Console.WriteLine("Eine zufällige Zahl wurde Generiert");
            Console.WriteLine("Probieren Sie es zu erraten");
            
            do
            {
                


                string strGuess = Console.ReadLine();
                Guess = Convert.ToInt32(strGuess); 

                if (Guess < Generated)
                {
                    Console.WriteLine("Probieren sie höcher");
                    Guesses++;
                }
                else if (Guess > Generated)
                {

                    Console.WriteLine("Probieren sie tiefer");
                    Guesses++;
                }

                else if (Guess == Generated)
                    
                {
                    Console.WriteLine("Gut gemacht, Sie haben es geschafft");
                    Console.WriteLine("Sie haben " + Guesses + " Versuche gebraucht");
                }
            } while (Guess != Generated );
            




        }
    }
}`
