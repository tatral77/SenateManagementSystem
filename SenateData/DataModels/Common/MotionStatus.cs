using SenateData.DataModels.Motions;
using SenateData.DataModels.Questions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenateData.DataModels.Common

{
    [Table(nameof(MotionStatus), Schema = "Motion")]
    public class MotionStatus
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
        public bool IsActive { get; set; }
        //public IList<Motion> Motions { get; set; }
    }
}
