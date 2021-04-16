using InterestCalculator.Core.Models;

namespace InterestCalculator.Core.Strategies.Loans
{
    public class CarLoanStrategy : LoanStrategyBase, ILoanStrategy<CarLoan>
    {
        public decimal CalculateTotalPaybackAmount(CarLoan loan)
        {
            decimal insurance = 0;

            if (loan.ExtraInsurance)
            {
                insurance = 100 * loan.Years;
            }

            return loan.Amount + base.GetTotalInterest(loan.Amount, loan.Rate, loan.PaybackStrategy) + insurance;
        }

        public decimal GetMonthlyInterest(CarLoan loan)
        {
            return base.GetMonthlyInterest(loan.Amount, loan.Rate, loan.PaybackStrategy);
        }

        public decimal GetTotalInterest(CarLoan loan)
        {
            return base.GetTotalInterest(loan.Amount, loan.Rate, loan.PaybackStrategy);
        }
    }
}