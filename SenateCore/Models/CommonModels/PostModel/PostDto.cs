namespace SenateCore.Models.CommonModels.PostModel
{
    public class PostDto: BasePostDto
    {
        public int Id { get; set; }
        public IList<Employee> Employees { get; set; }
    }
}
