using CPS714_Loyalty_Rewards_API.Data;
using CPS714_Loyalty_Rewards_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CPS714_Loyalty_Rewards_API.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly LoyaltyRewardsDbContext _loyaltyRewardsDbContext;
        private readonly ITokenService _tokenService;

        public TokenController(LoyaltyRewardsDbContext loyaltyRewardsDbContext, ITokenService tokenService)
        {
            _loyaltyRewardsDbContext = loyaltyRewardsDbContext;
            _tokenService = tokenService;
        }

        [HttpGet]
        [Route("GetToken")]
        public IActionResult GetToken(string userId)
        {
            try
            {
                //var uriDecodedUserId = System.Web.HttpUtility.UrlDecode(userId);
                var token = _tokenService.GenerateToken(userId);
                return Ok(token);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}