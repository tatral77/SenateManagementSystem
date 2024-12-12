using SenateCore.Contracts.Common;
using SenateData.DataModels;
using SenateData.DataModels.Common;
namespace SenateCore.Repository.Common
{
    public class TranslationTypeRepo: GenericRepo<TranslationType>, ITranslationTypeRepo
    {
        private readonly SenateDBContext _context;
        private readonly IMapper _mapper;

        public TranslationTypeRepo(SenateDBContext context, IMapper mapper) : base(context, mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
    }
}
