using Microsoft.VisualBasic;

public abstract class Goal
{
    private string _shortName, _description;
    private int _points;
     private int _id;
    public Goal(string shortname, string description, int points, int id){
        _shortName = shortname;
        _description = description;
        _points = points;
        _id = id;
    }
    public abstract void Recordevent();
    public abstract bool IsComplete();
    public int GetDisplayID(){
        return _id;
    }
    public int GetPoints(){
        return _points;
    }
    public string GetAttributes(){
        return $"{_shortName} ({_description})";
    }
    public string GetDetailsString(){
        return $"{_shortName}~{_description}~{_points}";
    }
    public abstract string GetStringRepresentation();
    public abstract string GetStringDisplay();
    public void DisplayRecord(){
        Console.WriteLine($"{_id}. {_shortName}");
    }
    public virtual int Bonus(){
        return 0;
    }
}