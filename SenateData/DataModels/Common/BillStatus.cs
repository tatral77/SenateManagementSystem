using SenateData.DataModels.Legislation;
namespace SenateData.DataModels.Common
{
    public class BillStatus
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
       // public IList<Bill> Bills { get; set; }
    }
}
