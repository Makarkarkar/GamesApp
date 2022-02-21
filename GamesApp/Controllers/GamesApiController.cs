using System.Collections.Generic;
using GamesApp.Services;
using GamesApp.Services.Dto;
using GamesApp.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace GamesApp.Controllers
{
    [Route("api/games")]
    [ApiController]
    public class GamesApiController:ControllerBase
    {
        private readonly IGamesService _service;

        public GamesApiController(IGamesService service)
        {
            _service = service;
        }

        [HttpGet] // GET: /api/games
        [ProducesResponseType(200, Type = typeof(IEnumerable<GamesViewModel>))]  
        [ProducesResponseType(404)]
        public ActionResult<IEnumerable<GamesViewModel>> GetGame()
        {
            return Ok(_service.GetAllGames());
        }
        
        [HttpGet("{id}")] // GET: /api/games/5
        [ProducesResponseType(200, Type = typeof(GamesViewModel))]  
        [ProducesResponseType(404)]
        public IActionResult GetById(int id)
        {
            var game = _service.GetGame(id);
            if (game == null) return NotFound();  
            return Ok(game);
        }
        
        [HttpPost] // POST: api/games
        public ActionResult<GamesViewModel> PostGame(GamesDto inputDto)
        {
            var game = _service.AddGame(inputDto);
            return CreatedAtAction("GetById", new { id = game.GameId }, game);
        }
        
        [HttpPut("{id}")] // PUT: api/games/5
        public IActionResult UpdateGame(int id, GamesDto editDto)
        {
            var game = _service.UpdateGame(editDto);

            if (game==null)
            {
                return BadRequest();
            }

            return Ok(game);
        }
        
        [HttpDelete("{id}")] // DELETE: api/games/5
        public ActionResult<GamesViewModel> DeleteGame(int id)
        {
            var game = _service.DeleteGame(id);
            if (game == null) return NotFound();  
            return Ok(game);
        }

        
    }
}