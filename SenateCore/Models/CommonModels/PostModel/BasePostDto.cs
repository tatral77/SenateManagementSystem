using SenateData.DataModels.Common;

namespace SenateCore.Models.CommonModels.PostModel
{
    public class BasePostDto
    {
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int BPSFrom { get; set; }
        public int BPSTo { get; set; }
    }
}
