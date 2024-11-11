namespace CPS714_Loyalty_Rewards_API.Models
{
    public class FeedbackFormDataModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Topic { get; set; }
        public string Explanation { get; set; }
    }

    public class SurveyDataModel
    {
        public string Name { get; set; }
        public string DayOB { get; set; }
        public string MonthOB { get; set; }
        public string YearOB { get; set; }
        public string? CivilStatus { get; set; }
        public string? Gender { get; set; }
        public string? Gender_NotListed { get; set; }
        public string? Address_Unit { get; set; }
        public string Address_StreetNo { get; set; }
        public string Address_Street { get; set; }
        public string Address_Town { get; set; }
        public string Address_State { get; set; }
        public string Address_Zip { get; set; }
        public string Address_Country { get; set; }
        public string Satasfied { get; set; }
        public string Recommend { get; set; }
        public string Navigate { get; set; }
        public string ClearInstructions { get; set; }
        public string SatasfiedRewards { get; set; }
        public string Quality { get; set; }
        public string SatasfiedRedeeming { get; set; }
        public string SatasfiedResponse { get; set; }
        public string Informed { get; set; }
        public string Improvement { get; set; }
    }


}
