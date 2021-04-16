using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator.Core.Strategies.Payback
{
    public interface IPaybackStrategy
    {
        decimal CalculateTotalInterest(decimal amount, decimal rate);

        decimal CalculateMonthlyInterest(decimal amount, decimal rate, int month);
    }
}
