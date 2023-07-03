using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restauran.console.Interfaces.Common
{
    public interface IReadable<T>
    {
        Task<T> GetAsync(int id);
        Task<IList<T>> GetAllAsync();
    }
}
