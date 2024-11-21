using SenateData.DataModels.Common;
<<<<<<< HEAD

namespace SenateCore.Models.CommonModels.MaritalStatusModel
{
    public class MaritalStatusDto: BaseMaritalStatusDto
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateCore.Models.CommonModels.MaritalStatusModel
{
    public class MaritalStatusDto:BaseMaritalStatusDto
>>>>>>> 7066553944da5b9dcedd5b6e90b2f32be78e8468
    {
        public int Id { get; set; }
        public IList<SenateUserDto> SenateUser { get; set; }
    }
}
