using restauran.console.Interfaces.Common;
using restauran.console.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restauran.console.Interfaces.Repasitories
{
    public interface IProductRepasitory : 
        ICreatable<Product>, IReadable<Product>, 
        IDeleteable<Product>, IUpdateable<Product>
    {

    }
}
