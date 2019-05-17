using System.Threading.Tasks;

namespace ppedv.FlyingPluto.Model.Contracts
{
    public interface IUnitOfWork
    {
        IRepository<T> GetRepository<T>() where T : Entity;
        IKundenRepository KundenRepo { get; }


        void SaveAll();
        Task SaveAllAsync();
    }

}
