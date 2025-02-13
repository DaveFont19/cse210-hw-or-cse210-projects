class ListingActivity : Activity
{
    private int _activitySeconds;
    private string[] _randomPrompts = { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
    public ListingActivity(string activity, int seconds) : base(activity)
    {
        _activitySeconds = seconds;
    }
    public void StarMessage()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine();
    }
    public void SetSeconds(int seconds)
    {
        _activitySeconds = seconds;
        Console.Clear();
    }
    public void Question1()
    {
        Random rnd = new Random();
        int lengthArray = _randomPrompts.Length;
        int number = rnd.Next(0, lengthArray);
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {_randomPrompts[number]} ---");
    }
    public void CountDown(){
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);
        int number = 5;
        Console.Write($"You may begin in: ");

        while (DateTime.Now < futureTime)
        {
            Console.Write(number);
            Thread.Sleep(1000);

            Console.Write("\b \b");
            number--;
        }

    }
    public void CounterActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_activitySeconds);

        Question1();
        int number = 0;
        CountDown();
        Console.WriteLine();

        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            number++;
        }
        Console.WriteLine($"You listed {number} items!");
    }
}