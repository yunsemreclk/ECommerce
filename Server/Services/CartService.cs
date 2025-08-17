using Server.Entity;
using Server.Services.Interfaces;

namespace Server.Services;

public class CardService : ICartService
{
    public Task<Cart> AddToCartAsync(Cart cart, Product product, int quantity)
    {
        var item = cart.CartItems.FirstOrDefault(ci => ci.ProductId == product.Id);

        if (item != null)
            item.Quantity += quantity;
        else
            cart.CartItems.Add(new CartItem
            {
                Quantity = quantity,
                Product = product
            });

        return Task.FromResult(cart);
    }

    public Task RemoveFromCartAsync(Cart cart, int productId, int quantity)
    {
        var item = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId);

        if (item != null)
        {
            if (item.Quantity > quantity)
                item.Quantity -= quantity;
            else
                cart.CartItems.Remove(item);
        }

        return Task.CompletedTask;
    }

    public Task ClearCartAsync(Cart cart, int productId)
    {
        var item = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId);
        if (item != null)
            cart.CartItems.Remove(item);

        return Task.CompletedTask;
    }
}
