using InterestCalculator.Core.Models;
using InterestCalculator.Core.Service;
using InterestCalculator.Core.Strategies.Loans;
using Microsoft.Extensions.DependencyInjection;

namespace InterestCalculator.Core
{
    public static class Setup
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddTransient(typeof(ILoanStrategy<HouseLoan>), typeof(HouseLoanStrategy));
            services.AddTransient(typeof(ILoanStrategy<CarLoan>), typeof(CarLoanStrategy));
            services.AddTransient(typeof(ICalculationService<>), typeof(CalculationService<>));

            return services;
        }
    }
}
