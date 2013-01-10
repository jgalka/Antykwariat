namespace Antykwariat.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int KsiazkaId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual Ksiazka Ksiazka { get; set; }
        public virtual Order Order { get; set; }
    }
}
