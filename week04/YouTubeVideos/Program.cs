using System;
using DocumentFormat.OpenXml.Spreadsheet;

class Program
{
    static void Main(string[] args)
    {
        Comments _com = new Comments(); ;
        Video _video1 = new Video();
        _video1._title = "The Beach Boys - Darlin' (2017 Stereo Mix)";
        _video1._author = "The Beach Boys";
        _video1._length = 214;

        Video _video2 = new Video();
        _video2._title = "Caifanes - No Dejes Qué... ((Cover Audio)(Video))";
        _video2._author = "caifanesVEVO";
        _video2._length = 440;

        Video _video3 = new Video();
        _video3._title = "Caifanes - Antes de que nos olviden (Cumbia Cover )";
        _video3._author = "Juan Escumbia";
        _video3._length = 258;

        bool menuLoop = true;
        while (menuLoop)
        {
            Console.WriteLine($"In what Video you want to commment? \n1.- {_video1._title} \n2.- {_video2._title} \n3.- {_video3._title} \n4.- Quit");
            int number = int.Parse(Console.ReadLine());
            if (number != 4)
            {
                Console.WriteLine("What is your name?");
                _com._name = Console.ReadLine();
                Console.WriteLine("What is the comment?");
                _com._comments = Console.ReadLine();
                switch (number)
                {

                    case 1:
                        _video1.AddComment(_com._name, _com._comments);
                        Console.WriteLine();
                        _com.DisplayComments(_video1);
                        Console.WriteLine();

                        break;
                    case 2:
                        _video2.AddComment(_com._name, _com._comments);
                        Console.WriteLine();
                        _com.DisplayComments(_video2);
                        Console.WriteLine();
                        break;
                    case 3:
                        _video3.AddComment(_com._name, _com._comments);
                        Console.WriteLine();
                        _com.DisplayComments(_video3);
                        Console.WriteLine();
                        break;
                }
            }

            else
            {
                menuLoop = false;
            }

        }
    }
}