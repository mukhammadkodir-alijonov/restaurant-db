namespace restauran.console.Interfaces.Common
{
    public interface IDeleteable<T>
    {
        Task<bool> DeleteAsync(long id);
    }
}
