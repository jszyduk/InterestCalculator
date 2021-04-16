using InterestCalculator.Core.Models;

namespace InterestCalculator.Core.Strategies.Loans
{
    public interface ILoanStrategy<T> where T : Loan
    {
        decimal CalculateMonthlyPaybackCapital(T loan);

        decimal CalculateTotalPaybackAmount(T loan);

        decimal GetTotalInterest(T loan);

        decimal GetMonthlyInterest(T loan, int month);
    }
}
