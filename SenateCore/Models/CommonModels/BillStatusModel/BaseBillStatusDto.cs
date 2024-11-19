using SenateData.DataModels.Legislation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateCore.Models.CommonModels.BillStatusModel
{
    public class BaseBillStatusDto
    {
      
        public string Description { get; set; }
        public bool IsActive { get; set; }
       
    }
}
