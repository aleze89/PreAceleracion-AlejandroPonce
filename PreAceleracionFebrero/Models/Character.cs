namespace PreAceleracionFebrero.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Image { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public float Weight { get; set; }
        public string History { get; set; } = null!;
        //Todo:relacion con Movie (Colections) --new List<Movie>(); vacio pero no nulo
        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}
