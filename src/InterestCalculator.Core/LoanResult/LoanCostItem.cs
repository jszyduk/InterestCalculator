namespace InterestCalculator.Core.LoanResult
{
    public class LoanCostItem
    {
        public int Month { get; set; }

        public decimal Amount { get; set; }

        public decimal Interest { get; set; }

        public decimal Total { get => Amount + Interest; }
    }
}
