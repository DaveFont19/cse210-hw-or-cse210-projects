using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string name = PromptUserName();
        int number = PromptUserNumber();

        int square = SquareNumber(number);

        DisplayResult(name, square);
    }

    static void DisplayMessage(){
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName(){
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
     static int PromptUserNumber(){
        Console.WriteLine("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number){
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square){
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
    
}