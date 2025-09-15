
    using MuziekAPI.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    namespace MuziekAPI.Data // Pas dit aan naar de namespace van je project
    {
        public static class InMemoryMusicRepository
        {
            public static List<Artiest> Artiesten { get; private set; }
            public static List<Album> Albums { get; private set; }
            public static List<Nummer> Nummers { get; private set; }
            static InMemoryMusicRepository()
            {
                // Echte artiesten
                Artiesten = new()
{
new Artiest { Id = 1, Naam = "Queen", Genre = "Rock" },
new Artiest { Id = 2, Naam = "Michael Jackson", Genre = "Pop" },
new Artiest { Id = 3, Naam = "Adele", Genre = "Soul" },
new Artiest { Id = 4, Naam = "Kendrick Lamar", Genre = "Hip Hop" },
new Artiest { Id = 5, Naam = "The Beatles", Genre = "Rock" },
new Artiest { Id = 6, Naam = "Rihanna", Genre = "Pop" },
new Artiest { Id = 7, Naam = "David Bowie", Genre = "Rock" }
};
                // Echte albums
                Albums = new()
{
new Album { Id = 101, Titel = "A Night at the Opera", Publicatiejaar = 1975, ArtiestId = 1 }, // Queen
new Album { Id = 102, Titel = "Thriller", Publicatiejaar = 1982, ArtiestId = 2 }, // Michael Jackson
new Album { Id = 103, Titel = "21", Publicatiejaar = 2011, ArtiestId = 3 }, // Adele
new Album { Id = 104, Titel = "DAMN.", Publicatiejaar = 2017, ArtiestId = 4 }, // Kendrick Lamar
new Album { Id = 105, Titel = "Abbey Road", Publicatiejaar = 1969, ArtiestId = 5 }, // The Beatles
new Album { Id = 106, Titel = "ANTI", Publicatiejaar = 2016, ArtiestId = 6 }, // Rihanna
new Album { Id = 107, Titel = "Bohemian Rhapsody (Single)", Publicatiejaar = 1975, ArtiestId = 1 } // Voor enkel nummer voorbeeld
};
                // Echte nummers
                Nummers = new()
{
new Nummer { Id = 1001, Titel = "Bohemian Rhapsody", DuurInSeconden = 354, AlbumId = 101 }, // Queen
new Nummer { Id = 1002, Titel = "Killer Queen", DuurInSeconden = 180, AlbumId = 101 }, // Queen
new Nummer { Id = 1003, Titel = "Billie Jean", DuurInSeconden = 254, AlbumId = 102 }, // Michael Jackson
new Nummer { Id = 1004, Titel = "Beat It", DuurInSeconden = 258, AlbumId = 102 }, // Michael Jackson
new Nummer { Id = 1005, Titel = "Rolling in the Deep", DuurInSeconden = 228, AlbumId = 103 }, // Adele
new Nummer { Id = 1006, Titel = "Someone Like You", DuurInSeconden = 285, AlbumId = 103 }, // Adele
new Nummer { Id = 1007, Titel = "HUMBLE.", DuurInSeconden = 177, AlbumId = 104 }, // Kendrick Lamar
new Nummer { Id = 1008, Titel = "Come Together", DuurInSeconden = 259, AlbumId = 105 }, // The Beatles
new Nummer { Id = 1009, Titel = "Work", DuurInSeconden = 219, AlbumId = 106,
SamenwerkendeArtiestIds = new () { 4 } }, // Rihanna ft. Drake (Drake is ArtiestId 4 in dit voorbeeld) - **LET OP: Drake is niet ArtiestId 4 in onze lijst, dit zou Kendrick Lamar zijn. Pas ID aan of voeg Drake toe!**
new Nummer { Id = 1010, Titel = "We Are The Champions", DuurInSeconden = 179, AlbumId = 101 }, // Queen
new Nummer { Id = 1011, Titel = "Hotel California", DuurInSeconden = 390, AlbumId = 0 }, // Voorbeeld zonder album (of AlbumId naar bestaand album linken)
new Nummer { Id = 1012, Titel = "Space Oddity", DuurInSeconden = 300, AlbumId = 0,
SamenwerkendeArtiestIds = new () { 7 } } // David Bowie (ArtiestId 7)
};
            }
            // Helper methodes (studenten kunnen deze uitbreiden)
            public static Artiest? GetArtiestById(int id)
            {
                return Artiesten.FirstOrDefault(a => a.Id == id);
            }
            public static Album? GetAlbumById(int id)
            {
                return Albums.FirstOrDefault(a => a.Id == id);
            }
            public static Nummer? GetNummerById(int id)
            {
                return Nummers.FirstOrDefault(n => n.Id == id);
            }
        }
    }

