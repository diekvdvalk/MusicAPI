namespace MuziekAPI.Models
{
    /// <summary>
    /// Representeert een nummer in de muziekbibliotheek.
    /// </summary>
    public class Nummer
    {
        /// <summary>
        /// De unieke identificatie van het nummer.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// De titel van het nummer.
        /// </summary>
        public string Titel { get; set; } = string.Empty;
        /// <summary>
        /// De duur van het nummer in seconden.
        /// </summary>
        public int DuurInSeconden { get; set; }
        /// <summary>
        /// De ID van het album waartoe het nummer behoort.
        /// </summary>
        public int AlbumId { get; set; }
        // Optioneel: Navigatie property naar Album object
        // public Album? Album { get; set; }
        /// <summary>
        /// Een lijst van IDs van samenwerkende artiesten op dit nummer.
        /// </summary>
        public List<int> SamenwerkendeArtiestIds { get; set; } = new List<int>();
        // Optioneel: Navigatie property naar Artiest objecten voor samenwerkende artiesten
        // public List<Artiest> SamenwerkendeArtiesten { get; set; } = new List<Artiest>();
    }
}
