using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();

            // Call methods of productManager as needed
            productManager.AddProduct("Sample Product", 600m);
            productManager.GetAllProducts();
            productManager.GetProductById(1);
            productManager.UpdateProduct(1, "Updated Product", 700m);
            productManager.RemoveProduct(1);
            productManager.GetProductsByCategoryId(2);
            productManager.GetProductsByName("Sample");
            productManager.GetProductsAbovePrice(500m);
        }
    }
}
