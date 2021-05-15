using AM.infrastructure.Responsitory.Dao;
using AM.infrastructure.Responsitory.Dtos;
using AM.infrastructure.Service.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.infrastructure.Service.ProductBsl
{
    public class ProductBsl : IProductBsl
    {
        private readonly IProductDao productDal;
        private readonly IMapper mapper;

        public ProductBsl(IProductDao productDal, IMapper mapper)
        {
            this.productDal = productDal;
            this.mapper = mapper;
        }

        public LogTimeModel TestPerformance()
        {
            LogTimeModel model = new LogTimeModel();
            Stopwatch timer = new Stopwatch();
            
            var lstProduct1510 = productDal.GetListProduct15(10);
            var lstProduct15100 = productDal.GetListProduct15(100);
            var lstProduct151000 = productDal.GetListProduct15(1000);
            var lstProduct1510000 = productDal.GetListProduct15(10000);
            var lstProduct15100000 = productDal.GetListProduct15(100000);
            var lstProduct151000000 = productDal.GetListProduct15(1000000);

            var lstProduct5010 = productDal.GetListProduct50(10);
            var lstProduct50100 = productDal.GetListProduct50(100);
            var lstProduct501000 = productDal.GetListProduct50(1000);
            var lstProduct5010000 = productDal.GetListProduct50(10000);
            var lstProduct50100000 = productDal.GetListProduct50(100000);
            var lstProduct501000000 = productDal.GetListProduct50(1000000);

            // Case 1: Manual - 15 - 10
            timer.Start();
            var resultMap1510 = lstProduct1510.Select(x => new ProductModel15(x));
            timer.Stop();
            model.Manual15_10 = timer.ElapsedTicks;
            timer.Reset();

            // Case 2: Normal - 15 - 10
            timer.Start();
            var resultMapNormal1510 = mapper.Map<List<ProductDto15>, List<ProductModel15>>(lstProduct1510);
            timer.Stop();
            model.Normal15_10 = timer.ElapsedTicks;
            timer.Reset();

            // Case 3: Complex - 15 - 10
            timer.Start();
            var resultMapComplex1510 = mapper.Map<List<ProductDto15>, List<ProductModelComplex15>>(lstProduct1510);
            timer.Stop();
            model.Complex15_10 = timer.ElapsedTicks;
            timer.Reset();

            // Case 4: Manual - 15 - 100
            timer.Start();
            var resultMapManual15100 = lstProduct15100.Select(x => new ProductModel15(x));
            timer.Stop();
            model.Manual15_100 = timer.ElapsedTicks;
            timer.Reset();

            // Case 5: Normal - 15 - 100
            timer.Start();
            var resultMapNormal15100 = mapper.Map<List<ProductDto15>, List<ProductModel15>>(lstProduct15100);
            timer.Stop();
            model.Normal15_100 = timer.ElapsedTicks;
            timer.Reset();

            // Case 6: Complex - 15 - 100
            timer.Start();
            var resultMapComplex15100 = mapper.Map<List<ProductDto15>, List<ProductModelComplex15>>(lstProduct15100);
            timer.Stop();
            model.Complex15_100 = timer.ElapsedTicks;
            timer.Reset();

            // Case 7: Manual - 15 - 1000
            timer.Start();
            var resultMapManual151000 = lstProduct151000.Select(x => new ProductModel15(x));
            timer.Stop();
            model.Manual15_1000 = timer.ElapsedTicks;
            timer.Reset();

            // Case 8: Normal - 15 - 1000
            timer.Start();
            var resultMapNormal151000 = mapper.Map<List<ProductDto15>, List<ProductModel15>>(lstProduct151000);
            timer.Stop();
            model.Normal15_1000 = timer.ElapsedTicks;
            timer.Reset();

            // Case 9: Complex - 15 - 1000
            timer.Start();
            var resultMapComplex151000 = mapper.Map<List<ProductDto15>, List<ProductModelComplex15>>(lstProduct151000);
            timer.Stop();
            model.Complex15_1000 = timer.ElapsedTicks;
            timer.Reset();

            // Case 10: Manual - 15 - 10000
            timer.Start();
            var resultMapManual1510000 = lstProduct1510000.Select(x => new ProductModel15(x));
            timer.Stop();
            model.Manual15_10000 = timer.ElapsedTicks;
            timer.Reset();

            // Case 11: Normal - 15 - 10000
            timer.Start();
            var resultMapNormal1510000 = mapper.Map<List<ProductDto15>, List<ProductModel15>>(lstProduct1510000);
            timer.Stop();
            model.Normal15_10000 = timer.ElapsedTicks;
            timer.Reset();

            // Case 12: Complex - 15 - 10000
            timer.Start();
            var resultMapComplex1510000 = mapper.Map<List<ProductDto15>, List<ProductModelComplex15>>(lstProduct1510000);
            timer.Stop();
            model.Complex15_10000 = timer.ElapsedTicks;
            timer.Reset();

            // Case 13: Manual - 15 - 100000
            timer.Start();
            var resultMapManual15100000 = lstProduct15100000.Select(x => new ProductModel15(x));
            timer.Stop();
            model.Manual15_100000 = timer.ElapsedTicks;
            timer.Reset();

            // Case 14: Normal - 15 - 100000
            timer.Start();
            var resultMapNormal15100000 = mapper.Map<List<ProductDto15>, List<ProductModel15>>(lstProduct15100000);
            timer.Stop();
            model.Normal15_100000 = timer.ElapsedTicks;
            timer.Reset();

            // Case 15: Complex - 15 - 100000
            timer.Start();
            var resultMapComplex15100000 = mapper.Map<List<ProductDto15>, List<ProductModelComplex15>>(lstProduct15100000);
            timer.Stop();
            model.Complex15_100000 = timer.ElapsedTicks;
            timer.Reset();

            // Case 16: Manual - 15 - 1000000
            timer.Start();
            var resultMapManual151000000 = lstProduct151000000.Select(x => new ProductModel15(x));
            timer.Stop();
            model.Manual15_1000000 = timer.ElapsedTicks;
            timer.Reset();

            // Case 17: Normal - 15 - 1000000
            timer.Start();
            var resultMapNormal151000000 = mapper.Map<List<ProductDto15>, List<ProductModel15>>(lstProduct151000000);
            timer.Stop();
            model.Normal15_1000000 = timer.ElapsedTicks;
            timer.Reset();

            // Case 18: Complex - 15 - 100000
            timer.Start();
            var resultMapComplex151000000 = mapper.Map<List<ProductDto15>, List<ProductModelComplex15>>(lstProduct151000000);
            timer.Stop();
            model.Complex15_1000000 = timer.ElapsedTicks;
            timer.Reset();


            /////////////////// 50 ////////////////////////////

            // Case 1: Manual - 50 - 10
            timer.Start();
            var resultMap5010 = lstProduct5010.Select(x => new ProductModel50(x));
            timer.Stop();
            model.Manual50_10 = timer.ElapsedTicks;
            timer.Reset();

            // Case 2: Normal - 50 - 10
            timer.Start();
            var resultMapNormal5010 = mapper.Map<List<ProductDto50>, List<ProductModel50>>(lstProduct5010);
            timer.Stop();
            model.Normal50_10 = timer.ElapsedTicks;
            timer.Reset();

            // Case 3: Complex - 50 - 10
            timer.Start();
            var resultMapComplex5010 = mapper.Map<List<ProductDto50>, List<ProductModelComplex50>>(lstProduct5010);
            timer.Stop();
            model.Complex50_10 = timer.ElapsedTicks;
            timer.Reset();

            // Case 4: Manual - 50 - 100
            timer.Start();
            var resultMapManual50100 = lstProduct50100.Select(x => new ProductModel50(x));
            timer.Stop();
            model.Manual50_100 = timer.ElapsedTicks;
            timer.Reset();

            // Case 5: Normal - 50 - 100
            timer.Start();
            var resultMapNormal50100 = mapper.Map<List<ProductDto50>, List<ProductModel50>>(lstProduct50100);
            timer.Stop();
            model.Normal50_100 = timer.ElapsedTicks;
            timer.Reset();

            // Case 6: Complex - 50 - 100
            timer.Start();
            var resultMapComplex50100 = mapper.Map<List<ProductDto50>, List<ProductModelComplex50>>(lstProduct50100);
            timer.Stop();
            model.Complex50_100 = timer.ElapsedTicks;
            timer.Reset();

            // Case 7: Manual - 50 - 1000
            timer.Start();
            var resultMapManual501000 = lstProduct501000.Select(x => new ProductModel50(x));
            timer.Stop();
            model.Manual50_1000 = timer.ElapsedTicks;
            timer.Reset();

            // Case 8: Normal - 50 - 1000
            timer.Start();
            var resultMapNormal501000 = mapper.Map<List<ProductDto50>, List<ProductModel50>>(lstProduct501000);
            timer.Stop();
            model.Normal50_1000 = timer.ElapsedTicks;
            timer.Reset();

            // Case 9: Complex - 50 - 1000
            timer.Start();
            var resultMapComplex501000 = mapper.Map<List<ProductDto50>, List<ProductModelComplex50>>(lstProduct501000);
            timer.Stop();
            model.Complex50_1000 = timer.ElapsedTicks;
            timer.Reset();

            // Case 10: Manual - 50 - 10000
            timer.Start();
            var resultMapManual5010000 = lstProduct5010000.Select(x => new ProductModel50(x));
            timer.Stop();
            model.Manual50_10000 = timer.ElapsedTicks;
            timer.Reset();

            // Case 11: Normal - 50 - 10000
            timer.Start();
            var resultMapNormal5010000 = mapper.Map<List<ProductDto50>, List<ProductModel50>>(lstProduct5010000);
            timer.Stop();
            model.Normal50_10000 = timer.ElapsedTicks;
            timer.Reset();

            // Case 12: Complex - 50 - 10000
            timer.Start();
            var resultMapComplex5010000 = mapper.Map<List<ProductDto50>, List<ProductModelComplex50>>(lstProduct5010000);
            timer.Stop();
            model.Complex50_10000 = timer.ElapsedTicks;
            timer.Reset();

            // Case 13: Manual - 50 - 100000
            timer.Start();
            var resultMapManual50100000 = lstProduct50100000.Select(x => new ProductModel50(x));
            timer.Stop();
            model.Manual50_100000 = timer.ElapsedTicks;
            timer.Reset();

            // Case 14: Normal - 50 - 100000
            timer.Start();
            var resultMapNormal50100000 = mapper.Map<List<ProductDto50>, List<ProductModel50>>(lstProduct50100000);
            timer.Stop();
            model.Normal50_100000 = timer.ElapsedTicks;
            timer.Reset();

            // Case 50: Complex - 50 - 100000
            timer.Start();
            var resultMapComplex50100000 = mapper.Map<List<ProductDto50>, List<ProductModelComplex50>>(lstProduct50100000);
            timer.Stop();
            model.Complex50_100000 = timer.ElapsedTicks;
            timer.Reset();

            // Case 16: Manual - 50 - 1000000
            timer.Start();
            var resultMapManual501000000 = lstProduct501000000.Select(x => new ProductModel50(x));
            timer.Stop();
            model.Manual50_1000000 = timer.ElapsedTicks;
            timer.Reset();

            // Case 17: Normal - 50 - 1000000
            timer.Start();
            var resultMapNormal501000000 = mapper.Map<List<ProductDto50>, List<ProductModel50>>(lstProduct501000000);
            timer.Stop();
            model.Normal50_1000000 = timer.ElapsedTicks;
            timer.Reset();

            // Case 18: Complex - 50 - 100000
            timer.Start();
            var resultMapComplex501000000 = mapper.Map<List<ProductDto50>, List<ProductModelComplex50>>(lstProduct501000000);
            timer.Stop();
            model.Complex50_1000000 = timer.ElapsedTicks;
            timer.Reset();

            return model;

        }
    }
}
