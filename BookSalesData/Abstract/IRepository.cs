﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookSalesData.Abstract
{
    public interface IRepository<T> where T : class
    {
        //senkron metotlar
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> expression);
        T Get(Expression<Func<T, bool>> expression);
        T Find(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        int Save();
        //Asenkron metotlar;
        Task<T> FindAsync(int id);
        Task<T> GetAsync(Expression<Func<T, bool>>expression);
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task<int> SaveAsync(); //asenkron kaydetme.
    }
}