using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenateData.DataModels.Ministries
{
    public class MinistryDivision
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        [ForeignKey(nameof(MinistryId))]
        public int MinistryId { get; set; }
        public Ministry Ministry { get; set; }
        public bool IsActive { get; set; }

        public IEnumeraDivisionDepartment MyProperty { get; set; }
    }
}
