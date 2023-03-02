using ShoppingCartBackend.BusinessComponent.IService;
using ShoppingCartBackend.DataAccess.UnitOfWork;
using ShoppingCartBackend.Models;

namespace ShoppingCartBackend.BusinessComponent.Service
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<Product> GetAllProducts()
        {
            try
            {
                return _unitOfWork.ProductRepository.GetAllProducts();
            }
            catch(Exception ex)
            {
                throw;
            }
            
        }
    }
}
