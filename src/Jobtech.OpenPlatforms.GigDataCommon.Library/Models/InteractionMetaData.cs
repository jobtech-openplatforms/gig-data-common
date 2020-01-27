using System.Collections.Generic;

namespace Jobtech.OpenPlatforms.GigDataCommon.Library.Models
{
    public class InteractionMetaData
    {
        public InteractionMetaData(string location, string title, string description, IEnumerable<ImageInfo> images,
            decimal? noOfHours, IncomeInfo income)
        {
            Location = location;
            Title = title;
            Description = description;
            Images = (IReadOnlyList<ImageInfo>) images;
            NoOfHours = noOfHours;
            Income = income;
        }

        public string Location { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public IReadOnlyList<ImageInfo> Images { get; private set; }
        public decimal? NoOfHours { get; private set; }
        public IncomeInfo Income { get; private set; }

    }
}