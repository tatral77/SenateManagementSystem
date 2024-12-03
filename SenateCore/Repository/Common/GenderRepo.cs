using AutoMapper;
using SenateCore.Contracts.Common;
using SenateData.DataModels;
using SenateData.DataModels.Common;
namespace SenateCore.Repository.Common
{
    public class GenderRepo: GenericRepo<Gender>, IGenderRepo
    {
        private readonly SenateDBContext _context;
        private readonly IMapper _mapper;

        public GenderRepo(SenateDBContext context, IMapper mapper) : base(context, mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
    }
}
