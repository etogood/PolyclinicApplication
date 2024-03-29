﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyclinicApplication.Services.Interfaces
{
    internal interface IDataService<T>
    {
        Task Create(T entity);

        Task Update(T oldEntity , T newEntity);

        Task Delete(T entity);

        Task<IEnumerable<T>> GetAll();
    }
}
