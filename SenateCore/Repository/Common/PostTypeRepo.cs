using AutoMapper;
using SenateCore.Contracts.Common;
using SenateData.DataModels;
using SenateData.DataModels.Common;
namespace SenateCore.Repository.Common
{
    public class PostTypeRepo : GenericRepo<PostType>, IPostTypeRepo
    {
        private readonly SenateDBContext _context;
        private readonly IMapper _mapper;

        public PostTypeRepo(SenateDBContext context, IMapper mapper) : base(context, mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
    }
}
