class Activity
{
    private string _activity;
    public Activity(string activity)
    {
         _activity = activity;

    }
    public void DisplayStandartMessage()
    {
        Console.WriteLine($"Welcome to the {_activity} Activity");
        Console.WriteLine();
    }
    public void Animation(int number)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(number);

        while (DateTime.Now < futureTime)
        {
            Console.Write(".");
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("..");
            Thread.Sleep(500);

            Console.Write("\b\b  \b\b");
            Console.Write("...");
            Thread.Sleep(500);

            Console.Write("\b\b\b   \b\b\b");
            Thread.Sleep(500);
        }

    }

    public void DisplayfinishMessage(int seconds)

    {
        Console.WriteLine();
        Console.WriteLine("Well Done!!!");
        Animation(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {seconds} seconds of the {_activity} Activity");
        Animation(3);
        Console.Clear();
    }
}