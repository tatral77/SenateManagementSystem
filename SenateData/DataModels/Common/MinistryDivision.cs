﻿namespace SenateData.DataModels.Common
{
    public class MinistryDivision
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int MinistryId { get; set; }
        public Ministry Ministry { get; set; }
        public bool IsActive { get; set; }
    }
}
