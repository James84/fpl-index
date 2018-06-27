using AutoMapper;
using FantasyLeague.Domain;
using FantasyLeague.Models;

namespace FantasyLeague
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Team, TeamModel>();
            CreateMap<CurrentEventFixture, CurrentEventFixtureModel>();
            CreateMap<PlayerSummary, PlayerSummaryModel>();
            CreateMap<HistoryPast, HistoryPastModel>();
            CreateMap<ExplainCollection, ExplainCollectionModel>();
            CreateMap<History, HistoryModel>();
            CreateMap<Explain, ExplainModel>();
            CreateMap<Fixture, FixtureModel>();
            CreateMap<Minutes, MinutesModel>();
            CreateMap<Stat, StatModel>();
            CreateMap<Away, AwayModel>();

            CreateMap<Player, PlayerModel>()
                .ForMember(m => m.PlayerSummary, 
                           options => options.MapFrom(s => Mapper.Map<PlayerSummary, PlayerSummaryModel>(s.Summary)));
        }
    }
}
