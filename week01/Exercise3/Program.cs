using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(1,101);
        bool game = false;
        Console.WriteLine("What is the magic number? ");

        while (!game){
            
            Console.WriteLine("What is your guess? ");
            int number = int.Parse(Console.ReadLine());

            if (randomNumber > number){
                Console.WriteLine("Higher");
            }
            else if (randomNumber < number){
                Console.WriteLine("Lower");
            }
            else {
                Console.WriteLine($"You guessed it! It was {randomNumber}");
                game = true;
            }
        }
    }
}