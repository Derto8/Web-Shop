using Electronics_Shop.Interfaces;
using Electronics_Shop.Models.Product;
using Electronics_Shop.Models.User;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;

namespace Electronics_Shop.Controllers
{
    public class UsersListController : Controller
    {
        private IUsers IUsers;
        private IBuyProducts IBuyProducts;
        private IWebHostEnvironment webHostEnvironment;
        private Random randomNamePhoto = new Random();
        public UsersListController(IUsers users, IBuyProducts IBuyProducts, IWebHostEnvironment webHostEnvironment)
        {
            this.IUsers = users;
            this.IBuyProducts = IBuyProducts;
            this.webHostEnvironment = webHostEnvironment;
        }

        public IActionResult ListUsers()
        {
            if (Startup.StatusUser == "Adm")
            {
                IEnumerable<Users> obj = IUsers.GetUsers();
                return View(obj);
            }
            return RedirectToAction("ErrorStatus", "Home");
        }

        public IActionResult GetIdUser(int idUser)
        {
            if(Startup.StatusUser == "Adm")
            {
                Startup.IdUserSetings = idUser;
                return Json(Startup.IdUserSetings);
            }
            return RedirectToAction("ErrorStatus", "Home");
        }

        [HttpGet]
        public IActionResult ChangeUserSettings()
        {
            if (Startup.StatusUser == "Adm")
            {
                Users user = IUsers.DataUser(Startup.IdUserSetings);
                return View(user);
            }
            return RedirectToAction("ErrorStatus", "Home");
        }

        [HttpPost]
        public IActionResult ChangeUserSettings(string Login, string Password, string FIO, string EMail, string Phone, IFormFile files, string Status)
        {
            Users users;

            if (Startup.StatusUser == "Adm")
            {
                string file;

                var uploads = Path.Combine(webHostEnvironment.ContentRootPath, "UsersAvatars");
                var filePath = Path.Combine(uploads, files.FileName);

                using (Bitmap btm = new Bitmap(Image.FromFile($"{filePath}"), 300, 300))
                {
                    string fileName = $"{randomNamePhoto.Next(1, 9999999)}" + $"{files.FileName}";
                    var newUpload = Path.Combine(webHostEnvironment.WebRootPath, "UsersAvatars");
                    file = Path.Combine(newUpload, fileName);
                    btm.Save($"{file}");
                }
                string[] nameFile = file.Split("\\");

                users = new Users()
                {
                    Id = Startup.IdUserSetings,
                    Login = Login,
                    Password = Password,
                    FIO = FIO,
                    Email = EMail,
                    Phone = Phone,
                    Image = nameFile.Last(),
                    Status = Status
                };

                string UserLogin = IUsers.GetUserLogin(Startup.IdUserSetings);
                if (UserLogin == Login)
                {
                    if (ModelState.IsValid)
                    {
                        IUsers.UpdateUser(users);
                        return RedirectToAction("ListUsers");
                    }
                    return View(users);
                }

                if(Password != null)
                {
                    if (IUsers.CheckUser(Login))
                    {
                        if (ModelState.IsValid)
                        {
                            IUsers.UpdateUser(users);
                            return RedirectToAction("ListUsers");
                        }
                        return View(users);
                    }
                }
                ViewBag.Error = "Введите пароль!";
                return View(users);
            }
            return RedirectToAction("ErrorStatus", "Home");
        }

        public IActionResult DeleteUser()
        {
            if (Startup.StatusUser == "Adm")
            {
                IUsers.DeleteUser(Startup.IdUserSetings);
                return RedirectToAction("ListUsers");
            }
            return RedirectToAction("ErrorStatus", "Home");
        }
        [HttpGet]
        public IActionResult CreateUser()
        {
            if(Startup.StatusUser == "Adm")
            {
                return View();
            }
            return RedirectToAction("ErrorStatus", "Home");
        }

        [HttpPost]
        public IActionResult CreateUser(string Login, string Password, string FIO, string EMail, string Phone, IFormFile files, string Status)
        {
            Users users;

            if (Startup.StatusUser == "Adm")
            {
                string file;
                var uploads = Path.Combine(webHostEnvironment.ContentRootPath, "UsersAvatars");
                var filePath = Path.Combine(uploads, files.FileName);

                using (Bitmap btm = new Bitmap(Image.FromFile($"{filePath}"), 300, 300))
                {
                    string fileName = $"{randomNamePhoto.Next(1, 9999999)}" + $"{files.FileName}";
                    var newUpload = Path.Combine(webHostEnvironment.WebRootPath, "UsersAvatars");
                    file = Path.Combine(newUpload, fileName);
                    btm.Save($"{file}");
                }
                string[] nameFile = file.Split("\\");

                users = new Users()
                {
                    Id = Startup.IdUserSetings,
                    Login = Login,
                    Password = Password,
                    FIO = FIO,
                    Email = EMail,
                    Phone = Phone,
                    Image = nameFile.Last(),
                    Status = Status
                };

                if (IUsers.CheckUser(Login))
                {
                    if (ModelState.IsValid)
                    {
                        IUsers.CreateUser(users);
                        return RedirectToAction("ListUsers");
                    }
                }
                ViewBag.Error = "Пользователь с таким логином уже существует!";
                return View(users);
            }
            return RedirectToAction("ErrorStatus", "Home");
        }

