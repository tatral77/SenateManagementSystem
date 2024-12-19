using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenateData.DataModels.Common
{
    public class CourseType
    {
        [Table(nameof(CourseType), Schema = "HRM")]
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
