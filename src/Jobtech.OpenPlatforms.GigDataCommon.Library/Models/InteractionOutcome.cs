using System.Collections.Generic;

namespace AF.Gig.Common.Models
{
    public class InteractionOutcome
    {
        public InteractionOutcome(Review review, IEnumerable<Rating> ratings, bool? success = null)
        {
            Review = review;
            Ratings = (IReadOnlyCollection<Rating>) ratings;
            Success = success;
        }

        public Review Review { get; private set; }
        public IReadOnlyCollection<Rating> Ratings { get; private set; }
        public bool? Success { get; private set; }
    }
}