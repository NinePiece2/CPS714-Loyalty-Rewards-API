using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CPS714_Loyalty_Rewards_API.Models;
using CPS714_Loyalty_Rewards_API.Models.Tables;
using CPS714_Loyalty_Rewards_API.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            var topics = _loyaltyRewardsDbContext.FeedbackFormTopics.Select(x => x.Topic).ToList();
            return Ok(topics);
        }

        [HttpPost]
        [Route("SubmitSurvey")]
        public IActionResult SubmitSurvey([FromBody] SurveyDataModel surveyData)
        {
            if (surveyData == null)
            {
                return BadRequest("Invalid data.");
            }

            try
            {

                var newEntry = new SurveyData
                {
                    Name = surveyData.Name,
                    DateOfBirth = $"{surveyData.DayOB}/{surveyData.MonthOB}/{surveyData.YearOB}",
                    CivilStatus = surveyData.CivilStatus,
                    Gender = surveyData.Gender ?? surveyData.Gender_NotListed,
                    Address = $"{(string.IsNullOrWhiteSpace(surveyData.Address_Unit) ? "" : surveyData.Address_Unit + " ")}{surveyData.Address_StreetNo} {surveyData.Address_Street}, {surveyData.Address_Town}, {surveyData.Address_State}, {surveyData.Address_Zip}, {surveyData.Address_Country}".Trim(),
                    SatisfiedOverall = surveyData.Satasfied,
                    RecommendFleetRewards = surveyData.Recommend,
                    NavigateEasily = surveyData.Navigate,
                    ClearInstructions = surveyData.ClearInstructions,
                    SatisfiedWithRewards = surveyData.SatasfiedRewards,
                    QualityOfCustomerService = surveyData.Quality,
                    SatisfiedRedeemingRewards = surveyData.SatasfiedRedeeming,
                    SatisfiedCustomerResponseTeam = surveyData.SatasfiedResponse,
                    InformedOfLatestRewards = surveyData.Informed,
                    RoomForImprovement = surveyData.Improvement,
                    CreatedAt = DateTime.Now,
                    UserID = "1" // For testing, change when user authentication is implemented
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
    }
}
