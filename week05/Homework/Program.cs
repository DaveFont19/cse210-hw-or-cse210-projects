using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment _assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(_assignment.Getsummary());

        Math _math = new Math("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(_math.Getsummary());
        Console.WriteLine(_math.GetHomeworkList());

        Writing _writing =  new Writing ("Mary Waters", "European history", "The causes of World War II by Mary Waters");
    }
}