using AutoMapper;
using UBEntities.DTO;
using UBEntities.Models;

namespace UBServer
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Owner, OwnerDto>();
            CreateMap<Account, AccountDto>();
        }
    }
}
