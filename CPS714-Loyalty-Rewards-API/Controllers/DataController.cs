using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CPS714_Loyalty_Rewards_API.Models;

namespace CPS714_Loyalty_Rewards_API.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpPost]
        [Route("SubmitFeedbackFormData")]
        public IActionResult SubmitFeedbackFormData([FromBody] FeedbackFormDataModel data)
        {
            if (data == null)
            {
                return BadRequest("Invalid data.");
            }

            

            return Ok(new { message = "Data received successfully!" });
        }
    }
}
