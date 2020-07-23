using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmallTasksWithReact.Core;

namespace SmallTasksWithReact.Controllers
{
    public class ListController : Controller
    {
        private readonly IListService _listService;

        public ListController(IListService service)
        {
            _listService = service;
        }

        [HttpGet("[action]")]
        public ActionResult SumOfEverySecondOddNumber(List<int> numberOne, List<int> numberTwo)
        {
            var sum = _listService.AddLists(numberOne, numberTwo);
            return Ok(sum);
        }
    }
}