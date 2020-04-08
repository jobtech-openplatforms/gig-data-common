using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Jobtech.OpenPlatforms.GigDataCommon.Library.Models.GigDataService
{
    public class PlatformViewModel
    {

        public PlatformViewModel(Guid platformId, string name,
                                PlatformAuthenticationMechanism? authMechanism, bool isInactive,
                                string description, string logoUrl, string websiteUrl)
        {
            PlatformId = platformId;
            Name = name;
            AuthMechanism = authMechanism;
            IsInactive = isInactive;
            Description = description;
            LogoUrl = logoUrl;
            WebsiteUrl = websiteUrl;
        }

        [JsonConstructor]
        public PlatformViewModel(string platformId, string name,
                        PlatformAuthenticationMechanism? authMechanism, bool isInactive,
                        string description, string logoUrl, string websiteUrl)
        {
            PlatformId = Guid.Parse( platformId);
            Name = name;
            AuthMechanism = authMechanism;
            IsInactive = isInactive;
            Description = description;
            LogoUrl = logoUrl;
            WebsiteUrl = websiteUrl;
        }

        public Guid PlatformId { get; set; }
        public string Name { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PlatformAuthenticationMechanism? AuthMechanism { get; set; }
        public bool IsInactive { get; set; }
        public string Description { get; set; }
        public string LogoUrl { get; set; }
        public string WebsiteUrl { get; set; }

    }
}
