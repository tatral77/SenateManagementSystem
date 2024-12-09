using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using SenateCore.Contracts.Common;
using SenateCore.Exceptions;
using SenateCore.Models.CommonModels.BasicPayScaleModel;

namespace SenateCoreAPI.Controllers.Common
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicPayScaleController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IBasicPayScaleRepo _IBasicPayScaleRepo;
        private readonly ILogger<BasicPayScaleController> _logger;

        public BasicPayScaleController(IMapper mapper, IBasicPayScaleRepo BasicPayScaleRepo, ILogger<BasicPayScaleController> logger)
        {
            _mapper = mapper;
            this._IBasicPayScaleRepo = BasicPayScaleRepo;
            this._logger = logger;
        }

        // GET: api/BasicPayScales
        [HttpGet]
        [EnableQuery]
        public async Task<ActionResult<IEnumerable<GetBasicPayScaleDto>>> GetBasicPayScales()
        {
            var BasicPayScales = await _IBasicPayScaleRepo.GetAllAsync<GetBasicPayScaleDto>();
            // var records = _mapper.Map<List<GetBasicPayScaleDto>>(BasicPayScales);
            return Ok(BasicPayScales);
        }

        // GET: api/BasicPayScales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BasicPayScaleDto>> GetBasicPayScale(int id)
        {
            //var BasicPayScale = await _context.BasicPayScales.FindAsync(id);
            var BasicPayScale = await _IBasicPayScaleRepo.GetAsync(id);

            //if (BasicPayScale == null)
            //{
            //    throw new NotFoundException(nameof(GetBasicPayScale), id);
            //}
            // var records = _mapper.Map<BasicPayScaleDto>(BasicPayScale);
            return Ok(BasicPayScale);
        }

        // PUT: api/BasicPayScales/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBasicPayScale(int id, UpdateBasicPayScaleDto updateBasicPayScaleDto)
        {
            if (id != updateBasicPayScaleDto.Id)
            {
                return BadRequest();
            }
            var BasicPayScale = await _IBasicPayScaleRepo.GetAsync(id);
            if (BasicPayScale == null)
            {
                throw new NotFoundException(nameof(PutBasicPayScale), id);
            }
            //_context.Entry(BasicPayScale).State = EntityState.Modified;
            _mapper.Map(updateBasicPayScaleDto, BasicPayScale);
            await _IBasicPayScaleRepo.UpdateAsync(BasicPayScale);
            if (!await BasicPayScaleExists(id))
            {
                throw new NotFoundException(nameof(PutBasicPayScale), id);
            }
            return NoContent();
        }

        // POST: api/BasicPayScales
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GetBasicPayScaleDto>> PostBasicPayScale(CreateBasicPayScaleDto BasicPayScaleDto)
        {
            //  var BasicPayScale = _mapper.Map<BasicPayScale>(BasicPayScaleDto);
            var BasicPayScale = await _IBasicPayScaleRepo.AddAsync<CreateBasicPayScaleDto, GetBasicPayScaleDto>(BasicPayScaleDto);
            return CreatedAtAction(nameof(GetBasicPayScale), new { id = BasicPayScale.Id }, BasicPayScale);
        }

        // DELETE: api/BasicPayScales/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBasicPayScale(int id)
        {
            await _IBasicPayScaleRepo.DeleteAsync(id);
            return NoContent();
        }
        private async Task<bool> BasicPayScaleExists(int id)
        {
            return await _IBasicPayScaleRepo.Exists(id);
        }
    }
}
