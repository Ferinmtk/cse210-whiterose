namespace ExerciseTracking
{
    public class Running : Activity
    {
        private double distance; // Distance in kilometers

        public Running(string date, int length, double distance)
            : base(date, length)
        {
            this.distance = distance;
        }

        public override double GetDistance()
        {
            return distance;
        }
    }
}
