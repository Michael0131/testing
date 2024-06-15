using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

class Activity
{
    protected string name;
    protected string description;
    protected int duration;


    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }
    // Shuffle the prompts - this is my extra work
    
    public virtual void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Starting Activity: {name}");
        Console.WriteLine(new string('-', $"Starting Activity: {name}".Length));
        Console.WriteLine();
        Console.WriteLine(description);
        Console.Write("Enter duration in seconds (Increments of 5): ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine($"Prepare to begin the {name} activity.");
        ShowSpinner(3);
        Console.Clear();
        // Stopwatch stopwatch = new Stopwatch();
    }

    public void EndActivity()
    {
        ShowGoodJobText();
        ShowSpinner(2);
        Console.WriteLine($"You have completed the {name} activity for {duration} seconds.");
        ShowSpinner(4);
    }
    // THIS IS 100% AI GENERATED ***************************************************************************8
    protected void ShowGoodJobText()
    {
        string message = "Good Job!";
        int width = Console.WindowWidth;
        int height = Console.WindowHeight;
        Random random = new Random();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed.TotalSeconds < 5) // Bounce for 5 seconds
        {
            int left = random.Next(width - message.Length);
            int top = random.Next(height - 1); // -1 to avoid cursor going out of bounds

            Console.Clear();
            Console.SetCursorPosition(left, top);
            Console.Write(message);
            Thread.Sleep(650); // Adjust delay for bouncing speed
        }

        Console.Clear();
        Console.SetCursorPosition(width / 2 - message.Length / 2, height / 2);
        Console.WriteLine(message);
    }
    // END AI GENERATED ZONE ************************************************************************************************
    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b|");
            Thread.Sleep(250);
            Console.Write("\b");
        }
        Console.WriteLine();
    }
    // Randominze all initial prompts
}
