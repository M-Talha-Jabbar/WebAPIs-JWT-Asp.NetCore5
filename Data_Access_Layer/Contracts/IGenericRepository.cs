﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(object id); // accept object parameter instead of integer parameter and this is necessary because different tables may have different types of primary keys.
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
}
