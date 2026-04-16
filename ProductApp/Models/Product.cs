namespace ProductApp.Models
{
    public class Product
    {
        public Int64 ProductID { get; set; }
        public string ProductName { get; set; }
        public string MfgName { get; set; }
        public decimal Price { get; set; }
        public static List<Product> GetProducts()
        {
          List<Product> products = new List<Product>();
            products.Add(new Product
            {
                ProductID = 1,
                ProductName = "Mouse",
                MfgName = "Logitech",
                Price = 550
            });
            products.Add(new Product
            {
                ProductID = 2,
                ProductName = "Keyboard",
                MfgName = "Logitech",
                Price = 550
            });
            products.Add(new Product
            {
                ProductID = 3,
                ProductName = "Monitor",
                MfgName = "Lg",
                Price = 5500
            });
            return products;
        }
    }
}
