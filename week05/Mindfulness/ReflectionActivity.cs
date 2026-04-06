public class ReflectionActivity : Activity
{
    List<string> prompts = new List<string>
    {
        "Think of a time when you helped someone.",
        "Think of a time you were strong."
    };

    List<string> questions = new List<string>
    {
        "Why was this meaningful?",
        "What did you learn?",
        "How did you feel?"
    };

    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "This helps you reflect on your strengths.";
    }

    public void Run()
    {
        StartMessage();

        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);

        int time = 0;

        while (time < _duration)
        {
            string q = questions[rand.Next(questions.Count)];
            Console.WriteLine(q);

            ShowSpinner(5);
            time += 5;
        }

        EndMessage();
    }
}