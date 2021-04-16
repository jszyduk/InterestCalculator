using InterestCalculator.Core.LoanResult;
using InterestCalculator.Core.Models;
using System.Threading.Tasks;

namespace InterestCalculator.Core.Service
{
    public interface ICalculationService<T> where T : Loan
    {
        Task<LoanCost> GetLoanPaybackPlan(T loan);
    }
}
