using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EFCore;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EFCategoryRepository());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EFProductRepository());

            var result = productManager.GetProductDetails();
            var responseMessage = result.Success;

            if (responseMessage)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName + " / " + item.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


            
        }
    }
}
