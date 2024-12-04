namespace SenateData.DataModels.Common
{
    public class ProvinceDivision
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int ProvinceId { get; set; }
        public Province Province { get; set; }
        public IList<District> Districts { get; set; }
    }
}
