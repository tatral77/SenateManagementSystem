using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SenateData.DataModels.Common
{
    [Table(nameof(ContractType), Schema = "HRM")]
    public class ContractType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Description { get; set; }
    }
}
