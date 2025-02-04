using System.Reflection.Metadata.Ecma335;

class Assignment
{
    private string _studentName, _topic;
    public Assignment(string name, string topic){
        _studentName = name;
        _topic = topic;
    }
    public string Getsummary(){
        return ($"{_studentName } - {_topic}");
    }
}