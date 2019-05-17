using ppedv.FlyingPluto.Model;
using ppedv.FlyingPluto.Model.Contracts;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppedv.FlyingPluto.Data.EF
{
    public class EfRepository<T> : IRepository<T> where T : Entity
    {
        protected EfContext context;
        public EfRepository(EfContext context)
        {
            this.context = context;
        }

        public virtual void Add(T entity)
        {
            //    if (typeof(T) == typeof(Auto))
            //        context.Autos.Add(entity as Auto);
            context.Set<T>().Add(entity);
        }

        public Task AddAsync(T entity)
        {
            return Task.Run(() => Add(entity));
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public Task<List<T>> GetAllAsync()
        {
            return context.Set<T>().ToListAsync();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public Task<T> GetByIdAsync(int id)
        {
            return context.Set<T>().FindAsync(id);

        }

        public IQueryable<T> Query()
        {
            return context.Set<T>();
        }


        public void Update(T entity)
        {
            var loaded = GetById(entity.Id);
            if (loaded != null)
            {
                context.Entry(loaded).CurrentValues.SetValues(entity);
            }
        }
    }
}
