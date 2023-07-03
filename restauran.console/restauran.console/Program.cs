using restauran.console.Interfaces.Repasitories;
using restauran.console.Models;
using restauran.console.Repasitories;

namespace restauran.console
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            /*Product product = new Product()
            {
                Id = 1,
                Name = "Osh 1kg",
                Price = 45000,
                Description = "Mayizli osh",
            };*/    
            IProductRepasitory productRepasitory = new ProductRepository();
            var products = await productRepasitory.GetAllWhereAsync(x=>x.Price == 4500);
        }
    }
}