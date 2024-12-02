using AutoMapper;
using SenateCore.Contracts;
using SenateCore.Contracts.Common;
using SenateData.DataModels;
using SenateData.DataModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateCore.Repository.Common
{
    public class BasicPayScaleRepo : GenericRepo<BasicPayScale>, IBasicPayScaleRepo
    {
        private readonly SenateDBContext _context;
        private readonly IMapper _mapper;

        public BasicPayScaleRepo(SenateDBContext context, IMapper mapper) : base(context, mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        //public async Task<BasicPayScale> GetDetails(int id)
        //{
        //    var bookingDocument = await _context.BasicPayScales.Include(q => q.Booking)
        //         .FirstOrDefaultAsync(q => q.Id == id);
        //    return _mapper.Map<BookingDocumentDto>(bookingDocument);

        //}

    }
}
