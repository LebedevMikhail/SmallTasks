using Microsoft.AspNetCore.Mvc;
using SmallTasksWithReact.Core;

namespace SmallTasksWithReact.Controllers
{
    [Route("api/[controller]")]
    public class NumberController : Controller
    {
        private readonly INumberService _numberService;

        public NumberController(INumberService service)
        {
            _numberService = service;
        }

        [HttpGet("[action]")]
        public ActionResult SumOfEverySecondOddNumber(int[] numbers)
        {
           var sum = _numberService.SumOfEverySecondOddNumber(numbers);
            return Ok(sum);
        }
    }
}