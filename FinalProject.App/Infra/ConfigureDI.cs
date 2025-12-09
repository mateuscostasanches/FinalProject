using AutoMapper;
using FinalProject.Domain.Base;
using FinalProject.App.Register;
using FinalProject.App.ViewModel;
using FinalProject.Service.Service;
using FinalProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using FinalProject.Repository.Context;
using FinalProject.Repository.Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using FinalProject.App.Others;

namespace FinalProject.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? services;
        public static IServiceProvider? serviceProvider;

        
        public static void ConfigureServices()
        {

            #region Database Configuration
            var dbConfigFile = "Config/DBConfig.txt";
            var strCon = File.ReadAllText(dbConfigFile);
            services = new ServiceCollection();
            services.AddDbContext<FinalProjectContext>(options =>
            {
                options.LogTo(Console.WriteLine);
                options.UseMySQL(strCon);
            }
            );
            #endregion

            #region Repositories
            services.AddScoped<IBaseRepository<Address>, BaseRepository<Address>>();
            services.AddScoped<IBaseRepository<Category>, BaseRepository<Category>>();
            services.AddScoped<IBaseRepository<Customer>, BaseRepository<Customer>>();
            services.AddScoped<IBaseRepository<Developer>, BaseRepository<Developer>>();
            services.AddScoped<IBaseRepository<Product>, BaseRepository<Product>>();
            services.AddScoped<IBaseRepository<Sale>, BaseRepository<Sale>>();
            services.AddScoped<IBaseRepository<SaleItem>, BaseRepository<SaleItem>>();
            #endregion

            #region Services
            services.AddScoped<IBaseService<Address>, BaseService<Address>>();
            services.AddScoped<IBaseService<Category>, BaseService<Category>>();
            services.AddScoped<IBaseService<Customer>, BaseService<Customer>>();
            services.AddScoped<IBaseService<Developer>, BaseService<Developer>>();
            services.AddScoped<IBaseService<Product>, BaseService<Product>>();
            services.AddScoped<IBaseService<Sale>, BaseService<Sale>>();
            services.AddScoped<IBaseService<SaleItem>, BaseService<SaleItem>>();
            #endregion

            #region Forms
            services.AddScoped<LoginForm, LoginForm>();
            services.AddScoped<AddressForm, AddressForm>();
            services.AddScoped<CategoryForm, CategoryForm>();
            services.AddScoped<DeveloperForm, DeveloperForm>();
            services.AddScoped<ProductForm, ProductForm>();
            services.AddScoped<CustomerForm, CustomerForm>();
            services.AddScoped<SaleForm, SaleForm>();
            #endregion

            #region AutoMapper Configuration
            services.AddSingleton(new MapperConfiguration (config => 
            {
                config.CreateMap<Address, AddressViewModel>()
                    .ForMember(d => d.CityState, d => d.MapFrom(x => $"{x.City} - {x.State}"));
                config.CreateMap<Category, CategoryViewModel>();
                config.CreateMap<Customer, CustomerViewModel>()
                    .ForMember(d => d.CityState, d => d.MapFrom(x => $"{x.Address!.City} - {x.Address!.State}"))
                    .ForMember(d => d.IdAddress, d => d.MapFrom(x => x.Address!.Id));
                config.CreateMap<Developer, DeveloperViewModel>()
                    .ForMember(d => d.CityState, d => d.MapFrom(x => $"{x.Address!.City} - {x.Address!.State}"))
                    .ForMember(d => d.IdAddress, d => d.MapFrom(x => x.Address!.Id));
                config.CreateMap<Product, ProductViewModel>()
                    .ForMember(d => d.Category, d => d.MapFrom(x => x.Category!.Name))
                    .ForMember(d => d.Developer, d => d.MapFrom(x => x.Developer!.Name));
                config.CreateMap<Sale, SaleViewModel>()
                 .ForMember(d => d.CustomerId, d => d.MapFrom(x => x.Customer!.Id))
                    .ForMember(d => d.Customer, d => d.MapFrom(x => x.Customer!.Name));
                config.CreateMap<SaleItem, SaleItemViewModel>()
                 .ForMember(d => d.ProductId, d => d.MapFrom(x => x.Product!.Id))
                 .ForMember(d => d.Product, d => d.MapFrom(x => x.Product!.Name))
                 .ForMember(d => d.DeveloperId, d => d.MapFrom(x => x.Developer!.Id))
                 .ForMember(d => d.Developer, d => d.MapFrom(x => x.Developer!.Name));
            },
                NullLoggerFactory.Instance).CreateMapper()
            );
            serviceProvider = services.BuildServiceProvider();
            #endregion
        }
    }
}
    