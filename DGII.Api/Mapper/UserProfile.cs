using AutoMapper;
using DGII.Domain.Entities;
using DGII.Domain.EntitiesDto;

namespace DGII.Api.Mapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
 
            CreateMap<Contribuyentes, ContribuyentesDto>();
            CreateMap<Comprobantes, ComprobantesDto>();

            CreateMap<ContribuyentesDto, Contribuyentes>();
            CreateMap<ComprobantesDto, Comprobantes>();
        }
    }
}
