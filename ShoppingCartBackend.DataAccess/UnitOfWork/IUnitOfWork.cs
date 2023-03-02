using ShoppingCartBackend.DataAccess.IRepository;

namespace ShoppingCartBackend.DataAccess.UnitOfWork
{
    public interface IUnitOfWork
    {
        IProductRepository ProductRepository { get; }
    }
}
