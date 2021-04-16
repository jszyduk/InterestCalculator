using InterestCalculator.Core.Strategies.Payback;
using System;

namespace InterestCalculator.Core.Factory
{
    public static class PaybackFactory
    {
        public static IPaybackStrategy Build(PaybackType paybackType, int years)
        {
            switch (paybackType)
            {
                case PaybackType.Steady:
                    return new SteadyPaybackStrategy(years);
                default:
                    throw new NotImplementedException($"{paybackType} is not implemented as payback strategy.");
            }
        }
    }
}
