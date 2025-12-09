
using AutoMapper;
using System.Text.Json;
using FinalProject.Domain.Base;
using FinalProject.Domain.Entities;
using FinalProject.Service.Service;
using FinalProject.Service.Validators;
using FinalProject.Repository.Context;
using FinalProject.Repository.Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;


namespace FinalProject.Test
{

    [TestClass]
    public sealed class ServiceTest
    {
        private ServiceCollection? services;

        #region Configurations of Services
        public ServiceProvider ConfigureServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<FinalProjectContext>();
            services.AddScoped<IBaseRepository<Address>, BaseRepository<Address>>();
            services.AddScoped<IBaseRepository<Category>, BaseRepository<Category>>();
            services.AddScoped<IBaseRepository<Customer>, BaseRepository<Customer>>();
            services.AddScoped<IBaseRepository<Developer>, BaseRepository<Developer>>();
            services.AddScoped<IBaseRepository<Product>, BaseRepository<Product>>();
            services.AddScoped<IBaseRepository<SaleItem>, BaseRepository<SaleItem>>();
            services.AddScoped<IBaseRepository<Sale>, BaseRepository<Sale>>();


            services.AddScoped<IBaseService<Address>, BaseService<Address>>();
            services.AddScoped<IBaseService<Category>, BaseService<Category>>();
            services.AddScoped<IBaseService<Customer>, BaseService<Customer>>();
            services.AddScoped<IBaseService<Developer>, BaseService<Developer>>();
            services.AddScoped<IBaseService<Product>, BaseService<Product>>();
            services.AddScoped<IBaseService<SaleItem>, BaseService<SaleItem>>();
            services.AddScoped<IBaseService<Sale>, BaseService<Sale>>();

            services.AddSingleton(
              new MapperConfiguration(
                config => {
                    config.CreateMap<Address, Address>();
                    config.CreateMap<Category, Category>();
                    config.CreateMap<Customer, Customer>();
                    config.CreateMap<Developer, Developer>();
                    config.CreateMap<Product, Product>();
                    config.CreateMap<SaleItem, SaleItem>();
                    config.CreateMap<Sale, Sale>();
                }, NullLoggerFactory.Instance).CreateMapper()
              );
            return services.BuildServiceProvider();
        }
        #endregion

        #region Test Service Method
        [TestMethod]
        public void TestFinalProjectService()
        {
            var serviceProvider = ConfigureServices();

            #region AddressServiceTest
            var addressService = serviceProvider.GetService<IBaseService<Address>>();
            var address1 = new Address
            {
                City = "Mongaqua",
                State = "Sao Paulo"
            };
            var address2 = new Address
            {
                City = "Los Angeles",
                State = "California"
            };
            var addedAddress1 = addressService!.Add<Address, Address, AddressValidator>(address1);
            var addedAddress2 = addressService!.Add<Address, Address, AddressValidator>(address2);

            var allAddress = addressService.Get<Address>();
            if (allAddress != null)
            {
                foreach (var c in allAddress)
                {
                    Console.WriteLine("Address: " + JsonSerializer.Serialize(c));
                }
            }
            #endregion

            #region CategoryServiceTest
            var categoryService = serviceProvider.GetService<IBaseService<Category>>();
            var category = new Category
            {
                Name = "Multiplayer"
            };
            var addedCategory = categoryService!.Add<Category, Category, CategoryValidator>(category);

            var allCategories = categoryService.Get<Category>();
            if (allCategories != null)
            {
                foreach (var c in allCategories)
                {
                    Console.WriteLine("Categories: " + JsonSerializer.Serialize(c));
                }
            }
            #endregion

            #region CustomerServiceTest
            var customerService = serviceProvider.GetService<IBaseService<Customer>>();
            var customer = new Customer
            {
                Name = "Bruno Lara",
                Email = "brunolara123@gmail.com",
                Password = "Mijodeindio@456",
                RegisterDate = DateTime.Now,
                Address = address1 
            };
            var addedCustomer = customerService!.Add<Customer, Customer, CustomerValidator>(customer);

            var allCustomers = customerService.Get<Customer>();
            if (allCustomers != null)
            {
                foreach (var c in allCustomers)
                {
                    Console.WriteLine("Customers: " + JsonSerializer.Serialize(c));
                }
            }
            #endregion

            #region DeveloperServiceTest
            var developerService = serviceProvider.GetService<IBaseService<Developer>>();
            var developer = new Developer
            {
                Name = "Valve",
                Email = "valvesuport@gmail.com",
                Password = "ValveandSteamisfuck$123",
                RegisterDate = DateTime.Now,
                Address = address2 
            };
            var addedDeveloper = developerService!.Add<Developer, Developer, DeveloperValidator>(developer);

            var allDevelopers = developerService.Get<Developer>();
            if (allDevelopers != null)
            {
                foreach (var c in allDevelopers)
                {
                    Console.WriteLine("Developers: " + JsonSerializer.Serialize(c));
                }
            }
            #endregion

            #region ProductServiceTest
            var productService = serviceProvider.GetService<IBaseService<Product>>();
            var product = new Product
            {
                Name = "Counter Strike 2",
                Description = "Shoot in 3th person multiplayer",
                Category = category,
                Developer = developer,
                ReleaseDate = DateTime.Now,
                Price = 59.99m
            };
            var addedProduct = productService!.Add<Product, Product, ProductValidator>(product);

            var allProducts = productService.Get<Product>();
            if (allProducts != null)
            {
                foreach (var c in allProducts)
                {
                    Console.WriteLine("Products: " + JsonSerializer.Serialize(c));
                }
            }
            #endregion

        }
        #endregion

    }

}