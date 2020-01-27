using System;
using Jobtech.OpenPlatforms.GigDataCommon.Library.Models;

namespace Jobtech.OpenPlatforms.GigDataCommon.Library.Messages
{
    public class PlatformUserUpdateDataMessage
    {
        public PlatformUserUpdateDataMessage(string requestId, string userName, Guid platformId, PlatformDataUserUpdateResult platformData)
        {
            RequestId = requestId;
            UserName = userName;
            PlatformId = platformId;
            PlatformData = platformData;
        }

        public string RequestId { get; private set; }
        public string UserName { get; private set; }
        public Guid PlatformId { get; private set; }
        public PlatformDataUserUpdateResult PlatformData { get; private set; }
    }
}
