namespace SenateData.DataModels.Resolution
{
    public class ResolutionSubmitter
    {
        public int ResolutionsSubmittersId { get; set; }
        public int ResolutionsId { get; set; }
        public int SystemUsersId { get; set; }
        public string MoverName { get; set; }
    }
}
