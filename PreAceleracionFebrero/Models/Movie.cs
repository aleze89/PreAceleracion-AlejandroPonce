using System.ComponentModel.DataAnnotations;

namespace PreAceleracionFebrero.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }
        public int Rating { get; set; }
        //Todo:relacion con Character (Referencia)
        public ICollection<Character> Characters { get; set; } = new List<Character>();
        //Todo:relacion con Genre
        public Genre Genre { get; set; }
    }
}
