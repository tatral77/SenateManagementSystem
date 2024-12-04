using SenateData.DataModels.Legislation;
namespace SenateData.DataModels.Common
{
    public class BillOrigin
    {
        public int Id { get; set; }
        public int Description { get; set; }
        public bool IsActive { get; set; }
     //   public IList<Bill> Bills { get; set; }
    }
}
