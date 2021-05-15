using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AM.infrastructure.Responsitory.Dtos;
using AM.infrastructure.Service.Model;
using AM.infrastructure.Service.ProductBsl;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AM.infrastructure.Responsitory.Dao;

namespace AutoMapperExample
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            // Register DI
            services.AddScoped<IProductBsl, ProductBsl>();
            services.AddScoped<IProductDao, ProductDao>();

            // Register AutoMapper 
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AllowNullCollections = true; //
                cfg.ForAllMaps((map, exp) =>
                {
                    foreach (var unmappedPropertyName in map.GetUnmappedPropertyNames())
                        exp.ForMember(unmappedPropertyName, opt => opt.Ignore());
                });

                // Register Model & Dto will be map here.
                cfg.CreateMap<ProductDto15, ProductModel15>();
                cfg.CreateMap<ProductDto50, ProductModel50>();
                cfg.CreateMap<ProductDto15, ProductModelComplex15>()
                .ForMember(t => t.Id, dis => dis.MapFrom(src => src.ProductId))
                .ForMember(t => t.Name, dis => dis.MapFrom(src => src.ProductName))
                .ForMember(t => t.ProductPrice, dis => dis.MapFrom(src => src.Price))
                .ForMember(t => t.CreatedDateModel, dis => dis.MapFrom(src => src.CreatedDate))
                .ForMember(t => t.DateManufactoryModel, dis => dis.MapFrom(src => src.DateManufactory))
                .ForMember(t => t.DateExpriedModel, dis => dis.MapFrom(src => src.DateExpried))
                .ForMember(t => t.ModelProperties1, dis => dis.MapFrom(src => src.Properties1))
                .ForMember(t => t.ModelProperties2, dis => dis.MapFrom(src => src.Properties2))
                .ForMember(t => t.ModelProperties3, dis => dis.MapFrom(src => src.Properties3))
                .ForMember(t => t.ModelProperties4, dis => dis.MapFrom(src => src.Properties4))
                .ForMember(t => t.ModelProperties5, dis => dis.MapFrom(src => src.Properties5))
                .ForMember(t => t.ModelProperties6, dis => dis.MapFrom(src => src.Properties6))
                .ForMember(t => t.ModelProperties7, dis => dis.MapFrom(src => src.Properties7))
                .ForMember(t => t.ModelProperties8, dis => dis.MapFrom(src => src.Properties8))
                .ForMember(t => t.ModelProperties9, dis => dis.MapFrom(src => src.Properties9));



                cfg.CreateMap<ProductDto50, ProductModelComplex50>()
                .ForMember(t => t.Id, dis => dis.MapFrom(src => src.ProductId))
                .ForMember(t => t.Name, dis => dis.MapFrom(src => src.ProductName))
                .ForMember(t => t.ProductPrice, dis => dis.MapFrom(src => src.Price))
                .ForMember(t => t.CreatedDateModel, dis => dis.MapFrom(src => src.CreatedDate))
                .ForMember(t => t.DateManufactoryModel, dis => dis.MapFrom(src => src.DateManufactory))
                .ForMember(t => t.DateExpriedModel, dis => dis.MapFrom(src => src.DateExpried))
                .ForMember(t => t.ModelProperties1, dis => dis.MapFrom(src => src.Properties1))
                .ForMember(t => t.ModelProperties2, dis => dis.MapFrom(src => src.Properties2))
                .ForMember(t => t.ModelProperties3, dis => dis.MapFrom(src => src.Properties3))
                .ForMember(t => t.ModelProperties4, dis => dis.MapFrom(src => src.Properties4))
                .ForMember(t => t.ModelProperties5, dis => dis.MapFrom(src => src.Properties5))
                .ForMember(t => t.ModelProperties6, dis => dis.MapFrom(src => src.Properties6))
                .ForMember(t => t.ModelProperties7, dis => dis.MapFrom(src => src.Properties7))
                .ForMember(t => t.ModelProperties8, dis => dis.MapFrom(src => src.Properties8))
                .ForMember(t => t.ModelProperties9, dis => dis.MapFrom(src => src.Properties9))
                .ForMember(t => t.ModelProperties10, dis => dis.MapFrom(src => src.Properties10))
                .ForMember(t => t.ModelProperties11, dis => dis.MapFrom(src => src.Properties11))
                .ForMember(t => t.ModelProperties12, dis => dis.MapFrom(src => src.Properties12))
                .ForMember(t => t.ModelProperties13, dis => dis.MapFrom(src => src.Properties13))
                .ForMember(t => t.ModelProperties14, dis => dis.MapFrom(src => src.Properties14))
                .ForMember(t => t.ModelProperties15, dis => dis.MapFrom(src => src.Properties15))
                .ForMember(t => t.ModelProperties16, dis => dis.MapFrom(src => src.Properties16))
                .ForMember(t => t.ModelProperties17, dis => dis.MapFrom(src => src.Properties15))
                .ForMember(t => t.ModelProperties18, dis => dis.MapFrom(src => src.Properties18))
                .ForMember(t => t.ModelProperties19, dis => dis.MapFrom(src => src.Properties19))
                .ForMember(t => t.ModelProperties20, dis => dis.MapFrom(src => src.Properties20))
                .ForMember(t => t.ModelProperties21, dis => dis.MapFrom(src => src.Properties21))
                .ForMember(t => t.ModelProperties22, dis => dis.MapFrom(src => src.Properties22))
                .ForMember(t => t.ModelProperties23, dis => dis.MapFrom(src => src.Properties23))
                .ForMember(t => t.ModelProperties24, dis => dis.MapFrom(src => src.Properties24))
                .ForMember(t => t.ModelProperties25, dis => dis.MapFrom(src => src.Properties25))
                .ForMember(t => t.ModelProperties26, dis => dis.MapFrom(src => src.Properties26))
                .ForMember(t => t.ModelProperties27, dis => dis.MapFrom(src => src.Properties27))
                .ForMember(t => t.ModelProperties28, dis => dis.MapFrom(src => src.Properties28))
                .ForMember(t => t.ModelProperties29, dis => dis.MapFrom(src => src.Properties29))
                .ForMember(t => t.ModelProperties30, dis => dis.MapFrom(src => src.Properties30))
                .ForMember(t => t.ModelProperties31, dis => dis.MapFrom(src => src.Properties31))
                .ForMember(t => t.ModelProperties32, dis => dis.MapFrom(src => src.Properties32))
                .ForMember(t => t.ModelProperties33, dis => dis.MapFrom(src => src.Properties33))
                .ForMember(t => t.ModelProperties34, dis => dis.MapFrom(src => src.Properties34))
                .ForMember(t => t.ModelProperties35, dis => dis.MapFrom(src => src.Properties35))
                .ForMember(t => t.ModelProperties36, dis => dis.MapFrom(src => src.Properties36))
                .ForMember(t => t.ModelProperties37, dis => dis.MapFrom(src => src.Properties37))
                .ForMember(t => t.ModelProperties38, dis => dis.MapFrom(src => src.Properties38))
                .ForMember(t => t.ModelProperties39, dis => dis.MapFrom(src => src.Properties39))
                .ForMember(t => t.ModelProperties40, dis => dis.MapFrom(src => src.Properties40))
                .ForMember(t => t.ModelProperties41, dis => dis.MapFrom(src => src.Properties41))
                .ForMember(t => t.ModelProperties42, dis => dis.MapFrom(src => src.Properties42));


            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);


            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
