using InterestCalculator.Core.Models;

namespace InterestCalculator.Core.Strategies.Loans
{
    public class HouseLoanStrategy : LoanStrategyBase, ILoanStrategy<HouseLoan>
    {
        public decimal CalculateTotalPaybackAmount(HouseLoan loan)
        {
            return loan.Amount + base.GetTotalInterest(loan.Amount, loan.Rate, loan.PaybackStrategy);
        }

        public decimal GetMonthlyInterest(HouseLoan loan)
        {
            return base.GetMonthlyInterest(loan.Amount, loan.Rate, loan.PaybackStrategy);
        }

        public decimal GetTotalInterest(HouseLoan loan)
        {
            return base.GetTotalInterest(loan.Amount, loan.Rate, loan.PaybackStrategy);
        }
    }
}
