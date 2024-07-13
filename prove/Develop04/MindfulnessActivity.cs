using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    public int Duration { get; set; }
    
    public void StartActivity()
    {
        Console.WriteLine("Activity starting message.");
        Console.WriteLine("Enter the duration of the activity in seconds:");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Thread.Sleep(3000);
        PerformActivity();
        EndActivity();
    }
    
    protected abstract void PerformActivity();

    private void EndActivity()
    {
        Console.WriteLine("Well done! You've completed the activity.");
        Console.WriteLine($"You spent {Duration} seconds on this activity.");
        Thread.Sleep(3000);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }
}
