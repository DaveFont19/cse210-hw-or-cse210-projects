class ChecklistGoal : Goal
{
    private int _amountCompleted, _bonus, _target;
    public ChecklistGoal(string shortname, string description, int points, int id, int tries, int target, int bonus) : base(shortname, description, points, id)
    {
        _amountCompleted = tries;
        _bonus = bonus;
        _target = target;

    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    public override void Recordevent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted += 1;

        }

    }
    public override string GetStringRepresentation()
    {
        return $"checklistGoal~{GetDetailsString()}~{_amountCompleted}~{_target}~{_bonus}~{GetDisplayID()}";
    }
    public override string GetStringDisplay()
    {
        string complete = IsComplete() ? "X" : " ";
        return $"{GetDisplayID()}. [{complete}] {GetAttributes()} -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override int Bonus()
    {
        return _bonus;
    }
}