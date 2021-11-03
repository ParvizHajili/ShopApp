﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Data.Abstract
{
   public interface IRepository<T>
    {
        T GetByID(int id);
        List<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
