using System;

public class GuessTheNumber
{
    public static void Main(string[] args)
    {
        //Guess the number game!
        int guess, min = 1, max = 101, tries = 0;
        Random random = new Random();
        int secretNum = random.Next(min, max);
        while(true) {
            tries++;
            Console.Write("Enter your guess : ");
            guess = Convert.ToInt32(Console.ReadLine());
            
            if (guess > secretNum) Console.WriteLine("Guessed number is greater than secret number!");
            else if (guess < secretNum) Console.WriteLine("Guessed number is smaller than secret number!");
            else break;
        }
        Console.WriteLine("You won!");
    }
}
