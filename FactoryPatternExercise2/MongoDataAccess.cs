using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    class MongoDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() { Name = "Mongo Something 1", Price = 1.99m },
            new Product() { Name = "Mongo Something 2", Price = 7.99m },
            new Product() { Name = "Mongo Something 3", Price = 2.99m },
            new Product() { Name = "Mongo Something 4", Price = 5.99m },
            new Product() { Name = "Mongo Something 5", Price = 3.99m },
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from the mongo database");

            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a mongo database");
        }
    }
}
