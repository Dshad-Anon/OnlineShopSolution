namespace OnlineShop.Api.Entities
{
    public class CartItem
    {
        public int Id { get; set; }

        public int CartId { get; set; } // Foreign key that connects the cart and cartItem.

        public int ProductId { get; set; } //Fk that connects the product and cartItem.
        public int Quantity { get; set; }
    }
}
