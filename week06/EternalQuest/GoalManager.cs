public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void ShowGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i}. {_goals[i].GetDetailsString()}");
        }
    }

    public void RecordEvent(int index)
    {
        int points = _goals[index].RecordEvent();
        _score += points;

        Console.WriteLine($"You earned {points} points!");

        CheckLevelUp();
        CheckAchievements();
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Score: {_score}");
    }

    // 🔥 LEVEL SYSTEM
    private void CheckLevelUp()
    {
        if (_score >= 1000)
            Console.WriteLine("🔥 Level 2 reached!");
        if (_score >= 3000)
            Console.WriteLine("🚀 Level 3 reached!");
        if (_score >= 5000)
            Console.WriteLine("👑 MAX LEVEL!");
    }

    // 🏆 ACHIEVEMENTS
    private void CheckAchievements()
    {
        if (_score >= 500)
            Console.WriteLine("🏆 Achievement: Getting Started!");
        if (_score >= 2000)
            Console.WriteLine("🏆 Achievement: Consistency Master!");
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }
}