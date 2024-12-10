using SenateData.DataModels.Legislation;
using System.ComponentModel.DataAnnotations;
namespace SenateData.DataModels.Common
{
    public class BillStatus
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }
        public bool IsActive { get; set; }
       // public IList<Bill> Bills { get; set; }
    }
}
