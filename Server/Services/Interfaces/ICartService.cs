using Server.Entity;

namespace Server.Services.Interfaces;

public interface ICartService
{
    Task<Cart> AddToCartAsync(Cart cart, Product product, int quantity);
    Task RemoveFromCartAsync(Cart cart, int productId, int quantity);
    Task ClearCartAsync(Cart cart, int productId);
}
