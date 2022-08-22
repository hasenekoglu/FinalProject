using Business.Concrete;
using DataAccess.Concreate.EntityFramework;
using DataAccess.Concreate.InMemory;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle
    public class Program
    {
        static void Main(string[] args)
        {
            //Data Transforming
           // CategoryTest();
           // ProductTest();
        }

        private static void CategoryTest()
        {
           
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByCategoryId(1))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}