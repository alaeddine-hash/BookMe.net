namespace BookMe.Models
{
    public class LivreThemeViewModel
    {
        public IEnumerable<BookMe.Models.Livre> Livres { get; set; }
        public IEnumerable<BookMe.Models.Theme> Themes { get; set; }
    }
}
