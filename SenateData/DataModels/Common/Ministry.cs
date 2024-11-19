namespace SenateData.DataModels.Common
{
    public class Ministry
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int IsFederelMinistry { get; set; }
        public int IsStateMinistry { get; set; }
        public IList<MinistryDivision> MinistryDivisions { get; set; }
    }
}
