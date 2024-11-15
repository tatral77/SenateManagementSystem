namespace SenateData.DataModels.Common
{
    public class ResolutionType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int BranchesId { get; set; }

    }
}
