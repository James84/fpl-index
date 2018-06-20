using AutoMapper;
using FantasyLeague.Domain;
using FantasyLeague.Models;

namespace FantasyLeague
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Player, PlayerModel>();
        }
    }
}
