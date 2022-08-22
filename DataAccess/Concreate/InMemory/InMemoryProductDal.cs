using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            //Oracle,Sql Server,Postgres,MongoDb
            _products = new List<Product> {
                new Product{CategoryId = 1,ProductId=1,ProductName = "Bardak",UnitsInStock = 15, UnitPrice=15 },
                new Product{CategoryId = 2,ProductId=1,ProductName = "Kamera",UnitsInStock = 3,UnitPrice=500 },
                new Product{CategoryId = 3,ProductId=2,ProductName = "Telefon",UnitsInStock = 2, UnitPrice=1500 },
                new Product{CategoryId = 4,ProductId=2,ProductName = "Klavye",UnitsInStock = 65, UnitPrice=150 },
                new Product{CategoryId = 5,ProductId=2,ProductName = "Fare",UnitsInStock = 1, UnitPrice=85 },
            };
        }
        public void Add(Product product)
        {
           _products.Add(product);
        }

        public void Delete(Product product)
        {
            //Language Integrated Queary =  LINQ
            //Lambda
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            _products.Remove(productToDelete);  
            
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;

        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId ).ToList();  
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün id'sine sahip olan ürün listedeki ürünü bul 
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.CategoryId = product.CategoryId;    

        }
    }
}
