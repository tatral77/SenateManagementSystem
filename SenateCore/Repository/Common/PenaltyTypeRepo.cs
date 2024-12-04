using AutoMapper;
using EstablishmentENT;
using SenateCore.Contracts.Common;
using SenateData.Common;
using SenateData.DataModels;
using SenateData.DataModels.Common;
namespace SenateCore.Repository.Common
{
    public class PenaltyTypeRepo : GenericRepo<PenaltyType>, IPenaltyTypeRepo
    {
        private readonly SenateDBContext _context;
        private readonly IMapper _mapper;

        public PenaltyTypeRepo(SenateDBContext context, IMapper mapper) : base(context, mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
    }
}
