// GolBet.Services/Mapping/MappingProfile.cs 

using AutoMapper;
using Golbet.Entities;
using GolBet.Services.DTOs;



namespace GolBet.Services.Mapping;



public class MappingProfile : Profile

{

    public MappingProfile()

    {
<<<<<<< HEAD
        CreateMap<Team, TeamDto>();

        CreateMap<TeamFormDto, Team>().ReverseMap();

        CreateMap<MatchFormDto, Match>().ReverseMap();
=======
>>>>>>> 53a65f7dd7c72ed2cb967c3babcb4e01c8c93833

        // Flattening by convention: 

        // MatchDto.HomeTeamName  <- Match.HomeTeam.Name 

        // MatchDto.AwayTeamCrestUrl <- Match.AwayTeam.CrestUrl 

        CreateMap<Match, MatchDto>();

        CreateMap<Match, MatchDetailDto>()

            .ForMember(dto => dto.TotalBets,

                       options => options.MapFrom(match => match.Bets.Count));

    }

}