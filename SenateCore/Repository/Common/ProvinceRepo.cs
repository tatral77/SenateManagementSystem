using AutoMapper;
using SenateCore.Contracts.Common;
using SenateData.DataModels;
using SenateData.DataModels.Common;
namespace SenateCore.Repository.Common
{
    public class ProvinceRepo: GenericRepo<Province>, IProvinceRepo
    {
        private readonly SenateDBContext _context;
        private readonly IMapper _mapper;

        public ProvinceRepo(SenateDBContext context, IMapper mapper) : base(context, mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
    }
}
