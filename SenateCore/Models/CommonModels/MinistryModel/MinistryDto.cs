using SenateData.DataModels.Common;

namespace SenateCore.Models.CommonModels.MinistryModel
{
    public class MinistryDto: BaseMinistryDto
    {
        public int Id { get; set; }
        public int IsFederelMinistry { get; set; }
        public int IsStateMinistry { get; set; }
        public IList<MinistryDivision> MinistryDivisions { get; set; }
    }
}
