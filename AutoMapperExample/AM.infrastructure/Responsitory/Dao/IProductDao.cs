using AM.infrastructure.Responsitory.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.infrastructure.Responsitory.Dao
{
    public interface IProductDao
    {
        List<ProductDto15> GetListProduct15(int top);
        List<ProductDto50> GetListProduct50(int top);
    }
}
