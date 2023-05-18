using BookSalesData.Concrete;
using BookSalesData;
using BookSalesService.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSalesService.Concrete
{
    public class ProductService : ProductRepository, IProductService
    {
        public ProductService(DatabaseContext context) : base(context)
        {
        }
    }
}
