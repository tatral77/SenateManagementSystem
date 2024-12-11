using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SenateData.Common
{
    public class PenaltyType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
        public int IsMajor { get; set; }
        public int IsActive { get; set; }
    }
}
