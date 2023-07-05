namespace restauran.console.Interfaces.Common
{
    public interface ISearchable<T>
    {
        Task<IList<T>> GetAllWhereAsync(Func<T, bool> predicate);
    }
}
