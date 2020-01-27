using System.Collections.Generic;

namespace Jobtech.OpenPlatforms.GigDataCommon.Library.Models
{
    public class PlatformDataUserUpdateResult
    {
        public PlatformDataUserUpdateResult(IEnumerable<Interaction> interactions, IEnumerable<Achievement> achievements, string rawData)
        {
            Interactions = (IReadOnlyList<Interaction>) interactions;
            Achievements = (IReadOnlyList<Achievement>) achievements;
            RawData = rawData;
        }

        public IReadOnlyList<Interaction> Interactions { get; private set; }
        public IReadOnlyList<Achievement> Achievements { get; private set; }
        public string RawData { get; set; }
    }
}
