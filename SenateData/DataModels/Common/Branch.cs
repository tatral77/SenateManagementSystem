using SenateData.DataModels.HRM;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SenateData.DataModels.Common
{
    [Table(nameof(Branch), Schema = "HRM")]
    public class Branch
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }
        public bool IsActive { get; set; }
      //  public IList<Employee> Employees { get; set; }
    }
}
