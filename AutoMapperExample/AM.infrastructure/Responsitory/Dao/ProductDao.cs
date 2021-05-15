using AM.infrastructure.Responsitory.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.infrastructure.Responsitory.Dao
{
    public class ProductDao : IProductDao
    {
        public List<ProductDto15> GetListProduct15(int top)
        {
            List<ProductDto15> products = new List<ProductDto15>();
            for(int i = 0; i < top; i++)
            {
                var product = new ProductDto15() {
                    ProductId = i + 1,
                    ProductName = "Iphone " + i,
                    Price = 100 + (i + 1),
                    CreatedDate = DateTime.Now,
                    DateManufactory = DateTime.Now.AddDays(-1),
                    DateExpried = DateTime.Now.AddDays(10),
                    Properties1 = DateTime.Now.Ticks + i,
                    Properties2 = DateTime.Now.Ticks + i,
                    Properties3 = DateTime.Now.Ticks + i,
                    Properties4 = DateTime.Now.Ticks + i,
                    Properties5 = DateTime.Now.Ticks + i,
                    Properties6 = DateTime.Now.Ticks + i,
                    Properties7 = DateTime.Now.Ticks + i,
                    Properties8 = DateTime.Now.Ticks + i,
                    Properties9 = DateTime.Now.Ticks + i,
                };
                products.Add(product) ;
            }
            return products;
        }

        public List<ProductDto50> GetListProduct50(int top)
        {
            List<ProductDto50> products = new List<ProductDto50>();
            for (int i = 0; i < top; i++)
            {
                var product = new ProductDto50()
                {
                    ProductId = i + 1,
                    ProductName = "Iphone " + i,
                    Price = 100 + (i + 1),
                    CreatedDate = DateTime.Now,
                    DateManufactory = DateTime.Now.AddDays(-1),
                    DateExpried = DateTime.Now.AddDays( 10),
                    Properties1 = DateTime.Now.Ticks + i,
                    Properties2 = DateTime.Now.Ticks + i,
                    Properties3 = DateTime.Now.Ticks + i,
                    Properties4 = DateTime.Now.Ticks + i,
                    Properties5 = DateTime.Now.Ticks + i,
                    Properties6 = DateTime.Now.Ticks + i,
                    Properties7 = DateTime.Now.Ticks + i,
                    Properties8 = DateTime.Now.Ticks + i,
                    Properties9 = DateTime.Now.Ticks + i,
                    Properties10 = DateTime.Now.Ticks + i,
                    Properties11 = DateTime.Now.Ticks + i,
                    Properties12 = DateTime.Now.Ticks + i,
                    Properties13 = DateTime.Now.Ticks + i,
                    Properties14 = DateTime.Now.Ticks + i,
                    Properties15 = DateTime.Now.Ticks + i,
                    Properties16 = DateTime.Now.Ticks + i,
                    Properties17 = DateTime.Now.Ticks + i,
                    Properties18 = DateTime.Now.Ticks + i,
                    Properties19 = DateTime.Now.Ticks + i,
                    Properties20 = DateTime.Now.Ticks + i,
                    Properties21 = DateTime.Now.Ticks + i,
                    Properties22 = DateTime.Now.Ticks + i,
                    Properties23 = DateTime.Now.Ticks + i,
                    Properties24 = DateTime.Now.Ticks + i,
                    Properties25 = DateTime.Now.Ticks + i,
                    Properties26 = DateTime.Now.Ticks + i,
                    Properties27 = DateTime.Now.Ticks + i,
                    Properties28 = DateTime.Now.Ticks + i,
                    Properties29 = DateTime.Now.Ticks + i,
                    Properties30 = DateTime.Now.Ticks + i,
                    Properties31 = DateTime.Now.Ticks + i,
                    Properties32 = DateTime.Now.Ticks + i,
                    Properties33 = DateTime.Now.Ticks + i,
                    Properties34 = DateTime.Now.Ticks + i,
                    Properties35 = DateTime.Now.Ticks + i,
                    Properties36 = DateTime.Now.Ticks + i,
                    Properties37 = DateTime.Now.Ticks + i,
                    Properties38 = DateTime.Now.Ticks + i,
                    Properties39 = DateTime.Now.Ticks + i,
                    Properties40 = DateTime.Now.Ticks + i,
                    Properties41 = DateTime.Now.Ticks + i,
                    Properties42 = DateTime.Now.Ticks + i,
                    Properties43 = DateTime.Now.Ticks + i,
                    Properties44 = DateTime.Now.Ticks + i,
                };
                products.Add(product);
            }
            return products;
        }
    }
}
