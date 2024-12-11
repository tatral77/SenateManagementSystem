using AutoMapper;
using SenateCore.Contracts.Common;
using SenateData.DataModels;
using SenateData.DataModels.Ministries;
namespace SenateCore.Repository.Common
{
    public class DivisionRepo : GenericRepo<MinistryDivision>, IDivisionRepo
    {
        private readonly SenateDBContext _context;
        private readonly IMapper _mapper;

        public DivisionRepo(SenateDBContext context, IMapper mapper) : base(context, mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
    }
}
