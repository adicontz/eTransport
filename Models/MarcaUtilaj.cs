using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTransport.Models
{
    public class MarcaUtilaj  //Producer
    {
        [Key]
        public int Id { get; set; }
        public string ImagineUrl { get; set; }
        public string Nume { get; set; }
        public string Detalii { get; set; }

        //Relationships
        public List<Serviciu> Servicii { get; set; }
    }
}




   
