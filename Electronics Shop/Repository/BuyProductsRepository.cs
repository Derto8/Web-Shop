using DocumentFormat.OpenXml.InkML;
using Electronics_Shop.DataBaseContext;
using Electronics_Shop.Interfaces;
using Electronics_Shop.Models.Product;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Electronics_Shop.Repository
{
    public class BuyProductsRepository : IBuyProducts
    {
        private ApplicationContext applicationContext;

        public BuyProductsRepository(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public IEnumerable<BuyProduct> IAllBuyProducts => applicationContext.BuyProducts;

        public IEnumerable<BuyProduct> BuyProductsSpecificUser(int Id)
        {
            IEnumerable<BuyProduct> objects = applicationContext.BuyProducts.Include(p => p.Users).Where(p => p.UsersId == Id).ToList();
            return objects;
        }

        public void CreateBuyProduct()
        {
            foreach(var p in Startup.ShopCart)
            {
                BuyProduct newBuyProduct = new BuyProduct();
                newBuyProduct.Name = p.Name;
                newBuyProduct.Price = p.Price;
                newBuyProduct.Image = p.Image;
                newBuyProduct.Date = DateTime.Now;
                newBuyProduct.UsersId = Startup.IdUser;

                applicationContext.BuyProducts.Add(newBuyProduct);
                applicationContext.SaveChanges();
            }
        }

        public void DeleteBuyProduct(int Id)
        {
            BuyProduct obj = applicationContext.BuyProducts.Where(c => c.Id == Id).FirstOrDefault();
            applicationContext.Remove(obj);
            applicationContext.SaveChanges();
        }

        public void UpdateBuyProduct(BuyProduct buyProduct)
        {
            BuyProduct updateProduct = applicationContext.BuyProducts.Where(c => c.Id == Startup.IdProductUser).FirstOrDefault();
            updateProduct.Name = buyProduct.Name;
            updateProduct.Price = buyProduct.Price;
            updateProduct.Image = "/ProductsImages/" + buyProduct.Image;
            updateProduct.Date = DateTime.Now;
            applicationContext.SaveChanges();
        }

        public BuyProduct GetOneBuyProduct(int IdProduct, int UserId)
        {
            BuyProduct buyProduct = applicationContext.BuyProducts.Where(c => c.Id == IdProduct && c.UsersId == UserId).FirstOrDefault();
            return buyProduct;
        }

        public void CreateBuyProductAdm(BuyProduct product)
        {
            BuyProduct newBuyProduct = new BuyProduct();
            newBuyProduct.Name = product.Name;
            newBuyProduct.Price = product.Price;
            newBuyProduct.Image = "/ProductsImages/" + product.Image;
            newBuyProduct.Date = DateTime.Now;
            newBuyProduct.UsersId = product.UsersId;

            applicationContext.BuyProducts.Add(newBuyProduct);
            applicationContext.SaveChanges();
        }
    }
}
