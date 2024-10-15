using System.Net.Quic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace casino_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guess, bet, bank = 50;
            Random random = new Random();
            int answer = random.Next(1,3);
            bool done;
            string quit;
            Console.WriteLine("welcome to my casino game");
            Console.WriteLine("how much money would you like to start with?");
            int.TryParse(Console.ReadLine(), out bank);


            done = false;
            while (!done)
            {
                Console.Clear();
                Console.WriteLine("how much money would you like to bet?  You have " + bank);
                int.TryParse(Console.ReadLine(), out bet);
                if (bet > bank)
                {
                    Console.WriteLine("you bet more then you have, youre going all in, you're betting " + bank);
                    bet = bank;
                }
                if (bet < 0)
                {
                    Console.WriteLine("you bet a negative number, this round for fun you bet 0$");
                    bet = 0;
                }


                Console.WriteLine("1.heads or 2.tails");
                int.TryParse(Console.ReadLine(), out guess);
                if (answer == 1)
                    Console.WriteLine("the answer was heads");
                else
                    Console.WriteLine("the answer was tails");


                if (guess == answer)
                {

                    bank += bet;
                    Console.WriteLine("you got it correct");
                    Console.WriteLine("you won " + bet);
                    Console.WriteLine("you have " + bank);
                    Console.WriteLine("if you want to play again press Enter, if you want to quit press Q");
                    quit = Console.ReadLine();
                    if (quit == "q".ToLower())
                        done = true;
                }
                else if (guess != answer)
                {
                    bank -= bet;
                    
                    Console.WriteLine("you got it wrong");
                    Console.WriteLine("you lost " + bet);
                    Console.WriteLine("you're at " + bank);
                    Console.WriteLine("if you want to play again press Enter, if you want to quit press Q");
                    quit = Console.ReadLine();
                    if (quit == "q".ToLower())
                        done = true;
                }
                
                
            }
            

        }
    }
}
