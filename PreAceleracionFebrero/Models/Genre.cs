namespace PreAceleracionFebrero.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        
        //TODO: relacion a Movies
        public ICollection<Character> Characters { get; set; }=new List<Character>();



    }
}
