using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int ShoppingCardItemId { get; set; }
        public string ShoppingCardId { get; set; }
        public Candy Candy { get; set; }
        public int Amount { get; set; }
    }
}
