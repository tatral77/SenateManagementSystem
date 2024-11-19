using SenateData.DataModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateCore.Models.CommonModels.CityModel
{
    public class BaseCityDto
    {
        public string Description { get; set; }
        public int CountryId { get; set; }
        public bool IsActive { get; set; }
    }
}
