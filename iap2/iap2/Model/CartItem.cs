using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iap2.Model
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }

        public string CartId { get; set; }

        public int Quantity { get; set; }

        public System.DateTime DateCreated { get; set; }

        public int ProductId { get; set; }

        public Product Products { get; set; }
    }
}
