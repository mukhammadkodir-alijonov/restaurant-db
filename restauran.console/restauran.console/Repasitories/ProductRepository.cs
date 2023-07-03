using restauran.console.Interfaces.Repasitories;
using restauran.console.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restauran.console.Repasitories
{
    public class ProductRepository : IProductRepasitory
    {
        public Task<bool> CreateAsync(Product obj)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(long id, Product obj)
        {
            throw new NotImplementedException();
        }
    }
}
