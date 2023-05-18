using BookSalesCore.Entities;
using BookSalesData.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSalesService.Abstract
{
    public interface IService<T> : IRepository<T> where T : class, IEntity, new()
    {
    }
}
