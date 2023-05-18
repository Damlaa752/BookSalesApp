using BookSalesCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookSalesData.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetProductByIncludeAsync(int id);//include edilmiş 1 adet kayıt getirecek
        Task<List<Product>> GetProductsByIncludeAsync();//ürünleri marka ve kategorisiyle getircek metot
        Task<List<Product>> GetProductByIncludeAsyncs(Expression<Func<Product, bool>> expression); // tüm ürünleri marka ve kategorisiyle lamdayla filtre uygulayarak getircek metot.
    }
}
