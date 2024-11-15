using SenateData.DataModels.HRM;
namespace SenateData.DataModels.Common
{
    public class Branch
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public IList<Employee> Employees { get; set; }
    }
}
