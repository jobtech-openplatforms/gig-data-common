namespace AF.Gig.Common.Models
{
    public class AchievementScore
    {
        public AchievementScore(decimal value, string label)
        {
            Value = value;
            Label = label;
        }

        public decimal Value { get; private set; }
        public string Label { get; private set; }
    }
}