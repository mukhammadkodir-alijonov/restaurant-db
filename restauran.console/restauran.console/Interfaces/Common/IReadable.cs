namespace restauran.console.Interfaces.Common
{
    public interface IReadable<T>
    {
        Task<T> GetAsync(int id);
        Task<IList<T>> GetAllAsync();
    }
}
