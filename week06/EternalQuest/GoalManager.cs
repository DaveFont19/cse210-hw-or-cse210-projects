using System.Text.RegularExpressions;
class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    int _id;
    public GoalManager()
    {

    }
    public void Start()
    {
        LoadID();
        bool menu = true;
        while (menu)
        {
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options: \n1. Create New Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Event \n6. Quit \nSelect a choice from the menu");
            int select = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (select)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoals();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    ListGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    menu = false;
                    break;
                default:
                    Console.WriteLine("Invlaid Option");
                    break;
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }
    public void CreateGoal()
    {
        Console.Write("The types of Goals are: \n1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal \nWhich type of goal would you like to create? ");
        int number = int.Parse(Console.ReadLine());
        switch (number)
        {
            case 1:
                Console.Write("What is the name of your goal? ");
                string nameSimple = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string detailsSimple = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int pointsSimple = int.Parse(Console.ReadLine());
                SimpleGoal _simpleGoal = new SimpleGoal(nameSimple, detailsSimple, pointsSimple, _id, false);
                _goals.Add(_simpleGoal);
                LoadID();
                break;
            case 2:
                Console.Write("What is the name of your goal? ");
                string nameEternal = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string detailsEternal = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int pointsEternal = int.Parse(Console.ReadLine());
                EternalGoal _eternalGoal = new EternalGoal(nameEternal, detailsEternal, pointsEternal, _id);
                _goals.Add(_eternalGoal);
                LoadID();
                break;
            case 3:
                Console.Write("What is the name of your goal? ");
                string nameCheck = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string detailsCheck = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int pointsCheck = int.Parse(Console.ReadLine());
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int timesCheck = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonusCheck = int.Parse(Console.ReadLine());
                ChecklistGoal _checkGoal = new ChecklistGoal(nameCheck, detailsCheck, pointsCheck, _id, 0, timesCheck, bonusCheck);
                _goals.Add(_checkGoal);
                LoadID();
                break;
            default:
                break;
        }
    }
    public void SaveGoals()
    {
        Console.Write("What is the name of the file? ");
        string _fileName = Console.ReadLine() + ".txt";
        using (StreamWriter sw = File.CreateText(_fileName))

        {
            sw.WriteLine($"{_score}");
            foreach (Goal e in _goals)
            {
                sw.WriteLine(e.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the name of the file? ");
        string link = Console.ReadLine() + ".txt";
        if (File.Exists(link))
        {
            string content = File.ReadAllText(link);
            string[] lines = Regex.Split(content, "\r");
            _score = int.Parse(lines[0]);
            foreach (string line in lines)
            {
                if (line == "0")
                {

                }
                else
                {
                    string newLine = line.Substring(1);
                    string[] newList = newLine.Split('~');
                    AsignValues(newList);
                }

            }
        }
        else
        {
            Console.WriteLine("nothing");
        }
        LoadID();
    }
    public void ListGoals()
    {
        Console.Clear();
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStringDisplay());
        }
    }
    public void LoadID()
    {
        if (_goals.Count() > 0)
        {
            _id = _goals.Count() + 1;
        }
        else
        {
            _id = 1;
        }
    }

    public void AsignValues(string[] newList)
    {
        switch (newList[0])
        {
            case "simpleGoal":
                int points = int.Parse(newList[3]);
                bool status = newList[4] == "true" ? true : false;
                SimpleGoal _simpleGoal = new SimpleGoal(newList[1], newList[2], points, int.Parse(newList[5]), status);
                _goals.Add(_simpleGoal);
                break;
            case "eternalGoal":
                int p = int.Parse(newList[3]);
                EternalGoal _eternalGoal = new EternalGoal(newList[1], newList[2], p, int.Parse(newList[4]));
                _goals.Add(_eternalGoal);
                break;
            case "checklistGoal":
                int p2 = int.Parse(newList[3]);
                ChecklistGoal _checklistGoal = new ChecklistGoal(newList[1], newList[2], p2, int.Parse(newList[7]), int.Parse(newList[4]), int.Parse(newList[5]), int.Parse(newList[6]));
                _goals.Add(_checklistGoal);
                break;
        }
    }
    public void RecordEvent()
    {
        foreach (Goal g in _goals)
        {
            g.DisplayRecord();
        }
        Console.WriteLine("Which goal did you accomplish: ");
        int entry = int.Parse(Console.ReadLine());
        foreach (Goal g in _goals)
        {
            if (g.GetDisplayID() == entry)
            {
                g.Recordevent();
                
                if (g.IsComplete())
                {
                    _score += g.GetPoints();
                }else{
                    _score += g.Bonus();
                }
            }
        }
    }
}
