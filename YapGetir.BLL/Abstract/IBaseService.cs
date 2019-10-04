﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetir.Core.Entity;

namespace YapGetir.BLL.Abstract
{
    public interface IBaseService<T> where T:BaseEntity
    {
        void Insert(T entity);
        void Delete(T entity);
        void DeleteById(int entityID);
        void Update(T entity);

        T Get(int entityID);
        ICollection<T> GetAll();

    }
}