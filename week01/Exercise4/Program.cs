using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = 1;
        int sum = 0;
        int largest = 0;
        int average;


        while(number != 0){
            Console.WriteLine("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0){
            numbers.Add(number);
            }
            if (number > largest){
                largest = number;
            }
        }
        foreach (int i in numbers){
            sum += i;
        }

        average = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}