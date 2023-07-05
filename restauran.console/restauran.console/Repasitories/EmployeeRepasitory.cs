using Newtonsoft.Json;
using restauran.console.Constants;
using restauran.console.Interfaces.Repasitories;
using restauran.console.Models;

namespace restauran.console.Repasitories
{
    public class EmployeeRepasitory : IEmployeeRepository
    {
        private string _dbpath = DbConstants.EMPLOYEES_DB;
        public async Task<bool> CreateAsync(Employee obj)
        {
            try
            {
                string json = await File.ReadAllTextAsync(_dbpath);
                var Employees = JsonConvert.DeserializeObject<List<Employee>>(json);
                Employees!.Add(obj);
                json = JsonConvert.SerializeObject(Employees);
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
                var Employees = JsonConvert.DeserializeObject<List<Employee>>(json);
                foreach (var item in Employees)
                {
                    if (item.Id == id)
                    {
                        Employees.Remove(item);
                        break;
                    }
                }
                json = JsonConvert.SerializeObject(Employees);
                await File.WriteAllTextAsync(_dbpath, json);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<IList<Employee>> GetAllAsync()
        {
            string json = await File.ReadAllTextAsync(_dbpath);
            var Employees = JsonConvert.DeserializeObject<List<Employee>>(json);
            return Employees!;
        }

        public async Task<IList<Employee>> GetAllWhereAsync(Func<Employee, bool> predicate)
        {
            string json = await File.ReadAllTextAsync(_dbpath);
            var Employees = JsonConvert.DeserializeObject<List<Employee>>(json);
            return Employees!.Where(predicate).ToList();
        }

        public async Task<Employee> GetAsync(int id)
        {
            try
            {
                string json = await File.ReadAllTextAsync(_dbpath);
                var Employees = JsonConvert.DeserializeObject<List<Employee>>(json);
                foreach (var item in Employees)
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

        public async Task<bool> UpdateAsync(long id, Employee obj)
        {
            try
            {
                string json = await File.ReadAllTextAsync(_dbpath);
                var Employees = JsonConvert.DeserializeObject<List<Employee>>(json);
                for (int i = 0; i < Employees.Count; i++)
                {
                    if (Employees[i].Id == id)
                    {
                        Employees[i] = obj;
                    }
                }
                json = JsonConvert.SerializeObject(Employees);
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
