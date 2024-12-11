using System.ComponentModel.DataAnnotations;

namespace SenateData.DataModels.Common
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(15)]
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public IList<SenateUser> SenateUsers { get; set; }
    }
}
