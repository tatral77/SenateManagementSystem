﻿using System.ComponentModel.DataAnnotations;

namespace SenateData.DataModels.Common
{
    public class ParliamentaryTenure
    {
        [Key]
        public int Id { get; set; }
        public string Tenure { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
