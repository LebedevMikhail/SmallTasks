using Microsoft.AspNetCore.Mvc;
using SmallTasksWithReact.Core;
using SmallTasksWithReact.Core.DTO;

namespace SmallTasksWithReact.Controllers
{
    [Route("api/[controller]")]
    public class StringController : Controller
    {
        private readonly IStringService _stringService;
        public StringController(IStringService service)
        {
            _stringService = service;
        }
        
        public ActionResult CheckIsPalindrome([FromQuery]string entity)
        {
           var isPalindrome = _stringService.IsPalindrome(new CheckPalindromeDto(entity));
            return Ok(isPalindrome);
        }
    }
}