namespace Jobtech.OpenPlatforms.GigDataCommon.Library.Models.GigDataService
{
    public class CreateApplicationModel

    {
        public string Name { get; set; }
        public string NotificationEndpointUrl { get; set; }
        public string EmailVerificationNotificationEndpointUrl { get; set; }
        public string AuthCallbackUrl { get; set; }
    }
}