using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_01
{
    public class ProductManager
    {
        private DAL _dal;

        public ProductManager()
        {
            _dal = new DAL();
        }

        public void AddProduct(string name, decimal price)
        {
            try
            {
                _dal.CreateProduct(name, price);
            }
            catch (DALException ex)
            {
                Console.WriteLine($"An error occurred while adding a product: {ex.Message}");
            }
        }

        public void GetAllProducts()
        {
            _dal.ReadAllProducts();
        }

        public void GetProductById(int id)
        {
            _dal.GetProductById(id);
        }

        public void UpdateProduct(int id, string newName, decimal newPrice)
        {
            _dal.UpdateProduct(id, newName, newPrice);
        }

        public void RemoveProduct(int id)
        {
            _dal.DeleteProduct(id);
        }

        public void GetProductsByCategoryId(int categoryId)
        {
            _dal.GetProductsByCategoryId(categoryId);
        }

        public void GetProductsByName(string name)
        {
            _dal.GetProductsByName(name);
        }

        public void GetProductsAbovePrice(decimal minPrice)
        {
            _dal.ReadByPriceGreaterThan(minPrice);
        }

    }
}
