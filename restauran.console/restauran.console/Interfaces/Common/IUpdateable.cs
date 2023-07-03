namespace restauran.console.Interfaces.Common
{
    public interface IUpdateable<T>
    {
        Task<bool> UpdateAsync(long id, T obj);
    }
}
