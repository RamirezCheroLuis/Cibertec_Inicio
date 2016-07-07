﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloperDataAccess
{
    public interface IDataAccess<T>
    {
        List<T> GetList();
        int Add(T entity);
        int Delete(T entity);
        int Update(T entity);

    }
}
