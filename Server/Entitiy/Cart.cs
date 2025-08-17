namespace Server.Entity;

public class Cart
{
    public int Id { get; set; }
    public string UserId { get; set; } = null!;
    public List<CartItem> CartItems { get; set; } = new List<CartItem>();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}

public class CartItem
{
    public int Id { get; set; }

    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;
    public int Quantity { get; set; }

    public int CartId { get; set; }
    public Cart Cart { get; set; } = null!;

    public DateTime AddedAt { get; set; } = DateTime.UtcNow;


}