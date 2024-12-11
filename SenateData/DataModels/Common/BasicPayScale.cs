using SenateData.DataModels.HRM;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SenateData.DataModels.Common
{
    [Table(nameof(BasicPayScale), Schema = "HRM")]
    public class BasicPayScale
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Description { get; set; }
        public bool IsActive { get; set; }
        // public IList<Employee> Employees { get; set; }
    }
}
