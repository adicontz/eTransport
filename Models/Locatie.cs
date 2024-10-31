using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTransport.Models
{
    public class Locatie //aka Cinema
    {
        [Key]
        public int Id { get; set; }
        public string ImagineUrl {  get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }

        //Relationships

        public List<Locatie> Locatii { get; set; }  
    }
}
