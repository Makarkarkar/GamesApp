using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using GamesApp.Services;
using GamesApp.Services.Dto;
using GamesApp.ViewModels;
using Microsoft.AspNetCore.Mvc;



namespace GamesApp.Controllers
{
    [Route("api/genre")]
    [ApiController]
    public class GenreApiController:ControllerBase
    {
        private readonly IGenreService _service;

        public GenreApiController(IGenreService service)
        {
            _service = service;
        }

        [HttpGet] // GET: /api/genre
        [ProducesResponseType(200, Type = typeof(IEnumerable<GenreDto>))]  
        [ProducesResponseType(404)]
        public ActionResult<IEnumerable<GenreViewModel>> GetGenre()
        {
            return Ok(_service.GetAllGenres());
        }
        
        [HttpGet("{id}")] // GET: /api/genre
        [ProducesResponseType(200, Type = typeof(GenreViewModel))]  
        [ProducesResponseType(404)]
        public IActionResult GetById(int id)
        {
            var genre = _service.GetGenre(id);
            if (genre == null) return NotFound();  
            return Ok(genre);
        }
        
        
    }
}