using InterestCalculator.Core.Factory;
using InterestCalculator.Core.Models;
using InterestCalculator.Core.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Threading.Tasks;

namespace InterestCalculator.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HouseLoanController : ControllerBase
    {
        private readonly ILogger<HouseLoanController> _logger;
        private readonly ICalculationService<HouseLoan> _calculationService;

        public HouseLoanController(ILogger<HouseLoanController> logger, ICalculationService<HouseLoan> calculationService)
        {
            _logger = logger;
            _calculationService = calculationService;
        }

        [HttpGet("{amount}/{years}/{paybackType}")]
        public async Task<IActionResult> Get(decimal amount, int years, int paybackType)
        {
            try
            {
                var paybackStrategy = PaybackFactory.Build((PaybackType)paybackType, years);
                var loanCost = await _calculationService.GetLoanPaybackPlan(
                    new HouseLoan
                    {
                        Amount = amount,
                        Years = years,
                        PaybackStrategy = paybackStrategy
                    });

                return Ok(loanCost);
            }
            catch (Exception m)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, m.Message);
            }
        }
    }
}
