namespace SenateData.DataModels.Common
{
    public class Division
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int MinistriesId { get; set; }
        public string Ministry { get; set; }
        public bool IsActive { get; set; }
    }
}
