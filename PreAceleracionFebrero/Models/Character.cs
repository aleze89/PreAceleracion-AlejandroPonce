namespace PreAceleracionFebrero.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }
        public string History { get; set; }
        //Todo:relacion con Movie (Colections) --new List<Movie>(); vacio pero no nulo
        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}
