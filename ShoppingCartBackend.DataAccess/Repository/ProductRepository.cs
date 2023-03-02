using ShoppingCartBackend.DataAccess.IRepository;
using ShoppingCartBackend.Models;

namespace ShoppingCartBackend.DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAllProducts()
        {
            try
            {
                var productList = new List<Product>()
                {
                    new Product
                    {
                        Name= "Book",
                        Price = 12.49,
                        IsImported = false,
                    },
                    new Product
                    {
                        Name= "Music CD",
                        Price = 14.99,
                        IsImported = false,
                    },
                    new Product
                    {
                        Name= "Chocolate Bar",
                        Price = 0.85,
                        IsImported = false,
                    },
                    new Product
                    {
                        Name= "Imported Box Of Chocolates",
                        Price = 10.00,
                        IsImported = true,
                    },
                    new Product
                    {
                        Name= "Imported Bottle Of Perfume",
                        Price = 47.50,
                        IsImported = true,
                    },
                    new Product
                    {
                        Name= "Bottle Of Perfume",
                        Price = 18.99,
                        IsImported = false,
                    },
                    new Product
                    {
                        Name= "Packet Of Headache Pills",
                        Price = 9.75,
                        IsImported = false,
                    },
                    new Product
                    {
                        Name= "Box Of Imported Chocolates",
                        Price = 11.25,
                        IsImported = true,
                    }
                };
                return productList;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
