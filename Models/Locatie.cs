using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTransport.Models
{
    public class Locatie //aka Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Imagine")]
        public string ImagineUrl {  get; set; }
        [Display(Name = "Nume")]
        public string Nume { get; set; }
        [Display(Name = "Descriere")]
        public string Descriere { get; set; }

        //Relationships

        public List<Locatie> Locatii { get; set; }  
    }
}
