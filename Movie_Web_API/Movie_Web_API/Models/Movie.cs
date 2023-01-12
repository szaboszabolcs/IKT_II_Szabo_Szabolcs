namespace Movie_Web_API.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }   // ? - Felvehet 0 értéket //
        public string? Genre { get; set; }  // ? - Felvehet 0 értéket //
        public DateTime ReleaseDate { get; set; }


    }
}
