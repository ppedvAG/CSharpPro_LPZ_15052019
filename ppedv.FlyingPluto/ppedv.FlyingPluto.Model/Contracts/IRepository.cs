﻿using System.Collections.Generic;
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

}
