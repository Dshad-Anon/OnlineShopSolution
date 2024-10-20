using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopLibrary.Models.Dtos
{
    public class CartItemQtyUpdateDto
    {
        public int CartId { get; set; }

        public int Quantity { get; set; }
    }
}
