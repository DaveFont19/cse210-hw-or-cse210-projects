class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string shortname, string description, int points, int id, bool isComplete) : base(shortname, description, points, id)
    {
        _isComplete = isComplete;
    }
    public override bool IsComplete()
    {
       return _isComplete;
        
    }
    public override void Recordevent()
    {
        _isComplete = true;
    }
    public override string GetStringRepresentation()
    {
        return $"simpleGoal~{GetDetailsString()}~{_isComplete}~{GetDisplayID()}";
    }
    public override string GetStringDisplay(){
        string complete = IsComplete() ? "X" : " ";
        return $"{GetDisplayID()}. [{complete}] {GetAttributes()}";
    }
}