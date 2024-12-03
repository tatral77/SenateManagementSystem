using AutoMapper;
using EstablishmentENT;
using SenateCore.Contracts.Common;
using SenateData.DataModels;
using SenateData.DataModels.Common;
namespace SenateCore.Repository.Common
{
    public class PhoneTypeRepo: GenericRepo<PhoneType>, IPhoneTypeRepo
    {
        private readonly SenateDBContext _context;
        private readonly IMapper _mapper;

        public PhoneTypeRepo(SenateDBContext context, IMapper mapper) : base(context, mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
    }
}
