using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Jobtech.OpenPlatforms.GigDataCommon.Library.Models.ApplicationApi
{   public class PlatformConnectionUpdateNotificationPayload
    {
        public Guid PlatformId { get; set; }
        public string PlatformName { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public PlatformConnectionState PlatformConnectionState { get; set; }
        public Guid UserId { get; set; }
        public long Updated { get; set; }
        public PlatformDataPayload PlatformData { get; set; }
        public string AppSecret { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public NotificationReason Reason { get; set; }
    }

    public class PlatformDataPayload
    {
        public int NumberOfGigs { get; set; }
        public int NumberOfRatings { get; set; }
        public int NumberOfRatingsThatAreDeemedSuccessful { get; set; }
        [JsonConverter(typeof(YearMonthDayDateTimeConverter))]
        public DateTimeOffset? PeriodStart { get; set; }
        [JsonConverter(typeof(YearMonthDayDateTimeConverter))]
        public DateTimeOffset? PeriodEnd { get; set; }
        public PlatformRatingPayload AverageRating { get; set; }
    }
    public class PlatformRatingPayload
    {
        public PlatformRatingPayload(PlatformRating rating)
        {
            Value = rating.Value;
            Min = rating.Min;
            Max = rating.Max;
            IsSuccessful = rating.Value >= rating.SuccessLimit;
        }

        public decimal Value { get; set; }
        public decimal Min { get; set; }
        public decimal Max { get; set; }
        public bool IsSuccessful { get; set; }
    }

    public class PlatformRating
    {
        private PlatformRating()
        {
            Identifier = Guid.NewGuid();
            Created = DateTimeOffset.UtcNow;
        }

        public PlatformRating(Guid identifier, decimal value, decimal min, decimal max, decimal successLimit) : this()
        {
            Identifier = identifier;
            Value = value;
            Min = min;
            Max = max;
            SuccessLimit = successLimit;
        }

        public Guid Identifier { get; private set; }
        public decimal Min { get; private set; }
        public decimal Max { get; private set; }
        public decimal SuccessLimit { get; private set; }
        public decimal Value { get; private set; } 
        public DateTimeOffset Created { get; private set; }
    }

    internal class YearMonthDayDateTimeConverter : IsoDateTimeConverter
    {
        public YearMonthDayDateTimeConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
    }