using RepositoryPatternExample.Entity;

namespace RepositoryPatternExample.Contract
{
    public interface IClientRepository
    {
        Client Get(int IdClient);
        Client GetAll(int IdClient);
        bool Save(Client client);
        bool Update(Client client);
        bool Delete(Client client);
    }
}