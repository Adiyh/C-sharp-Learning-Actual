using Microsoft.AspNetCore.Mvc;
using CalculatorAPI.Models;

namespace CalculatorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpPost("calculate")]
        public IActionResult Calculate([FromBody] CalculatorInput input)
        {
            double result;

            switch (input.Op)
            {
                case "+": result = input.Num1 + input.Num2; break;
                case "-": result = input.Num1 - input.Num2; break;
                case "*": result = input.Num1 * input.Num2; break;
                case "/":
                    if (input.Num2 == 0)
                        return BadRequest("Cannot divide by zero.");
                    result = input.Num1 / input.Num2;
                    break;
                default:
                    return BadRequest("Invalid operator.");
            }

            return Ok(new { Result = result });
        }
    }
}
