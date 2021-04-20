using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database do you want to use?");
            Console.WriteLine("Type list for a static list.");
            Console.WriteLine("Type sql for a sql db list.");
            Console.WriteLine("Type mongo for a mongo db list.");
            var response = Console.ReadLine();

            IDataAccess db = DataAcessFactory.GetDataAccessType(response);

            List<Product> products = db.LoadData();

            Console.WriteLine();

            Console.WriteLine("Here are your products");
            for (int index = 0; index < products.Count; index++)
            {
                Console.WriteLine($"Product Name: {products[index].Name} | " +
                    $"Product Price: {products[index].Price,0:c}");
            }

            Console.WriteLine();
        }
    }
}
