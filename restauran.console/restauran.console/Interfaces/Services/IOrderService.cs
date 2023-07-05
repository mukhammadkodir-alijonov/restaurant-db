using restauran.console.ViewModels;

namespace restauran.console.Interfaces.Services
{
    public interface IOrderService
    {
        public Task<IEnumerable<OrderViewModel>> GetAllAsync();
        public Task<OrderViewModel> GetAsync(long id);
    }
}
