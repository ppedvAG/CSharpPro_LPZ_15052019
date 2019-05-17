using ppedv.FlyingPluto.Model;
using ppedv.FlyingPluto.Model.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
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

    public class EfKundenRepository : EfRepository<Kunde>, IKundenRepository
    {
        public EfKundenRepository(EfContext context) : base(context)
        { }

        public override void Add(Kunde entity)
        {
            base.Add(entity);
            //todo besser Add
        }

        public IEnumerable<Kunde> GetBlaBlaKunden(int tage, DateTime datum)
        {
            //todo call StoredProc
            //context.Database.ExecuteSqlCommand();
            throw new NotImplementedException();
        }
    }
}
