﻿using Microsoft.AspNetCore.OData.Results;
using SenateCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateCore.Contracts
{
    public interface IGenericRepo<T> where T : class
    {
            Task<T> GetAsync(int? id);
            Task<TResult> GetAsync<TResult>(int? id);
            Task<List<T>> GetAllAsync();
            Task<List<TResult>> GetAllAsync<TResult>();
            Task<PagedResult<TResult>> GetAllAsync<TResult>(QueryParameters queryParameters);
            Task<T> AddAsync(T entity);
            Task<TResult> AddAsync<TSource, TResult>(TSource source);
            Task DeleteAsync(int id);
            Task UpdateAsync(T entity);
            Task UpdateAsync<TSource>(int id, TSource source) where TSource : IBaseDto;
            Task<bool> Exists(int id);

        
    }
}
