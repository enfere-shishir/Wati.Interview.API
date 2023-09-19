using Microsoft.AspNetCore.Mvc;

namespace Wati.API.Controllers
{
    [ApiController]
    [Route("/[action]")]
    public class CalculatorController : ControllerBase
    {
        [HttpPost(Name = "Add")]
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}