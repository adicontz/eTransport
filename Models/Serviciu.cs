using eTransport.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTransport.Models
{
    public class Serviciu  //Movie
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nume")]
        public string Nume { get; set; }
        [Display(Name = "Descriere")]
        public string Descriere { get; set; }
        [Display(Name = "Pret")]
        public double Pret { get; set; }
        [Display(Name = "ImagineUrl")]
        public string ImagineUrl { get; set; }
        public DateTime Timp { get; set; }
        public ServiciuCategorie ServiciuCategorie { get; set; }

        ////Relationships
        public List<SoferiServicii> SoferiServicii { get; set; }


        //Locatie
        public int LocatieId { get; set; }
        [ForeignKey("LocatieId")]
        public Locatie Locatie { get; set; }


        //MarcaUtilaj
        public int MarcaUtilajId { get; set; }
        [ForeignKey("MarcaUtilajId")]
        public MarcaUtilaj MarcaUtilaj { get; set; }

    }
}
