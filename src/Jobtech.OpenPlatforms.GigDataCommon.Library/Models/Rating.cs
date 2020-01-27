namespace Jobtech.OpenPlatforms.GigDataCommon.Library.Models
{
    public class Rating
    {
        public Rating(string name, decimal value, decimal min, decimal max)
        {
            Name = name;
            Value = value;
            Min = min;
            Max = max;
        }

        public string Name { get; private set; }
        public decimal Value { get; private set; }
        public decimal Min { get; private set; }
        public decimal Max { get; private set; }
    }
}