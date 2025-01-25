using System;

class Program
{

    static void Main(string[] args)
    {
        Reference _reference = new Reference();
        Scripture _scripture = new Scripture();
        Word _word = new Word();
        _reference.GetAllText();
        _reference.SetReference();
        _scripture.PrintScriptures(_reference.GetReference(), _reference.GetText());
        while (true)
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            string _select = Console.ReadLine();
            Console.Clear();
            if (_select == "quit") break;

            

        }

    }
}