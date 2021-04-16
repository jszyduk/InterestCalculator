using InterestCalculator.Core.Common;

namespace InterestCalculator.Core.Strategies.Payback
{
    public class SteadyPaybackStrategy : IPaybackStrategy
    {
        public int Years { get; private set; }

        public SteadyPaybackStrategy(int years)
        {
            Years = years;
        }

        public decimal CalculateMonthlyInterest(decimal amount, decimal rate, int month)
        {
            decimal ratio = Utils.GetDaysCount(month) / (decimal)365;
            return amount * (rate /100) * ratio;
        }

        public decimal CalculateTotalInterest(decimal amount, decimal rate)
        {
            return (amount * (rate / 100)) * Years;
        }
    }
}
