using InterestCalculator.Api.Controllers;
using InterestCalculator.Core.LoanResult;
using InterestCalculator.Core.Models;
using InterestCalculator.Core.Service;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace InterestCalculator.Api.Test
{
    public class HouseLoanControllerTest
    {
        [Fact]
        public async Task Should_Call_Once_GetPaybackPlan()
        {
            var loggerMock = new Mock<ILogger<HouseLoanController>>();
            var service = new Mock<ICalculationService<HouseLoan>>();
            service.Setup(p => p.GetLoanPaybackPlan(It.IsAny<HouseLoan>())).Returns(It.IsAny<Task<LoanCost>>());
            var controller = new HouseLoanController(loggerMock.Object, service.Object);

            await controller.Get(It.IsAny<decimal>(), It.IsAny<int>(), It.IsAny<int>());
            service.Verify(p => p.GetLoanPaybackPlan(It.IsAny<HouseLoan>()), Times.Once());
        }
    }
}
