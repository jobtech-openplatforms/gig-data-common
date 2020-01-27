namespace AF.Gig.Common.Models
{
    public class Review
    {
        public Review(string title, string text)
        {
            Title = title;
            Text = text;
        }

        public string Title { get; private set; }
        public string Text { get; private set; }
    }
}