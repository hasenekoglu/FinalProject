using Business.Concrete;
using DataAccess.Concreate.EntityFramework;
using DataAccess.Concreate.InMemory;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByCategoryId(1))
            {
                Console.WriteLine(product.ProductName);
            }
           
           
        }
    }
}