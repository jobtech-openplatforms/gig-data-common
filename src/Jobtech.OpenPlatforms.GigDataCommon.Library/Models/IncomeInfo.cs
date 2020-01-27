namespace Jobtech.OpenPlatforms.GigDataCommon.Library.Models
{
    public class IncomeInfo
    {
        public IncomeInfo(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public decimal Amount { get; private set; }
        public string Currency { get; private set; }
    }
}