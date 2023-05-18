using AutoMapper;
using DGII.Domain.Entities;
using DGII.Domain.EntitiesDto;
using DGII.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DGII.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprobanteController : ControllerBase
    {

        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ComprobanteController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet("{RncCedula}")]
        public ActionResult<IEnumerable<ComprobantesDto>> Get(string RncCedula)
        {
            return Ok(_unitOfWork.Comprobantes.GetComprobantes(RncCedula));
        }

        [HttpGet("GetComprobante/{NCF}")]
        public ActionResult<ComprobantesDto> GetComprobante(string NCF)
        {
            return Ok(_unitOfWork.Comprobantes.GetComprobante(NCF));
        }

        [HttpPost]
        public ActionResult<ComprobantesDto> Post(ComprobantesDto model)
        {

            var exit = _unitOfWork.Comprobantes.GetComprobante(model.NCF, model.RncCedula);

            if(exit == null)
            {
                return BadRequest();
            }

            var comprobante = _mapper.Map<Comprobantes>(model);
            _unitOfWork.Comprobantes.Add(comprobante);
            _unitOfWork.Commit();

            return Ok(comprobante);

        }

    }
}
