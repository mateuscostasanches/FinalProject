
using System.Text.Json;
using FinalProject.Domain.Entities;
using FinalProject.Repository.Context;

namespace FinalProject.Test
{
    [TestClass]
    public sealed class RepositoryTest
    {

        [TestMethod]
        public void TestAddress()
        {
            using (var context = new FinalProjectContext())
            {
                Console.WriteLine("Connected!");

                var address1 = new Address(1, "Sao Paulo", "Buritama");
                var address2 = new Address(2, "Sao Paulo", "Aracatuba");
                var address3 = new Address(3, "California", "Los Angeles");

                context.Addresses.Add(address1);
                context.Addresses.Add(address2);
                context.Addresses.Add(address3);

                context.SaveChanges();
                Console.WriteLine("Insert Done!");

                foreach (var cat in context.Addresses)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cat));
                }
                Console.WriteLine("Address List Done!");
            }
        }

        [TestMethod]
        public void TestCategory()
        {
            using (var context = new FinalProjectContext())
            {
                Console.WriteLine("Connected!");
                var category1 = new Category(1, "Indie");
                var category2 = new Category(2, "Soulslike");
                var category3 = new Category(3, "Casual");

                context.Categories.Add(category1);
                context.Categories.Add(category2);
                context.Categories.Add(category3);

                context.SaveChanges();
                Console.WriteLine("Insert Done!");

                foreach (var cat in context.Categories)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cat));
                }
                Console.WriteLine("Category List Done!");
            }

        }

        [TestMethod]
        public void TestCustomer()
        {
            using (var context = new FinalProjectContext())
            {
                Console.WriteLine("Connected!");
                var address4 = new Address(4, "Sao Paulo", "Valparaiso");
                var address5 = new Address(5, "Sao Paulo", "Brejo Alegre");
                var customer1 = new Customer(1, "Renan Avelino", "renanzinhogamer@gmail.com", "senha123@", address4, DateTime.Now.Date);
                var customer2 = new Customer(2, "Flavio Grigas", "eogrigasne@grigas.com", "irmaodoigor12", address5, DateTime.Now.Date);

                context.Addresses.Add(address4);
                context.Addresses.Add(address5);
                context.Customers.Add(customer1);
                context.Customers.Add(customer2);
                context.SaveChanges();
                Console.WriteLine("Insert Done!");

                foreach (var cat in context.Customers)
                {
                    Console.Write(JsonSerializer.Serialize(cat));
                }
                Console.WriteLine("Customer List Done!");
            }

        }

        [TestMethod]
        public void TestDeveloper()
        {
            using (var context = new FinalProjectContext())
            {
                var address = new Address(6, "Sao Paulo", "Sao Paulo");
                var developer = new Developer(2, "Toca do Page", "indianistas@gmail.com", "tocadopage123", address, DateTime.Now.Date);

                context.Addresses.Add(address);
                context.Developers.Add(developer);
                context.SaveChanges();
                Console.WriteLine("Insert Done!");

                foreach (var cat in context.Developers)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cat));
                }
                Console.WriteLine("Developer List Done!");
            }

        }

        [TestMethod]
        public void TestProduct()
        {
            using (var context = new FinalProjectContext())
            {
                var category = new Category(4, "RPG");
                var address = new Address(7, "Sao Paulo", "Sao Paulo");
                var developer = new Developer(1, "Dumativa", "dumativa@dumativa.com", "dumativagames123", address, DateTime.Now.Date);
                var product = new Product(1, "Enigma do Medo", "RPG Horror Game", 59.99m, DateTime.Now.Date, category, developer );

                context.Categories.Add(category);
                context.Addresses.Add(address);
                context.Developers.Add(developer);
                context.Products.Add(product);
                context.SaveChanges();
                Console.WriteLine("Insert Done!");

                foreach (var cat in context.Developers)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cat));
                }
                Console.WriteLine("Product List Done!");
            }

        }

    }

}
