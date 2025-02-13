class BreathingActivity : Activity
{
    private int _activitySeconds;
    public BreathingActivity(string activity, int seconds) : base(activity)
    {
        _activitySeconds = seconds;
    }
    public void StarMessage()
    {
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. \nClear your mind and focus on your breathing.");
        Console.WriteLine();
    }
    public void SetSeconds(int seconds)
    {
        _activitySeconds = seconds;
        Console.Clear();
    }
    public void BreatheIn()
    {
        int number = 4;
        while (number > 0)
        {
            if (number == 4)
            {
                Console.Write($"Breathe in... {number}");
                number--;
                Thread.Sleep(1000);
            }
            else
            {
                Console.Write($"\rBreathe in... {number}");
                number--;
                Thread.Sleep(1000);
            }
        }
        Console.Write("\b \b");
    }
    public void BreatheOut()
    {
        int number = 6;
        while (number > 0)
        {
            if (number == 6)
            {
                Console.Write($"Breathe out... {number}");
                number--;
                Thread.Sleep(1000);
            }
            else
            {
                Console.Write($"\rBreathe out... {number}");
                number--;
                Thread.Sleep(1000);
            }
        }
        Console.Write("\b \b");
    }
    public void CounterActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_activitySeconds);

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine();
            BreatheIn();
            Console.WriteLine();
            BreatheOut();
            Console.WriteLine();
        }
    }
}