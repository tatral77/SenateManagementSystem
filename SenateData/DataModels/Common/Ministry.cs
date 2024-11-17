namespace SenateData.DataModels.Common
{
    public class Ministry
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int IsFedMin { get; set; }
        public int IsStatMin { get; set; }
        public IList<MinistryDivision> MinistryDivisions { get; set; }
    }
}
