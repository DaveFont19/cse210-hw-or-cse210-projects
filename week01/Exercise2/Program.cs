using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the grade: ");
        string grade = Console.ReadLine();
        int numberGrade = int.Parse(grade);

        string letter = "";
        if (numberGrade >= 90) {
            letter = "A";
        }
        if (numberGrade >= 80) {
            letter = "B";
        }
        if (numberGrade >= 70) {
            letter = "C";
        }
        if (numberGrade >= 60) {
            letter = "D";
        }
        if (numberGrade < 60) {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (numberGrade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("So sorry, Try again");
        }
    }
}