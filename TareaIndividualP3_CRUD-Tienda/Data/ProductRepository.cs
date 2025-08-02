using TareaIndividualP3_CRUD_Tienda.Models;

namespace TareaIndividualP3_CRUD_Tienda.Data
{
    public static class ProductRepository
    {
        public static List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Teclado Mecánico", Description = "Teclado RGB con switches Cherry MX.", Price = 120.50m, Stock = 50 },
            new Product { Id = 2, Name = "Mouse Gamer", Description = "Mouse con sensor óptico de alta precisión.", Price = 75.00m, Stock = 80 },
            new Product { Id = 3, Name = "Monitor 144Hz", Description = "Monitor de 24 pulgadas, 144Hz, 1ms de respuesta.", Price = 250.00m, Stock = 30 }
        };

        public static void AddProduct(Product product)
        {
            if (product != null)
            {
                product.Id = Products.Any() ? Products.Max(p => p.Id) + 1 : 1;
                Products.Add(product);
            }
        }

        public static Product? GetById(int id)
        {
            return Products.FirstOrDefault(p => p.Id == id);
        }

        public static void UpdateProduct(Product product)
        {
            var existingProduct = GetById(product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Description = product.Description;
                existingProduct.Price = product.Price;
                existingProduct.Stock = product.Stock;
            }
        }

        public static void DeleteProduct(int id)
        {
            var product = GetById(id);
            if (product != null)
            {
                Products.Remove(product);
            }
        }
    }
}