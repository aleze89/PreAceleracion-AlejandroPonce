namespace PreAceleracionFebrero.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Image { get; set; }=null!;
        
        //TODO: relacion a Movies
        public ICollection<Character> Characters { get; set; }=new List<Character>();



    }
}
