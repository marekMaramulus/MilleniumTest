using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;

namespace MilleniumTest.Controllers
{
    public abstract class MilleniumController : ControllerBase
    {
        protected IActionResult MapResult(ResultCodes code)
        {
            switch (code)
            {
                case ResultCodes.Success:
                    return NoContent();
                case ResultCodes.ItemNotFound:
                    return NotFound();
                case ResultCodes.CannotChangeStatusOfFinishedItem:
                    return BadRequest(ResultCodes.CannotChangeStatusOfFinishedItem);
                default: throw new NotImplementedException();
            }
        }
    }
}
