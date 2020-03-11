using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Jobtech.OpenPlatforms.GigDataCommon.Library.Models.GigDataService
{
    public class PlatformViewModel
    {

        public PlatformViewModel(Guid externalId, string name,
            PlatformAuthenticationMechanism authMechanism)
        {
            PlatformId = externalId;
            Name = name;
            AuthMechanism = authMechanism;
        }

        public Guid PlatformId { get; set; }
        public string Name { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PlatformAuthenticationMechanism? AuthMechanism { get; set; }
    }
}
