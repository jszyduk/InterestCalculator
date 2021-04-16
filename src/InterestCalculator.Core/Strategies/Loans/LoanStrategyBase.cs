using InterestCalculator.Core.Strategies.Payback;

namespace InterestCalculator.Core.Strategies.Loans
{
    public abstract class LoanStrategyBase
    {
        public virtual decimal GetTotalInterest(decimal amount, decimal rate, IPaybackStrategy paybackStrategy)
        {
            return paybackStrategy.CalculateTotalInterest(amount, rate);
        }

        public virtual decimal GetMonthlyInterest(decimal amount, decimal rate, int month, IPaybackStrategy paybackStrategy)
        {
            return paybackStrategy.CalculateMonthlyInterest(amount, rate, month);
        }
    }
}
