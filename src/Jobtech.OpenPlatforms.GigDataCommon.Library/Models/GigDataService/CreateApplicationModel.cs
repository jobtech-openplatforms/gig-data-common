namespace Jobtech.OpenPlatforms.GigDataCommon.Library.Models.GigDataService
{
    public class CreateApplicationModel

    {
        public string Name { get; set; }
        public string DataUpdateCallbackUrl { get; set; }
        public string AuthCallbackUrl { get; set; }
    }
}