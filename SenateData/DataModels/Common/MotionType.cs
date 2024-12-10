using SenateData.DataModels.Motions;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenateData.DataModels.Common
{
    [Table(nameof(MotionType), Schema = "Motion")]
    public class MotionType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int SortOrder { get; set; }
        //public IList<Motion> Motions { get; set; }
    }
}
