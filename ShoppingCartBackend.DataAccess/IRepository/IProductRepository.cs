using ShoppingCartBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartBackend.DataAccess.IRepository
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
    }
}
