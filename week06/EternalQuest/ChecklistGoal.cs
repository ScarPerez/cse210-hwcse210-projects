public class ChecklistGoal : Goal
{
    private int _target;
    private int _count;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _count = 0;
    }

    public override int RecordEvent()
    {
        _count++;

        if (_count == _target)
        {
            return _points + _bonus;
        }

        return _points;
    }

    public override bool IsComplete() => _count >= _target;

    public override string GetDetailsString()
    {
        return $"{(_count >= _target ? "[X]" : "[ ]")} {_name} ({_count}/{_target})";
    }
}