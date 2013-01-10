using System.ComponentModel.DataAnnotations;

namespace Antykwariat.Models
{
    public class Cart
    {
        [Key]
        public int RecordId { get; set; }
        public string CartId { get; set; }
        public int KsiazkaID { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }

        public virtual Ksiazka Ksiazka { get; set; }
    }
}