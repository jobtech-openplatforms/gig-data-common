using System;
using Jobtech.OpenPlatforms.GigDataCommon.Library.Models;

namespace Jobtech.OpenPlatforms.GigDataCommon.Library.Messages
{
    public class PlatformUserUpdateDataMessage
    {
        public PlatformUserUpdateDataMessage(string requestId, string username, Guid platformId, PlatformDataUserUpdateResult platformData, PlatformDataUpdateResultType resultType = PlatformDataUpdateResultType.Succeess)
        {
            RequestId = requestId;
            Username = username;
            PlatformId = platformId;
            PlatformData = platformData;
            ResultType = resultType;
        }

        public string RequestId { get; private set; }
        public string Username { get; private set; }
        public Guid PlatformId { get; private set; }
        public PlatformDataUserUpdateResult PlatformData { get; private set; }
        public PlatformDataUpdateResultType ResultType { get; private set; }
    }

    public enum PlatformDataUpdateResultType
    {
        Succeess,
        UserNotFound,
        MalformedDataResponse,
        PlatformCommunicationError
    }
}
