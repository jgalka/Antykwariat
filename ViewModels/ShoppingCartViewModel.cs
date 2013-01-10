using System.Collections.Generic;
using Antykwariat.Models;

namespace Antykwariat.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}