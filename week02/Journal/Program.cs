using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Journal _journal = new Journal();
        bool menu = true;
        while (menu)
        {
            Console.WriteLine("Please select one of the following choices: \n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
            int _select = int.Parse(Console.ReadLine());
            switch (_select)
            {
                case 1:
                    _journal.NewEntry();
                    break;
                case 2:
                    _journal.ShowEntries();
                    break;
                case 3:
                    Console.WriteLine("What is the name of the file?");
                    string fileName = Console.ReadLine() + ".txt";
                    _journal.SaveJournal(fileName);
                    break;
                case 5:
                menu = false;
                    break;
            }
        }
    }
}