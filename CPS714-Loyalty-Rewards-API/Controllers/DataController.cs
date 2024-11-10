using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CPS714_Loyalty_Rewards_API.Models;
using CPS714_Loyalty_Rewards_API.Models.Tables;
using CPS714_Loyalty_Rewards_API.Data;

namespace CPS714_Loyalty_Rewards_API.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly LoyaltyRewardsDbContext _loyaltyRewardsDbContext;
        public DataController(LoyaltyRewardsDbContext loyaltyRewardsDbContext)
        {
            _loyaltyRewardsDbContext = loyaltyRewardsDbContext;
        }

        [HttpPost]
        [Route("SubmitFeedbackFormData")]
        public IActionResult SubmitFeedbackFormData([FromBody] FeedbackFormDataModel data)
        {
            if (data == null)
            {
                return BadRequest("Invalid data.");
            }

            try
            {
                var newEntry = new FeedbackFormData
                {
                    Name = data.Name,
                    Email = data.Email,
                    PhoneNumber = data.PhoneNumber,
                    Topic = data.Topic,
                    Explanation = data.Explanation,
                    CreatedAt = DateTime.Now,
                    UserID = "1" // For testing needs to be changed when user authentication is implemented
                };

                _loyaltyRewardsDbContext.Add(newEntry);
                _loyaltyRewardsDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing the data: " + ex.ToString());
            }

            return Ok(new { message = "Success!" });
        }

        [HttpGet]
        [Route("GetFeedbackTopics")]
        public IActionResult GetFeedbackTopics()
        {
            //var topics = _loyaltyRewardsDbContext.FeedbackFormData.Select(x => x.Topic).Distinct().ToList();
            var topics = _loyaltyRewardsDbContext.FeedbackFormTopics.Select(x => x.Topic).ToList();
            //var topics = new List<string> { "Vehicular Product", "Vehicular Services", "Loyalty Program", "Other" };
            return Ok(topics);
        }
    }
}
