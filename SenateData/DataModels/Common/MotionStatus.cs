using SenateData.DataModels.Motions;
using SenateData.DataModels.Questions;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenateData.DataModels.Common

{
    [Table(nameof(MotionStatus), Schema = "Motion")]
    public class MotionStatus
    {
        public int Id { get; set; }
        public string Description { get; set; }
        //public IList<Motion> Motions { get; set; }
        public bool IsActive { get; set; }
    }
}
