using System;

class Program
{
    static void Main(string[] args)
    {
        bool menu = true;
        while (menu)
        {
            Console.WriteLine("Please select one of the following choices: \n1. Start Breathing Activity \n2. Start Reflection Activity \n3. Start Listing Activity \n4. Quit");
            int select = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (select)
            {
                case 1:
                    BreathingActivity _breathing = new BreathingActivity("Breathing", 5);
                    _breathing.DisplayStandartMessage();
                    _breathing.StarMessage();
                    Console.Write("How long, in seconds, would you like for your session? ");
                    int seconds1 = int.Parse(Console.ReadLine());
                    _breathing.SetSeconds(seconds1);
                    Console.WriteLine("Get Ready!!!!");
                    _breathing.Animation(4);
                    _breathing.CounterActivity();
                    _breathing.DisplayfinishMessage(seconds1);
                    break;
                case 2:
                    ReflectionActivity _reflection = new ReflectionActivity("Reflection", 5);
                    _reflection.DisplayStandartMessage();
                    _reflection.StarMessage();
                    Console.Write("How long, in seconds, would you like for your session? ");
                    int seconds2 = int.Parse(Console.ReadLine());
                    _reflection.SetSeconds(seconds2);
                    Console.WriteLine("Get Ready!!!!");
                    _reflection.Animation(4);
                    _reflection.CounterActivity();
                    _reflection.DisplayfinishMessage(seconds2);
                    break;
                case 3:
                    ListingActivity _listin = new ListingActivity("Listing", 5);
                    _listin.DisplayStandartMessage();
                    _listin.StarMessage();
                    Console.Write("How long, in seconds, would you like for your session? ");
                    int seconds3 = int.Parse(Console.ReadLine());
                    _listin.SetSeconds(seconds3);
                    Console.WriteLine("Get Ready!!!!");
                    _listin.Animation(4);
                    _listin.CounterActivity();
                    _listin.DisplayfinishMessage(seconds3);
                    break;
                case 4:
                    menu = false;
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}