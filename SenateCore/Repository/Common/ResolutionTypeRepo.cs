using AutoMapper;
using SenateCore.Contracts.Common;
using SenateData.DataModels;
using SenateData.DataModels.Common;
namespace SenateCore.Repository.Common
{
    public class ResolutionTypeRepo: GenericRepo<ResolutionType>, IResolutionTypeRepo
    {
        private readonly SenateDBContext _context;
        private readonly IMapper _mapper;

        public ResolutionTypeRepo(SenateDBContext context, IMapper mapper) : base(context, mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
    }
}
