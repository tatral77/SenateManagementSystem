namespace SenateCore.Models.CommonModels.ParliamentaryTermModel
{
    public class ParliamentaryTermDto: BaseParliamentaryTermDto
    {
        public int Id { get; set; }
        public int TenureId { get; set; }
        public ParliamentaryTenure ParliamentaryTenure { get; set; }
    }
}
