﻿namespace SenateData.DataModels.Common
{
    public class District
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int ProvinceId { get; set; }
        public ProvinceDivision ProvinceDivision { get; set; }

    }
}
