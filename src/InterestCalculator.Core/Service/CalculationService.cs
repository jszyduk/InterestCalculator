using InterestCalculator.Core.LoanResult;
using InterestCalculator.Core.Models;
using InterestCalculator.Core.Strategies.Loans;
using System;
using System.Threading.Tasks;

namespace InterestCalculator.Core.Service
{
    public class CalculationService<T> : ICalculationService<T> where T : Loan
    {
        private readonly ILoanStrategy<T> _loanStrategy;

        public CalculationService(ILoanStrategy<T> loanStrategy)
        {
            _loanStrategy = loanStrategy;
        }

        public async Task<LoanCost> GetLoanPaybackPlan(T loan)
        {
            if (loan == null)
            {
                throw new ArgumentNullException("Loan object cannot be null");
            }

            return await Task.Run(() =>
            {
                var result = new LoanCost();
                var totalPaybackMonths = loan.Years * 12;
                //var monthlyInterest = _loanStrategy.GetMonthlyInterest(loan);

                result.TotalPaybackAmount = _loanStrategy.CalculateTotalPaybackAmount(loan);
                result.TotalInterestAmount = _loanStrategy.GetTotalInterest(loan);

                for (int i = 0; i < loan.Years; i++)
                {
                    for (int k = 1; k <= 12; k++)
                    {
                        var loanCostItem = new LoanCostItem
                        {
                            Amount = _loanStrategy.CalculateMonthlyPaybackCapital(loan),
                            Interest = _loanStrategy.GetMonthlyInterest(loan, k),
                            Month = k
                        };

                        result.Months.Add(loanCostItem);
                    }
                }

                return result;
            });
        }
    }
}
