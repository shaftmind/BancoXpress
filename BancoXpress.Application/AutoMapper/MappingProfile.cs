using AutoMapper;
using BancoXpress.Application.Models;
using BancoXpress.Domain.Entities.Client;

namespace BancoXpress.Application.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ClientModel, ClientEntity>();
            CreateMap<SaveClientModel, ClientEntity>();
        }
    }
}
