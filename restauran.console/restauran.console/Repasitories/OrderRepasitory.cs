using Newtonsoft.Json;
using restauran.console.Constants;
using restauran.console.Interfaces.Repasitories;
using restauran.console.Models;

namespace restauran.console.Repasitories
{
    public class OrderRepasitory : IOrderRepository
    {
        private string _dbpath = DbConstants.ORDERS_DB;
        public async Task<bool> CreateAsync(Order obj)
        {
            try
            {
                string json = await File.ReadAllTextAsync(_dbpath);
                var Orders = JsonConvert.DeserializeObject<List<Order>>(json);
                Orders!.Add(obj);
                json = JsonConvert.SerializeObject(Orders);
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
                var Orders = JsonConvert.DeserializeObject<List<Order>>(json);
                foreach (var item in Orders)
                {
                    if (item.Id == id)
                    {
                        Orders.Remove(item);
                        break;
                    }
                }
                json = JsonConvert.SerializeObject(Orders);
                await File.WriteAllTextAsync(_dbpath, json);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<IList<Order>> GetAllAsync()
        {
            string json = await File.ReadAllTextAsync(_dbpath);
            var Orders = JsonConvert.DeserializeObject<List<Order>>(json);
            return Orders!;
        }

        public async Task<Order> GetAsync(int id)
        {
            try
            {
                string json = await File.ReadAllTextAsync(_dbpath);
                var Orders = JsonConvert.DeserializeObject<List<Order>>(json);
                foreach (var item in Orders)
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

        public async Task<bool> UpdateAsync(long id, Order obj)
        {
            try
            {
                string json = await File.ReadAllTextAsync(_dbpath);
                var Orders = JsonConvert.DeserializeObject<List<Order>>(json);
                for (int i = 0; i < Orders.Count; i++)
                {
                    if (Orders[i].Id == id)
                    {
                        Orders[i] = obj;
                    }
                }
                json = JsonConvert.SerializeObject(Orders);
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
