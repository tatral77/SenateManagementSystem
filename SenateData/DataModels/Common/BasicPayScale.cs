using SenateData.DataModels.HRM;
namespace SenateData.DataModels.Common
{
    public class BasicPayScale
    {
        public int Id { get; set; }
        public int Description { get; set; }
        public bool IsActive { get; set; }
        public IList<Employee> Employees { get; set; }
    }
}
