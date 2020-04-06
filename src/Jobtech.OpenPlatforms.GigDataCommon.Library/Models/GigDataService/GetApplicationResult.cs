namespace Jobtech.OpenPlatforms.GigDataCommon.Library.Models.GigDataService
{
    public class GetApplicationResult
    {
        public string ApplicationId { get; set; }
        public string Name { get; set; }
        
        public string AuthCallbackUrl { get; set; }
        public string GigDataNotificationUrl { get; set; }
        public string EmailVerificationUrl { get; set; }

        public string SecretKey { get; set; }
    }
}