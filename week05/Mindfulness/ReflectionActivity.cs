class ReflectionActivity : Activity
{
    private int _activitySeconds;
    private string[] _randomPrompts = { "Think of a time when you stood up for someone else.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
    private string[] _randomQuestions = { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };
    public ReflectionActivity(string activity, int seconds) : base(activity)
    {
        _activitySeconds = seconds;
    }
    public void StarMessage()
    {
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
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
        Console.WriteLine(_randomPrompts[number]);
        Console.ReadLine();
    }
    public void Question2()
    {
        Random rnd = new Random();
        int lengthArray = _randomQuestions.Length;
        int number = rnd.Next(0, lengthArray);
        Console.WriteLine(_randomQuestions[number]);
        Console.ReadLine();
    }
    public void CounterActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_activitySeconds);

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine();
            Question1();
            Console.WriteLine();
            Question2();
            Console.WriteLine();
        }
    }

}