using Newtonsoft.Json;
using restauran.console.Constants;
using restauran.console.Interfaces.Repasitories;
using restauran.console.Models;

namespace restauran.console.Repasitories
{
    public class OrderDetailRepasitory : IOrderDeatilRepository
    {
        private string _dbpath = DbConstants.ORDER_DETAILS_DB;
        public async Task<bool> CreateAsync(OrderDetail obj)
        {
            try
            {
                string json = await File.ReadAllTextAsync(_dbpath);
                var OrderDetails = JsonConvert.DeserializeObject<List<OrderDetail>>(json);
                OrderDetails!.Add(obj);
                json = JsonConvert.SerializeObject(OrderDetails);
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
                var OrderDetails = JsonConvert.DeserializeObject<List<OrderDetail>>(json);
                foreach (var item in OrderDetails)
                {
                    if (item.Id == id)
                    {
                        OrderDetails.Remove(item);
                        break;
                    }
                }
                json = JsonConvert.SerializeObject(OrderDetails);
                await File.WriteAllTextAsync(_dbpath, json);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<IList<OrderDetail>> GetAllAsync()
        {
            string json = await File.ReadAllTextAsync(_dbpath);
            var OrderDetails = JsonConvert.DeserializeObject<List<OrderDetail>>(json);
            return OrderDetails!;
        }

        public async Task<OrderDetail> GetAsync(int id)
        {
            try
            {
                string json = await File.ReadAllTextAsync(_dbpath);
                var OrderDetails = JsonConvert.DeserializeObject<List<OrderDetail>>(json);
                foreach (var item in OrderDetails)
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
    }
}
