using SenateCore.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateCore.Services
{
    public class CommonUtils : ICommonUtils
    {
        public string GetAPIUrl()
        {
            return "http://localhost:5123";
        }
    }
}
