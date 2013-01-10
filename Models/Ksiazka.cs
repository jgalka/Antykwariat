using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Collections.Generic;

namespace Antykwariat.Models
{
    [Bind(Exclude = "KsiazkaId")]
    public class Ksiazka
    {
        [ScaffoldColumn(false)]
        public int KsiazkaId { get; set; }

        [DisplayName("Gatunek")]
        public int GatunekId { get; set; }

        [DisplayName("Autor")]
        public int AutorId { get; set; }

        [Required(ErrorMessage = "Wymagany tytuł ksiązki")]
        [StringLength(160)]
        public string Tytul { get; set; }

        [Required(ErrorMessage = "Wymagana cena")]
        [Range(0.01, 500.00,
            ErrorMessage = "Cena musi zawierać się w przedziale od 0.01 do 500.00")]
        public decimal Cena { get; set; }

        [DisplayName("Okladka")]
        [StringLength(1024)]
        public string Okladka { get; set; }

        public virtual Gatunek Gatunek { get; set; }
        public virtual Autor Autor { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}