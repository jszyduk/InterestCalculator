using System.Collections.Generic;

namespace InterestCalculator.Core.LoanResult
{
    public class LoanCost
    {
        public List<LoanCostItem> Months { get; set; } = new List<LoanCostItem>();

        public decimal TotalInterestAmount { get; set; }

        public decimal TotalPaybackAmount { get; set; }


    }
}
