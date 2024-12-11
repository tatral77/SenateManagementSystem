using System.ComponentModel.DataAnnotations;

namespace SenateData.DataModels.Common
{
    public class MaritalStatus
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public IList<SenateUser> SenateUser { get; set; }

    }

}
