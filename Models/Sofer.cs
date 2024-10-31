using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTransport.Models
{
    public class Sofer  //Actor
    {
        [Key]
        public int Id { get; set; }
        public string ImagineUrl { get; set; }
        public string NumeComplet {  get; set; }
        public string Biografie { get; set; }

        //Relationships

        public List<SoferiServicii> SoferiServicii {  get; set; }   

    }
}
