using Electronics_Shop.DataBaseContext;
using Electronics_Shop.Interfaces;
using Electronics_Shop.Models.Product;
using System.Collections.Generic;
using System.Linq;

namespace Electronics_Shop.Repository
{
    public class ProductsRepository : IProducts
    {
        private ApplicationContext applicationContext { get; set; }
        public ProductsRepository(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }
        public IEnumerable<Products> IAllProducts => applicationContext.Products;

        public void CreateProduct(Products product)
        {
            Products newProduct = new Products();
            newProduct.Name = product.Name;
            newProduct.Description = product.Description;
            newProduct.Price = product.Price;
            newProduct.Image = "/ProductsImages/" + product.Image;
            //добавление в список на сохранение в базу данных экземпляр новый класса Products
            applicationContext.Products.Add(newProduct);
            //сохранение в базу данных
            applicationContext.SaveChanges();
        }

        public void UpdateProduct(Products product)
        {
            //из базы данных при помощи запроса выгружаем данные продукта, который необходимо изменить
            Products newProduct = applicationContext.Products.Where(c => c.Id == Startup.IdProduct).FirstOrDefault();
            newProduct.Name = product.Name;
            newProduct.Description = product.Description;
            newProduct.Price = product.Price;
            newProduct.Image = "/ProductsImages/" + product.Image;
            //сохранение в базу данных
            applicationContext.SaveChanges();
        }

        public void DeleteProduct(int Id)
        {
            //из базы данных при помощи запроса, выгружаем данные продукта, которые нужно удалить
            Products obj = applicationContext.Products.Where(c => c.Id == Id).FirstOrDefault();
            //удаляем запись продукта из базы данныхЫ
            applicationContext.Remove(obj);
            //сохраняем изменения в базу данных
            applicationContext.SaveChanges();
        }
        public Products DataProduct(int Id)
        {
            Products products = applicationContext.Products.Where(c => c.Id == Id).FirstOrDefault();
            return products;
        }
    }
}
