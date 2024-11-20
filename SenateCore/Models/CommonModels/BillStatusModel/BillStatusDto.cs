namespace SenateCore.Models.CommonModels.BillStatusModel
{
    public class BillStatusDto:BaseBillStatusDto
    {
        public int Id { get; set; }
        public IList<BillDto> Bills { get; set; }
    }
}
