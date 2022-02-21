using System.ComponentModel.DataAnnotations;

namespace GamesApp.Models
{
    public  class Genres
    {
        [Key]
        public int GenreId { get; set; }
        
        public string GenreName { get; set; }
        
        
    }
}
