namespace AF.Gig.Common.Models
{
    public class ImageInfo
    {
        public ImageInfo(string uri, string caption)
        {
            Uri = uri;
            Caption = caption;
        }

        public string Uri { get; private set; }
        public string Caption { get; private set; }
    }
}