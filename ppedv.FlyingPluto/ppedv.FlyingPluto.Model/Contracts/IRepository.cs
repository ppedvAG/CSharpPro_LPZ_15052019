using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ppedv.FlyingPluto.Model.Contracts
{
    public interface IRepository<T> where T : Entity
    {
        IQueryable<T> Query();
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    public interface IKundenRepository : IRepository<Kunde>
    {
        IEnumerable<Kunde> GetBlaBlaKunden(int tage, DateTime datum);
    }

    public interface IUnitOfWork
    {
        IRepository<T> GetRepository<T>() where T : Entity;
        IKundenRepository KundenRepo { get; }


        void SaveAll();
    }

}
