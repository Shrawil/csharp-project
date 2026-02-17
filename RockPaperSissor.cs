using System;

public class RockPaperSiccor
{
    public static void Main(string[] args)
    {
        //Rock Paper Siccor Game
        int min = 1, max = 4, BC, PC, draws = 0, wins = 0, lose = 0;
        Random random = new Random();
        while (true) {
            //Asking for user input
            while(true) {
                Console.WriteLine("[0] Exit | [1] Rock | [2] Paper | [3] Sissor");
                Console.Write("Enter your choice : ");
                try { 
                    PC = Convert.ToInt32(Console.ReadLine());
                    if(PC == 1 || PC == 2 || PC == 3 || PC == 0) break;
                    else Console.WriteLine("Choose between 0 to 3");
                }
                catch {
                    Console.WriteLine("Invalid Input Recieved!");
                }
            }
            if (PC == 0) break;
            BC = random.Next(min, max);
            if (BC == 1) Console.WriteLine("Bot choose Rock!");
            else if (BC == 2)
                Console.WriteLine("Bot choose Paper!");
            else Console.WriteLine("Bot choose Siccor!");
            
            //Check win, lose or draw.
            
            if (BC == PC) {
                draws++;
                Console.WriteLine("Its a draw!");
            }
            else if (BC == 1 && PC == 2 || BC == 2 && PC == 3 || BC == 3 && PC == 1) {
                wins++;
                Console.WriteLine("You Won!");
            }
            else { 
                lose++;
                Console.WriteLine("You lose!");
            }
        }
        Console.WriteLine($"Wins : {wins} | Lose : {lose} | Draw : {draws}");
    }
}
