using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CPS714_Loyalty_Rewards_API.Models.Tables
{
    public class SurveyData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string UserID { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CreatedAt { get; set; } = DateTime.Now;

        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string CivilStatus { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

        public string SatisfiedOverall { get; set; }
        public string RecommendFleetRewards { get; set; }
        public string NavigateEasily { get; set; }
        public string ClearInstructions { get; set; }
        public string SatisfiedWithRewards { get; set; }
        public string QualityOfCustomerService { get; set; }
        public string SatisfiedRedeemingRewards { get; set; }
        public string SatisfiedCustomerResponseTeam { get; set; }
        public string InformedOfLatestRewards { get; set; }
        public string RoomForImprovement { get; set; }
    }
}
