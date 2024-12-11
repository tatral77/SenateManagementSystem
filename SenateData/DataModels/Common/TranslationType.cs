using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateData.DataModels.Common
{
    public class TranslationType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
