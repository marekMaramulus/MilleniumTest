using Microsoft.AspNetCore.Mvc;

namespace MilleniumTest
{
    public class ErrorCodeMapper
    {
        public IActionResult MapResult(ResultCodes code)
        {
            switch (code)
            {
                case ResultCodes.Success: return  = 0,
                ItemNotFound = 1,
                CannotChangeStatusOfFinishedItem = 2
            }
        }
    }
}
