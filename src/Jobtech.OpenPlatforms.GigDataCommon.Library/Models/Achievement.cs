using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AF.Gig.Common.Models
{
    public class Achievement
    {
        public Achievement(string id, DateTimeOffset timeStamp, PlatformAchievementType type, string name,
            string description, AchievementScore score, string badgeIconUri)
        {
            Id = id;
            TimeStamp = timeStamp;
            Type = type;
            Name = name;
            Description = description;
            Score = score;
            BadgeIconUri = badgeIconUri;
        }

        public string Id { get; set; }
        public DateTimeOffset TimeStamp { get; private set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PlatformAchievementType Type { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public AchievementScore Score { get; private set; }
        public string BadgeIconUri { get; private set; }
    }
}