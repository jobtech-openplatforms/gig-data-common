namespace Jobtech.OpenPlatforms.GigDataCommon.Library.Models
{
    public class PersonInfo
    {
        public PersonInfo(string id, string name, string photoUri)
        {
            Id = id;
            Name = name;
            PhotoUri = photoUri;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public string PhotoUri { get; private set; }
    }
}