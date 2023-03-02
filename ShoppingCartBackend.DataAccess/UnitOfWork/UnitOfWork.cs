using ShoppingCartBackend.DataAccess.IRepository;
using ShoppingCartBackend.DataAccess.Repository;

namespace ShoppingCartBackend.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork()
        {
            ProductRepository = new ProductRepository();
        }

        public IProductRepository ProductRepository { get; private set; }
    }
}
