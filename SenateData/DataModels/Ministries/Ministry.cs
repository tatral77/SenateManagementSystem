using System.ComponentModel.DataAnnotations;

namespace SenateData.DataModels.Ministries
{
    public class Ministry
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int IsFederelMinistry { get; set; }
        public int IsStateMinistry { get; set; }
        public IList<MinistryDivision> MinistryDivisions { get; set; }
    }
}
