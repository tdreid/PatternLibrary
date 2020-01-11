namespace PatternLibrary
{
    public interface IRepositoryStrict<T> : IRepository<T>
        where T : AbstractEntity
    {
    }
}
