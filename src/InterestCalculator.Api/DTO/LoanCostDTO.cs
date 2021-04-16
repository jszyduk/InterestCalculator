using System.Collections.Generic;

namespace InterestCalculator.Api.DTO
{
    public class LoanCostDTO
    {
        public IEnumerable<LoanCostItemDTO> Months { get; set; }

        public decimal TotalInterestAmount { get; set; }

        public decimal TotalPaybackAmount { get; set; }
    }
}
