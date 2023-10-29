using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaWeb.Shared
{
    [Table("BOOK")]
    public class Book
    {
        [Column("ID")]
        [Required(ErrorMessage = "Brak Id")]
        public int ID { get; set; }
        [Column("TYTUL")]
        [Required(ErrorMessage = "Podaj Tytuł")]
        public string? Title { get; set; }
        [Column("OPIS")]
        [Required(ErrorMessage = "Dodaj opis")]
        public string? Description { get; set; }
        [Column("AUTOR")]
        [Required(ErrorMessage = "Podaj Autora")]
        public string? Author { get; set; }
        [Column("GATUNEK")]
        [Required(ErrorMessage = "Podaj Gatunek")]
        public string? Type { get; set; }
        
        [Column("IMG",TypeName ="BLOB")]
        [Required(ErrorMessage = "Wczytaj zdjęcie")]
        public byte[]? Img { get; set; }
    }
}
