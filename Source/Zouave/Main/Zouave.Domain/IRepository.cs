﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zouave.Domain
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {

        TEntity Find(object id);
        TEntity Create();
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
