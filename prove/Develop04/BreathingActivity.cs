using System.Diagnostics;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public override void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Starting Activity: {name}");
        Console.WriteLine(new string('-', $"Starting Activity: {name}".Length));
        Console.WriteLine();
        Console.WriteLine(description);
        Console.Write("Enter duration in seconds (Increments of 10): ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine($"Prepare to begin the {name} activity.");
        ShowSpinner(3);
        Console.Clear();
    }
    public void Run()
    {
        StartActivity();
        Console.Clear();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            Console.Write("Breathe in...");
            ShowCountdown(5);
            Console.Clear();
            Console.Write("Breathe out...");
            ShowCountdown(5);
            Console.Clear();
            
            if (stopwatch.Elapsed.TotalSeconds >= duration)
            {
                break;
            }
        }
        stopwatch.Stop();
        EndActivity();
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
            Console.Write("\b\b");
            
        }
    }
}
