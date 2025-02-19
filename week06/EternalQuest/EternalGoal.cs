class EternalGoal : Goal
{
    public EternalGoal(string shortname, string description, int points, int id) : base (shortname, description, points, id) {

    }
    public override bool IsComplete(){
        return true;
    }
    public override void Recordevent()
    {
        
    }
    public override string GetStringRepresentation()
    {
         return $"eternalGoal~{GetDetailsString()}~{GetDisplayID()}";
    }
    public override string GetStringDisplay(){
        return $"{GetDisplayID()}. [ ] {GetAttributes()}";
    }
}