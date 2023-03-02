using ShoppingCartBackend.Models;

namespace ShoppingCartBackend.BusinessComponent.IService
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
    }
}
