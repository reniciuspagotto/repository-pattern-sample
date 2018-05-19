using RepositoryPatternExample.Contract;

namespace RepositoryPatternExample.Repository
{
    public class EntityGeneric<TEntity> : IEntityGeneric<TEntity> where TEntity : class
    {
        public bool Delete(TEntity client)
        {
            throw new System.NotImplementedException();
        }

        public TEntity Get(int IdClient)
        {
            throw new System.NotImplementedException();
        }

        public TEntity GetAll(int IdClient)
        {
            throw new System.NotImplementedException();
        }

        public bool Save(TEntity client)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(TEntity client)
        {
            throw new System.NotImplementedException();
        }
    }
}
