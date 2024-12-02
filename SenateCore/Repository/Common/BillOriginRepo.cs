using AutoMapper;
using SenateCore.Contracts.Common;
using SenateData.DataModels.Common;
using SenateData.DataModels;
namespace SenateCore.Repository.Common
{
    public class BillOriginRepo : GenericRepo<BillOrigin>, IBillOriginRepo
    {
        private readonly SenateDBContext _context;
        private readonly IMapper _mapper;

        public BillOriginRepo(SenateDBContext context, IMapper mapper) : base(context, mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
    }
}
