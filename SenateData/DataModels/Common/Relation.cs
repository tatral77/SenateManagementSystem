using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenateData.DataModels.Common
{
    public class Relation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Description { get; set; }

        [ForeignKey(nameof(GenderId))]
        public int GenderId { get; set; }
        public string Gender { get; set; }
        public int SortOrder { get; set; }
    }
}
