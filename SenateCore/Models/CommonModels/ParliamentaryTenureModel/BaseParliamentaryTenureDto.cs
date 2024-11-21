namespace SenateCore.Models.CommonModels.ParliamentaryTenureModel
{
    public class BaseParliamentaryTenureDto
    {
        public string Tenure { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
