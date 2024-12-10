using SenateData.DataModels.Legislation;
using System.ComponentModel.DataAnnotations;
namespace SenateData.DataModels.Common
{
    public class BillOrigin
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(25)]
        public string Description { get; set; }
        public bool IsActive { get; set; }
     //   public IList<Bill> Bills { get; set; }
    }
}
