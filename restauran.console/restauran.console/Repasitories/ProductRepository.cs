using Newtonsoft.Json;
using restauran.console.Constants;
using restauran.console.Interfaces.Repasitories;
using restauran.console.Models;
using System.Linq;
using System.Linq.Expressions;

namespace restauran.console.Repasitories
{
    public class ProductRepository : IProductRepasitory
    {
        private string _dbpath = DbConstants.PRODUCTS_DB;
        public async Task<bool> CreateAsync(Product obj)
        {
            try
            {
                string json = await File.ReadAllTextAsync(_dbpath);
                var products = JsonConvert.DeserializeObject<List<Product>>(json);
                products!.Add(obj);
                json = JsonConvert.SerializeObject(products);
                await File.WriteAllTextAsync(_dbpath, json);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(long id)
        {
            try
            {
                string json = await File.ReadAllTextAsync(_dbpath);
                var products = JsonConvert.DeserializeObject<List<Product>>(json);
                foreach (var item in products)
                {
                    if (item.Id == id)
                    {
                        products.Remove(item);
                        break;
                    }
                }
                json = JsonConvert.SerializeObject(products);
                await File.WriteAllTextAsync(_dbpath, json);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<IList<Product>> GetAllAsync()
        {
            string json = await File.ReadAllTextAsync(_dbpath);
            var products = JsonConvert.DeserializeObject<List<Product>>(json);
            return products!;
        }

        public async Task<IList<Product>> GetAllWhereAsync(Func<Product, bool> predicate)
        {
            string json = await File.ReadAllTextAsync(_dbpath);
            var products = JsonConvert.DeserializeObject<List<Product>>(json);
            return products!.Where(predicate).ToList();
        }

        public async Task<Product> GetAsync(int id)
        {
            try
            {
                string json = await File.ReadAllTextAsync(_dbpath);
                var products = JsonConvert.DeserializeObject<List<Product>>(json);
                foreach (var item in products)
                {
                    if (item.Id == id)
                    {
                        return item;
                    }
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> UpdateAsync(long id, Product obj)
        {
            try
            {
                string json = await File.ReadAllTextAsync(_dbpath);
                var products = JsonConvert.DeserializeObject<List<Product>>(json);
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].Id == id)
                    {
                        products[i] = obj;
                    }
                }
                json = JsonConvert.SerializeObject(products);
                await File.WriteAllTextAsync(_dbpath, json);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
