using SenateCore.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateCore.Utils
{
    public class CommonUtilities:ICommonUtilities
    {
        public string GetAPIUrl()
        {
            return "http://localhost:5123";
        }
    }
}
