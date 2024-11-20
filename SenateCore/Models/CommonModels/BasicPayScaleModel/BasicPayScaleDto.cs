namespace SenateCore.Models.CommonModels.BasicPayScaleModel
{
    public class BasicPayScaleDto: BaseBasicPayScaleDto
    {
        public int Id { get; set; }
        public IList<EmployeeDto> Employees { get; set; }
    }
}
