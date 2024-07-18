using System;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            //  activities
            Activity running = new Running("03 Nov 2022", 30, 5.0); // 5 km run
            Activity cycling = new Cycling("03 Nov 2022", 30, 20.0); // 20 kph
            Activity swimming = new Swimming("03 Nov 2022", 30, 30); // 30 laps

            //list of activities
            List<Activity> activities = new List<Activity> { running, cycling, swimming };

            // Display summaries for each activity
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
                Console.WriteLine();
            }
        }
    }
}
