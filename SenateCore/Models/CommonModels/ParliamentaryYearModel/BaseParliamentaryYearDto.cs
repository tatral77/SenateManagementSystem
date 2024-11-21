using SenateData.DataModels.Common;

namespace SenateCore.Models.CommonModels.ParliamentaryYearModel
{
    public class BaseParliamentaryYearDto
    {
        public string Year { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TermId { get; set; }
    }
}
