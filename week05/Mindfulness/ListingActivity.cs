public class ListingActivity : Activity
{
    List<string> prompts = new List<string>
    {
        "Who are people you appreciate?",
        "What are your strengths?"
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "List positive things in your life.";
    }

    public void Run()
    {
        StartMessage();

        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);

        Console.WriteLine("Start listing:");
        int count = 0;

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items!");

        EndMessage();
    }
}