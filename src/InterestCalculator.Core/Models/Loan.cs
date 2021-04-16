using InterestCalculator.Core.Strategies.Payback;

namespace InterestCalculator.Core.Models
{
    public abstract class Loan
    {
        public abstract decimal Rate { get; }

        public decimal Amount { get; set; }

        public int Years { get; set; }

        public IPaybackStrategy PaybackStrategy { get; set; }

    }
}
