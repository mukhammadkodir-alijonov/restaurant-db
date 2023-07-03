namespace restauran.console.Interfaces.Common
{
    public interface ICreatable<T>
    {
        Task<bool> CreateAsync(T obj);
    }
}
