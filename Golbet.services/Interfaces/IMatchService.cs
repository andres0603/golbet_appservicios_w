// GolBet.Services/Interfaces/IMatchService.cs 

using Golbet.Entities.Enums;

using GolBet.Services.DTOs;



namespace GolBet.Services.Interfaces;



public interface IMatchService

{

    /// <summary>Match board: all active matches ordered by date.</summary> 

    Task<IEnumerable<MatchDto>> GetBoardAsync(MatchStatus? status = null);
    Task<MatchDetailDto?> GetDetailAsync(int id);
<<<<<<< HEAD
    Task<MatchFormDto?> GetForEditAsync(int id);

    Task CreateAsync(MatchFormDto dto);

    Task UpdateAsync(MatchFormDto dto);

    Task DeactivateAsync(int id);
=======
>>>>>>> 53a65f7dd7c72ed2cb967c3babcb4e01c8c93833
}