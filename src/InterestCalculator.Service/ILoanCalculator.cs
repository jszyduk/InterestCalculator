using InterestCalculator.Domain.Loan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator.Service
{
    public interface ILoanCalculator
    {
        LoanCost CalculateLoanCost(ILoan loan);
    }
}
