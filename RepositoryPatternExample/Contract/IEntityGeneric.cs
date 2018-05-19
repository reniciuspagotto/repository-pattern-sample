namespace RepositoryPatternExample.Contract
{
    public interface IEntityGeneric<TEntity>
    {
        TEntity Get(int IdClient);
        TEntity GetAll(int IdClient);
        bool Save(TEntity client);
        bool Update(TEntity client);
        bool Delete(TEntity client);
    }
}