namespace ePrimjer.Infrastracture.BaseRepository
{
    public interface IBaseRepository<TEntity,TKey> where TEntity : class
    {
        List<TEntity> Get();
    }
}
