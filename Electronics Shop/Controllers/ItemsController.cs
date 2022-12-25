using DocumentFormat.OpenXml.Spreadsheet;
using Electronics_Shop.Interfaces;
using Electronics_Shop.Models.Product;
using Electronics_Shop.Models.User;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using static System.Net.WebRequestMethods;

namespace Electronics_Shop.Controllers
{
    public class ItemsController : Controller
    {
        private IWebHostEnvironment webHostEnvironment;
        private IProducts IProducts { get; set; }
        private Random randomNamePhoto = new Random();


        public ItemsController(IProducts iProducts, IWebHostEnvironment webHostEnvironment)
        {
            IProducts = iProducts;
            this.webHostEnvironment = webHostEnvironment;
        }

        public IActionResult List()
        {
            var products = IProducts.IAllProducts;
            return View(products);
        }

       
        public IActionResult GetIdProduct(int idProduct)
        {
            if(Startup.StatusUser == "Adm")
            {
                Startup.IdProduct = idProduct;
                return Json(idProduct);
            }
            return RedirectToAction("ErrorStatus", "Home");

        }

        [HttpGet]
        public IActionResult ChangeProduct()
        {
            if(Startup.StatusUser == "Adm")
            {
                Products products = IProducts.DataProduct(Startup.IdProduct);
                return View(products);
            }
            return RedirectToAction("ErrorStatus", "Home");
        }

        [HttpPost]
        public IActionResult ChangeProduct(string Name, string Description, double Price, IFormFile files)
        {
            //изменять товар может только администратор
            if (Startup.StatusUser == "Adm")
            {
                string file;
                Products products;
                //определние пути к корневой папке
                var uploads = Path.Combine(webHostEnvironment.ContentRootPath, "ProductsImages");
                var filePath = Path.Combine(uploads, files.FileName);

                //блок изменения размера изображения
                using (Bitmap btm = new Bitmap(Image.FromFile($"{filePath}"), 300, 300))
                {
                    string fileName = $"{randomNamePhoto.Next(1, 9999999)}" + $"{files.FileName}";
                    var newUpload = Path.Combine(webHostEnvironment.WebRootPath, "ProductsImages");
                    file = Path.Combine(newUpload, fileName);
                    //сохранение изображения
                    btm.Save($"{file}");
                }
                string[] nameFile = file.Split("\\");

                //присвоение полям класса введённых пользователем данных
                products = new Products()
                {
                    Name = Name,
                    Description = Description,
                    Price = Price,
                    Image = nameFile.Last()
                };
                //проверка модели на валидность
                if (ModelState.IsValid)
                {
                    //функция изменения данных в базу данных
                    IProducts.UpdateProduct(products);
                    //переход пользователя на страницу товаров
                    return RedirectToAction("List", "Items");
                }
            }
            //если статус пользователя не является администратором, то пользователь переходит
            //на страницу ошибки
            return RedirectToAction("ErrorStatus", "Home");
        }

        public IActionResult DeleteProduct()
        {
            //удалить запись товара может только администратор
            if (Startup.StatusUser == "Adm")
            {
                //функция удаления записи из базы данных
                IProducts.DeleteProduct(Startup.IdProduct);
                //переход пользователя на страницу товаров
                return RedirectToAction("List", "Items");
            }
            //если статус пользователя не является администратором, то пользователь переходит
            //на страницу ошибки
            return RedirectToAction("ErrorStatus", "Home");
        }

        public IActionResult ShopCart(int idProduct)
        {
            Startup.ShopCart.Add(new Products(IProducts.IAllProducts.Where(x => x.Id == idProduct).FirstOrDefault()));
            return Json(Startup.ShopCart);
        }

        public IActionResult ViewShopCart()
        {
            if(Startup.StatusUser == "User")
            {
                List<Products> obj = Startup.ShopCart;
                return View(obj);
            }
            return RedirectToAction("ErrorStatus", "Home");
        }

        public IActionResult DeleteItemShopCart(int IdProductDel)
        {
            var indexDel = Startup.ShopCart.FindIndex(p => p.Id == IdProductDel);

            Startup.ShopCart.RemoveAt(indexDel);
            return RedirectToAction("ViewShopCart", "Items");
        }

        [HttpGet]
        public IActionResult AddItem()
        {
            if (Startup.StatusUser == "Adm")
                return View();
            return RedirectToAction("ErrorStatus", "Home");
        }

        [HttpPost]
        public IActionResult AddItem(string Name, string Description, double Price, IFormFile files)
        {
            //добавлять товар может только администратор
            if (Startup.StatusUser == "Adm")
            {
                string file;
                Products products;
                //определние пути к корневой папке
                var uploads = Path.Combine(webHostEnvironment.ContentRootPath, "ProductsImages");
                var filePath = Path.Combine(uploads, files.FileName);

                //блок изменения размера изображения
                using (Bitmap btm = new Bitmap(Image.FromFile($"{filePath}"), 300, 300))
                {
                    string fileName = $"{randomNamePhoto.Next(1, 9999999)}" + $"{files.FileName}";
                    var newUpload = Path.Combine(webHostEnvironment.WebRootPath, "ProductsImages");
                    file = Path.Combine(newUpload, fileName);
                    //сохранение изображения
                    btm.Save($"{file}");
                }
                string[] nameFile = file.Split("\\");

                //присвоение полям класса введённых пользователем данных
                products = new Products()
                {
                    Name = Name,
                    Description = Description,
                    Price = Price,
                    Image = nameFile.Last()
                };
                //проверка модели на валидность
                if (ModelState.IsValid)
                {
                    //функция добавления данных в базу данных
                    IProducts.CreateProduct(products);
                    //переход пользователя на страницу товаров
                    return RedirectToAction("List", "Items");
                }
            }
            //если статус пользователя не является администратором, то пользователь переходит
            //на страницу ошибки
            return RedirectToAction("ErrorStatus", "Home");
        }
    }
}
