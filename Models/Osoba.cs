using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aspMvcVjez91.Models
{
    [Table("Osoba")]
    public class Osoba
    {
        public int OsobaId { get; set; }

        [Required(ErrorMessage ="Unesite ime")]
        [StringLength(30,ErrorMessage ="Maksimalno 30 karaktera")]
        [Display(Name ="Ime osobe")]
        public string Ime { get; set; }

        [Required(ErrorMessage = "Unesite prezime")]
        [StringLength(30, ErrorMessage = "Maksimalno 30 karaktera")]
        [Display(Name = "Prezimeme osobe")]
        public string Prezime { get; set; }


        [Required(ErrorMessage = "Unesite adresu")]
        [StringLength(100, ErrorMessage = "Maksimalno 100 karaktera")]
        public string Adresa { get; set; }
    }
}
