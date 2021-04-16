using FluentAssertions;
using InterestCalculator.Core.Models;
using InterestCalculator.Core.Strategies.Loans;
using InterestCalculator.Core.Strategies.Payback;
using System;
using Xunit;

namespace InterestCalculator.Core.Test
{
    public class HouseStrategyTests
    {
        [Fact]
        public void Should_Calculate_TotalPaybackAmount()
        {
            var houseLoanStrateg = new HouseLoanStrategy();
            var loan = new HouseLoan { 
                 Amount = 1000,
                 Years = 10,
                 PaybackStrategy = new SteadyPaybackStrategy(10)
            };

            var result = houseLoanStrateg.CalculateTotalPaybackAmount(loan);

            Math.Round(result, 2).Should().Be(1350);
        }

        [Fact]
        public void Should_Return_MonthlyInterest()
        {
            var houseLoanStrateg = new HouseLoanStrategy();
            var loan = new HouseLoan
            {
                Amount = 1000,
                Years = 10,
                PaybackStrategy = new SteadyPaybackStrategy(10)
            };

            var result = houseLoanStrateg.GetMonthlyInterest(loan, 1);

            Math.Round(result, 2).Should().Be(2.97M);
        }

        [Fact]
        public void Should_Return_TotalInterest()
        {
            var houseLoanStrateg = new HouseLoanStrategy();
            var loan = new HouseLoan
            {
                Amount = 1000,
                Years = 10,
                PaybackStrategy = new SteadyPaybackStrategy(10)
            };

            var result = houseLoanStrateg.GetTotalInterest(loan);

            Math.Round(result, 2).Should().Be(350);
        }




    }
}
