namespace MuziekAPI.Models
{
    /// <summary>
    /// Representeert een album in de muziekbibliotheek.
    /// </summary>
    public class Album
    {
        /// <summary>
        /// De unieke identificatie van het album.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// De titel van het album.
        /// </summary>
        public string Titel { get; set; } = string.Empty;
        /// <summary>
        /// Het publicatiejaar van het album.
        /// </summary>
        public int Publicatiejaar { get; set; }
        /// <summary>
        /// De ID van de primaire artiest van het album.
        /// </summary>
        public int ArtiestId { get; set; }
        // Optioneel: Navigatie property naar Artiest object
        // public Artiest? Artiest { get; set; }
    }
}
