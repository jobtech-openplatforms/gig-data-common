namespace AF.Gig.Common.Models
{
    public class Interaction
    {
        public Interaction(string id, TimePeriod period, PersonInfo client, string type, InteractionOutcome outcome, InteractionMetaData additionalData)
        {
            Id = id;
            Period = period;
            Client = client;
            Type = type;
            Outcome = outcome;
            AdditionalData = additionalData;
        }

        public string Id { get; private set; }
        public TimePeriod Period { get; private set; }
        public PersonInfo Client { get; private set; }
        public string Type { get; private set; }
        public InteractionOutcome Outcome { get; private set; }
        public InteractionMetaData AdditionalData { get; private set; }

    }
}