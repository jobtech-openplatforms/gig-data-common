using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Jobtech.OpenPlatforms.GigDataCommon.Library.Models.GigDataService
{
    public class CreatePlatformModel
    {
        public string Name { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public PlatformAuthenticationMechanism AuthMechanism { get; set; }

        public decimal MinRating { get; set; }
        public decimal MaxRating { get; set; }
        public decimal RatingSuccessLimit { get; set; }
    }
}