using System.Collections.Generic;
using GamesApp.ViewModels;
using GamesApp.Services.Dto;

namespace GamesApp.Services
{
    public interface IGamesService
    {
        GamesDto GetGame(int id);
        IEnumerable<GamesDto> GetAllGames();
        GamesDto UpdateGame(GamesDto gamesDto);
        GamesDto AddGame(GamesDto gameDto);
        GamesDto DeleteGame(int id);
    }
}