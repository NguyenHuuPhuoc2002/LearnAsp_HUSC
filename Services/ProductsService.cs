using BaoTest1.Models;

namespace BaoTest1.Services
{
    public class ProductsService
    {
        static List<Products> products;
        public ProductsService()
        {
            if(products == null)
            {
                products = new List<Products>();
                products.Add(new Products
                {
                    Id = 1,
                    Name = "Asustuf",
                    Description = "dsghdfgnkjfdsg;lfds",
                    Price = 1500,
                    Category = "Laptop",
                    ProductionDay = DateTime.Now,
                });
                products.Add(new Products
                {
                    Id = 2,
                    Name = "Lenovo Thinkpad",
                    Description = "dsghdfgnkjfdsg;lfds",
                    Price = 1500,
                    Category = "Laptop",
                    ProductionDay = DateTime.Now,
                });
                products.Add(new Products
                {
                    Id = 3,
                    Name = "Acer Nitro",
                    Description = "dsghdfgnkjfdsg;lfds",
                    Price = 1500,
                    Category = "Laptop",
                    ProductionDay = DateTime.Now,
                });
                products.Add(new Products
                {
                    Id = 4,
                    Name = "Dell Insprie",
                    Description = "dsghdfgnkjfdsg;lfds",
                    Price = 1500,
                    Category = "Laptop",
                    ProductionDay = DateTime.Now,
                });
                products.Add(new Products
                {
                    Id = 5,
                    Name = "Dp Plaviton",
                    Description = "dsghdfgnkjfdsg;lfds",
                    Price = 1500,
                    Category = "Laptop",
                    ProductionDay = DateTime.Now,
                });
                products.Add(new Products
                {
                    Id = 6,
                    Name = "Macbook Air",
                    Description = "dsghdfgnkjfdsg;lfds",
                    Price = 1500,
                    Category = "Laptop",
                    ProductionDay = DateTime.Now,

                });
            }
        }


        /// <summary>
        /// Funtion to get products from ProductsService
        /// </summary>
        public List<Products> GetProducts(string? keyword)
        {
            return products;
        }
    }
}
