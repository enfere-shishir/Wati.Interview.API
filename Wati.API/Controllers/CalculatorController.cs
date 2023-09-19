using Microsoft.AspNetCore.Mvc;
using Wati.API.Common;

namespace Wati.API.Controllers
{
    [ApiController]
    [Route("/[action]")]
    public class CalculatorController : ControllerBase
    {

        [HttpPost(Name = "Add")]
        public int Add(int firstNumber, int secondNumber)
        {
            return StorageHelper.GetResultFromStorage(firstNumber, secondNumber);
        }
    }
}