using SenateData.DataModels.Legislation;
using System.ComponentModel.DataAnnotations;
namespace SenateData.DataModels.Common
{
    public class BillType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
        public bool IsActive { get; set; }
       // public IList<Bill> Bills { get; set; }
    }
}
