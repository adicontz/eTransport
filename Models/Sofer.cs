using eTransport.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTransport.Models
{
    public class Sofer:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "ImagineUrl")]
        [Required(ErrorMessage = "Este necesara o fotografie")]
        public string ImagineUrl { get; set; }
        [Display(Name = "NumeComplet")]
        [Required(ErrorMessage = "Este necesar numele complet")]
        [StringLength(50, MinimumLength = 3,ErrorMessage = "Numele complet trebuie sa fie cuprins intre 3 si 50 litere ")]
        public string NumeComplet {  get; set; }
        [Display(Name = "Biografie")]
        [Required(ErrorMessage = "Este necesara o scurta biografie")]
        public string Biografie { get; set; }

        //Relationships

        public List<SoferiServicii> SoferiServicii {  get; set; }   

    }
}
