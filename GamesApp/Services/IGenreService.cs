using System.Collections.Generic;
using GamesApp.Services.Dto;

namespace GamesApp.Services
{
    public interface IGenreService
    {
        GenreDto GetGenre(int id);
        IEnumerable<GenreDto> GetAllGenres();
        
    }
}