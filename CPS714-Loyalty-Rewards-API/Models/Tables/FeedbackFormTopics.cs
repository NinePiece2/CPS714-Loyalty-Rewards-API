using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPS714_Loyalty_Rewards_API.Models.Tables
{
    public class FeedbackFormTopics
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UID { get; set; }

        [Required]
        [MaxLength(250)]
        public string Topic { get; set; }
    }
}
