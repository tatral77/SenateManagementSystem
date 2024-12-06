using SenateData.DataModels.Common;

namespace SenateCore.Models.CommonModels.PostModel
{
    public class PostDto: BasePostDto
    {
        public int Id { get; set; }
        public int NumberOfPosts { get; set; }
        public int EmployeePoolsId { get; set; }
        public int PostTypeId { get; set; }
        public int PostSubTypeId { get; set; }
        public int PostStatusId { get; set; }
        public EmployeePool EmployeePool { get; set; }
        public PostType PostType { get; set; }
        public PostSubType PostSubType { get; set; }
        //public IList<Employee> Employees { get; set; }
    }
}
