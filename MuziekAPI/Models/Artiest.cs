namespace MuziekAPI.Models
{
    ///
    /// Representeert een artiest in de muziekbibliotheek.
    ///
    public class Artiest
    {
        ///
        /// De unieke identificatie van de artiest.
        ///
        public int Id { get; set; }
        ///
        /// De naam van de artiest of band.
        ///
        public string Naam { get; set; } = string.Empty;
        ///
        /// Het genre waarin de artiest primair actief is.
        ///
        public string Genre { get; set; } = string.Empty;
    }
}