        public IActionResult ShowBuyProducts()
        {
            if(Startup.StatusUser == "Adm")
            {
                IEnumerable<BuyProduct> userProducts = IBuyProducts.BuyProductsSpecificUser(Startup.IdUserSetings);
                return View(userProducts);
            }
            return RedirectToAction("ErrorStatus", "Home");
        }

        public IActionResult GetIdProductUser(int idProductUser)
        {
            if (Startup.StatusUser == "Adm")
            {
                Startup.IdProductUser = idProductUser;
                return Json(Startup.IdProductUser);
            }
            return RedirectToAction("ErrorStatus", "Home");
        }

        public IActionResult DeleteUserBuyProduct()
        {
            if (Startup.StatusUser == "Adm")
            {
                IBuyProducts.DeleteBuyProduct(Startup.IdProductUser);
                return RedirectToAction("ShowBuyProducts");
            }
            return RedirectToAction("ErrorStatus", "Home");
        }

        [HttpGet]
        public IActionResult ChangeUserBuyProduct()
        {
            if (Startup.StatusUser == "Adm")
            {
                BuyProduct userProduct = IBuyProducts.GetOneBuyProduct(Startup.IdProductUser, Startup.IdUserSetings);
                return View(userProduct);
            }
            return RedirectToAction("ErrorStatus", "Home");
        }

        [HttpPost]
        public IActionResult ChangeUserBuyProduct(string Name, double Price, IFormFile files)
        {
            BuyProduct buyProduct;
            if (Startup.StatusUser == "Adm")
            {
                string file;
                var uploads = Path.Combine(webHostEnvironment.ContentRootPath, "ProductsImages");
                var filePath = Path.Combine(uploads, files.FileName);

                using (Bitmap btm = new Bitmap(Image.FromFile($"{filePath}"), 300, 300))
                {
                    string fileName = $"{randomNamePhoto.Next(1, 9999999)}" + $"{files.FileName}";
                    var newUpload = Path.Combine(webHostEnvironment.WebRootPath, "ProductsImages");
                    file = Path.Combine(newUpload, fileName);
                    btm.Save($"{file}");
                }
                string[] nameFile = file.Split("\\");

                buyProduct = new BuyProduct()
                {
                    Id = Startup.IdProductUser,
                    Name = Name,
                    Price = Price,
                    Image = nameFile.Last()
                };

                if (ModelState.IsValid)
                {
                    IBuyProducts.UpdateBuyProduct(buyProduct);
                    return RedirectToAction("ShowBuyProducts");
                }
                return View(buyProduct);
            }
            return RedirectToAction("ErrorStatus", "Home");
        }

        [HttpGet]
        public IActionResult CreateBuyProduct()
        {
            if (Startup.StatusUser == "Adm")
                return View();
            return RedirectToAction("ErrorStatus", "Home");
        }

        [HttpPost]
        public IActionResult CreateBuyProduct(string Name, double Price, IFormFile files)
        {
            BuyProduct buyProduct;
            if (Startup.StatusUser == "Adm")
            {
                string file;
                var uploads = Path.Combine(webHostEnvironment.ContentRootPath, "ProductsImages");
                var filePath = Path.Combine(uploads, files.FileName);

                using (Bitmap btm = new Bitmap(Image.FromFile($"{filePath}"), 300, 300))
                {
                    string fileName = $"{randomNamePhoto.Next(1, 9999999)}" + $"{files.FileName}";
                    var newUpload = Path.Combine(webHostEnvironment.WebRootPath, "ProductsImages");
                    file = Path.Combine(newUpload, fileName);
                    btm.Save($"{file}");
                }
                string[] nameFile = file.Split("\\");

                buyProduct = new BuyProduct()
                {
                    Name = Name,
                    Price = Price,
                    Image = nameFile.Last(),
                    UsersId = Startup.IdUserSetings
                };

                if (ModelState.IsValid)
                {
                    IBuyProducts.CreateBuyProductAdm(buyProduct);
                    return RedirectToAction("ShowBuyProducts");
                }
                return View(buyProduct);
            }
            return RedirectToAction("ErrorStatus", "Home");
        }
    }
}
