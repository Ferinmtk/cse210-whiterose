namespace ExerciseTracking
{
    public abstract class Activity
    {
        private string date;
        private int length; // Length in minutes

        public Activity(string date, int length)
        {
            this.date = date;
            this.length = length;
        }

        public string Date => date;
        public int Length => length;

        public abstract double GetDistance(); // Distance in miles or kilometers
        public virtual double GetSpeed()
        {
            return (GetDistance() / Length) * 60; // Speed in mph or kph
        }

        public virtual double GetPace()
        {
            return Length / GetDistance(); // Pace in minutes per mile or km
        }

        public virtual string GetSummary()
        {
            return $"{date} {this.GetType().Name} ({length} min) - Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
        }
    }
}
