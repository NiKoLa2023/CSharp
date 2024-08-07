﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaAppRefacored.DataBase
{
    public interface IRepository<T>
    {
        //CRUD - create, read, update, delete
        List<T> GetAll();

        T GetById(int id);

        int Insert(T entity);

        void Update(T entity);

        void DeleteById(int id);

    }
}
