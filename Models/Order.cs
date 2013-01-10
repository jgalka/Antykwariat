using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Antykwariat.Models
{
    [Bind(Exclude = "OrderId")]
    public partial class Order
    {
        [ScaffoldColumn(false)]
        public int OrderId { get; set; }

        [ScaffoldColumn(false)]
        public System.DateTime OrderDate { get; set; }

        [ScaffoldColumn(false)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Imie jest wymagane")]
        [DisplayName("Imie")]
        [StringLength(160)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        [DisplayName("Nazwisko")]
        [StringLength(160)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Adres jest wymagany")]
        [StringLength(70)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Miasto jest wymagane")]
        [StringLength(40)]
        public string City { get; set; }

        [Required(ErrorMessage = "Kod pocztowy jest wymagany")]
        [DisplayName("Kod pocztowy")]
        [StringLength(6)]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Państwo jest wymagane")]
        [StringLength(40)]
        public string Country { get; set; }

        [Required(ErrorMessage = "Numer telefonu jest wymagany")]
        [StringLength(24)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Adres email jest wymagany")]
        [DisplayName("Email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "Adres email jest nieprawidłowy.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public decimal Total { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
