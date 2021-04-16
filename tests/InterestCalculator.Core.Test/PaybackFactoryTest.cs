using InterestCalculator.Core.Factory;
using InterestCalculator.Core.Strategies.Payback;
using System;
using Xunit;
using FluentAssertions;

namespace InterestCalculator.Core.Test
{
    public class PaybackFactoryTest
    {
        [Fact]
        public void PaybacFactory_Should_Create_Steady()
        {
            var paybackStrategy = PaybackFactory.Build(PaybackType.Steady, 10);

            paybackStrategy.Should().NotBeNull();
            paybackStrategy.Should().BeOfType<SteadyPaybackStrategy>();
        }

        [Fact]
        public void PaybacFactory_Should_Throw_Exception()
        {
            Action test = () => PaybackFactory.Build((PaybackType)1000, 10);
            test.Should().Throw<NotImplementedException>().WithMessage($"1000 is not implemented as payback strategy.");
        }
    }
}
