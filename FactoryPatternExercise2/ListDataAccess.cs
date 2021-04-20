using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() { Name = "List Something 1", Price = 1.99m },
            new Product() { Name = "List Something 2", Price = 7.99m },
            new Product() { Name = "List Something 3", Price = 2.99m },
            new Product() { Name = "List Something 4", Price = 5.99m },
            new Product() { Name = "List Something 5", Price = 3.99m },
        };

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from the list database");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a list database");
        }
    }
}
