using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using GamesApp.Data;
using GamesApp.Models;
using GamesApp.ViewModels;
using GamesApp.Services.Dto;

namespace GamesApp.Services
{
    public class GamesService:IGamesService
    {
        private readonly GamesContext _context;
        private readonly IMapper _mapper;
        
        public GamesService(GamesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        public GamesDto GetGame(int id)
        {
            var game =  _mapper.Map<GamesDto>(_context.Games.FirstOrDefault(m => m.GameId == id));
            if (game == null) return null;
            game.Genres = _context.GamesGenres.Where(ge => ge.GameId == game.GameId).Select(ge => ge.Genres).ToList();
            // genre.AllGames = _context.Games.ToList();
            return game;
        }

        public IEnumerable<GamesDto> GetAllGames()
        {
            var games =  _mapper.Map<IEnumerable<Games>, IEnumerable<GamesDto>>(_context.Games.ToList()).ToList();
            foreach (var game in games)
            {
                game.Genres = _context.GamesGenres.Where(ge => ge.GameId == game.GameId).Select(ge => ge.Genres).ToList();
            }
            
            return games;
        }

        public GamesDto UpdateGame(GamesDto gameDto)
        {
            if (gameDto.GameId == null)
            {
                
            }
            
            try
            {
                var game = _mapper.Map<Games>(gameDto);
                
                _context.Update(game);
                _context.SaveChanges();
                
                return _mapper.Map<GamesDto>(game);
            }
            catch (DbUpdateException)
            {
                if (!GamesExists((int) gameDto.GameId))
                {
                    
                    return null;
                }
                else
                {
                    
                    return null;
                }
            }
        }

        public GamesDto AddGame(GamesDto gameDto)
        {
            var game = _context.Add((object) _mapper.Map<Games>(gameDto)).Entity;
            _context.SaveChanges();
            return _mapper.Map<GamesDto>(game);
        }

        public GamesDto DeleteGame(int id)
        {
            var game = _context.Games.Find(id);
            if (game == null)
            {
                
                return null;
            }

            _context.Games.Remove(game);
            _context.SaveChanges();
            
            return _mapper.Map<GamesDto>(game);
        }
        
        private bool GamesExists(int id)
        {
            return _context.Games.Any(e => e.GameId == id);
        }
    }
}