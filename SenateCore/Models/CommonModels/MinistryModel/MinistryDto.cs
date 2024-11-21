using SenateData.DataModels.Common;

namespace SenateCore.Models.CommonModels.MinistryModel
{
<<<<<<< HEAD
    public class MinistryDto: BaseMinistryDto
=======
    public class MinistryDto
>>>>>>> 7066553944da5b9dcedd5b6e90b2f32be78e8468
    {
        public int Id { get; set; }
        public int IsFederelMinistry { get; set; }
        public int IsStateMinistry { get; set; }
        public IList<MinistryDivision> MinistryDivisions { get; set; }
    }
}
