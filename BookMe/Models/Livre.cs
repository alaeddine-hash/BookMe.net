using System.ComponentModel.DataAnnotations;

namespace BookMe.Models
{
    public class Livre
    {
        [Key]
        public int LivreId { get; set; }
        public string? Name { get; set; }

        public string? Language { get; set; }
        public int pagesNumbers { get; set; }

        public string? ImagePath { get; set; }
        public string? Description { get; set; }
        public ICollection<AuteurLivre>? AuteurLivres { get; set; }  
        public ICollection<Copie>? Copies { get; set; }  

        public ICollection<LivreTheme>? LivreThemes { get; set; }





    }
}
