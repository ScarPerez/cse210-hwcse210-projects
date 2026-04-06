public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity helps you relax by breathing slowly.";
    }

    public void Run()
    {
        StartMessage();

        int time = 0;

        while (time < _duration)
        {
            Console.WriteLine("Breathe in...");
            Countdown(3);
            time += 3;

            Console.WriteLine("Breathe out...");
            Countdown(3);
            time += 3;
        }

        EndMessage();
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}