using restauran.console.Interfaces.Common;
using restauran.console.Models;

namespace restauran.console.Interfaces.Repasitories
{
    public interface IEmployeeRepository :
        ICreatable<Employee>, IReadable<Employee>,
        IUpdateable<Employee>, IDeleteable<Employee>
    {
    }
}
