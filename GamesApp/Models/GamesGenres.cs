using System.ComponentModel.DataAnnotations.Schema;

namespace GamesApp.Models
{
    public  class GamesGenres
    {
        [ForeignKey("Genres")]
        public int GenreId { get; set; }
        public virtual Genres Genres { get; set; }
        [ForeignKey("Games")]
        public int GameId { get; set; }
        public virtual Games Games { get; set; }
    }
}
