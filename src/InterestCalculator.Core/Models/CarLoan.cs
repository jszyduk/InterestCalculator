namespace InterestCalculator.Core.Models
{
    public class CarLoan: Loan
    {
        public override decimal Rate => 2.9M;

        public bool ExtraInsurance { get; set; }

    }
}
