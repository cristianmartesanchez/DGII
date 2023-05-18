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
    public class ContribuyenteController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ContribuyenteController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;   
        }


        [HttpGet("GetContribuyentes")]
        public ActionResult<IEnumerable<ContribuyentesDto>> Get()
        {
            var contribuyentes = _unitOfWork.Contribuyentes.GetContribuyentes();
            return Ok(contribuyentes);
        }


        [HttpGet("GetContribuyentes/{RncCedula}")]
        public ActionResult<ContribuyentesDto> Get(string RncCedula)
        {
            return Ok(_unitOfWork.Contribuyentes.GetContribuyente(RncCedula));
        }

       
        [HttpPost]
        public ActionResult<Contribuyentes> Post(ContribuyentesDto model)
        {

            var exit = _unitOfWork.Contribuyentes.GetAll()
                .FirstOrDefault(a => a.RncCedula == model.RncCedula);

            if(exit != null)
            {
                return Ok(exit);
            }

            var contribuyente = _mapper.Map<Contribuyentes>(model);
            contribuyente.Comprobantes = _mapper.Map<ICollection<Comprobantes>>(model.ComprobantesDtos);

            _unitOfWork.Contribuyentes.Add(contribuyente);
            _unitOfWork.Commit();

            return Ok(contribuyente);
        }

        // PUT api/<ContribuyenteController>/5
        [HttpPut("{RncCedula}")]
        public ActionResult<Contribuyentes> Put(ContribuyentesDto model)
        {
            var contribuyente = _mapper.Map<Contribuyentes>(_unitOfWork.Contribuyentes.GetContribuyente(model.RncCedula));

            if (contribuyente == null)
            {
                return NotFound();
            }

            contribuyente.Nombre = model.Nombre;
            contribuyente.TipoId = model.TipoId;
            contribuyente.status = model.status;

            _unitOfWork.Contribuyentes.Update(contribuyente);
            _unitOfWork.Commit();

            return Ok(contribuyente);
        }

        // DELETE api/<ContribuyenteController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string RncCedula)
        {
            var contribuyente = _unitOfWork.Contribuyentes.GetAll()
                .FirstOrDefault(a => a.RncCedula == RncCedula);

            if(contribuyente == null)
            {
                return NotFound();
            }

            contribuyente.status = !contribuyente.status;

            return Ok();
        }
    }
}
