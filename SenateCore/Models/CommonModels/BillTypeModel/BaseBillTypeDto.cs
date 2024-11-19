using SenateData.DataModels.Legislation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateCore.Models.CommonModels.BillTypeModel
{
    public class BaseBillTypeDto
    {
        public string Description { get; set; }
        public bool IsActive { get; set; }
      
    }
}
