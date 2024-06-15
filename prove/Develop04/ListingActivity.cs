using System.Diagnostics;

class ListingActivity : Activity
{
    private List<string> prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    public void Run()
    {
        StartActivity();
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        ShowSpinner(3);

        List<string> items = new List<string>();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        // ShowCountdown(duration);
        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            // ShowCountdown(duration);
            Console.Write("List an item: ");
            string item = Console.ReadLine();
            items.Add(item);
            if (stopwatch.Elapsed.TotalSeconds >= duration)
            {
                break;
            }

        }
        stopwatch.Stop();
        Console.WriteLine($"You listed {items.Count} items.");
        EndActivity();


    }
    // private void ShowCountdown(int seconds)
    // {
    //     for (int i = seconds; i > 0; i--)
    //     {
    //         Console.Write(i + " ");
    //         Thread.Sleep(1000);
    //         Console.Write("\b\b");
            
    //     }
    // }
}
