using BookSalesCore.Entities;
using BookSalesData.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookSalesData.Concrete
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DatabaseContext context) : base(context)
        {
        }

        public async Task<Product> GetProductByInclude(int id)
        {
            return await _context.Products.Include(p => p.Brand).Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Product>> GetProductsByIncludeAsync()
        {
            return await _context.Products.Include(p => p.Brand).Include(p => p.Category).ToListAsync();
        }
        public async Task<List<Product>> GetProductByIncludeAsyncs(Expression<Func<Product, bool>> expression)
        {
            return await _context.Products.Where(expression).Include(p => p.Brand).Include(p => p.Category).ToListAsync();
        }

        public Task<Product> GetProductByIncludeAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
