using System;

class Program
{

    static void Main(string[] args)
    {
        Reference _reference = new Reference();
        Scripture _scripture = new Scripture();
        _reference.GetAllText();
        _reference.SetReference();
        _scripture.DisplayText(_reference.GetReference());
        _scripture.DisplayText(_reference.GetText());
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            string _select = Console.ReadLine();
            Console.Clear();
            if (_select == "quit") break;
            string wordsHidden = _scripture.HideRandomWords(_reference.GetText());
            _reference.SetText(wordsHidden);
            _scripture.DisplayText(_reference.GetReference());
            _scripture.DisplayText(_reference.GetText());


        }

    }
}