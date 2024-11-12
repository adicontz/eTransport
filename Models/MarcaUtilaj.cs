using eTransport.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTransport.Models
{
    public class MarcaUtilaj:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Imagine")]
        public string ImagineUrl { get; set; }
        [Display(Name = "Nume")]
        public string Nume { get; set; }
        [Display(Name = "Detalii")]
        public string Detalii { get; set; }

        //Relationships
        public List<Serviciu> Servicii { get; set; }
    }
}




   
