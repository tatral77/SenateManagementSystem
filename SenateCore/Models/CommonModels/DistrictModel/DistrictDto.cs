namespace SenateCore.Models.CommonModels.DistrictModel
{
    public class DistrictDto: BaseDistrictDto
    {
        public int Id { get; set; }
        public int ProvinceId { get; set; }
        public Province Province { get; set; }
    }
}
