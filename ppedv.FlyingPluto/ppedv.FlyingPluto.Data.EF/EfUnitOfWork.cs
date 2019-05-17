using ppedv.FlyingPluto.Model;
using ppedv.FlyingPluto.Model.Contracts;

namespace ppedv.FlyingPluto.Data.EF
{
    public class EfUnitOfWork : IUnitOfWork
    {
        EfContext context = new EfContext();

        public IKundenRepository KundenRepo => new EfKundenRepository(context);

        public IRepository<T> GetRepository<T>() where T : Entity
        {
            return new EfRepository<T>(context);
        }

        public void SaveAll()
        {
            context.SaveChanges();
        }
    }
}
