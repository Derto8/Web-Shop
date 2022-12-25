using Electronics_Shop.Interfaces;
using Electronics_Shop.Models.User;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Drawing;
using System.IO;
using System.Linq;

namespace Electronics_Shop.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private Random randomNamePhoto = new Random();
        public IUsers IUsers { get; set; }
        public AuthenticationController(IUsers IUsers, IWebHostEnvironment webHostEnvironment)
        {
            this.IUsers = IUsers;
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        //функция регистрации
        public IActionResult Registration(string Login, string Password, string PasswordConfirm, string FIO, string EMail, string Phone, IFormFile files)
        {
            Users users;
            string Status = "User";
            string file;

            //блоки try/catch для присвоения полям класса введённых пользователем данных 
            try
            {
                //определние пути к корневой папке
                var uploads = Path.Combine(webHostEnvironment.ContentRootPath, "UsersAvatars");
                var filePath = Path.Combine(uploads, files.FileName);

                //блок изменения размера изображения
                using (Bitmap btm = new Bitmap(Image.FromFile($"{filePath}"), 300, 300))
                {
                    string fileName = $"{randomNamePhoto.Next(1, 9999999)}" + $"{files.FileName}";
                    var newUpload = Path.Combine(webHostEnvironment.WebRootPath, "UsersAvatars");
                    file = Path.Combine(newUpload, fileName);
                    //сохранение изображения
                    btm.Save($"{file}");
                }
                string[] nameFile = file.Split("\\");

                //присвоение полям класса введённых пользователем данных
                users = new Users()
                {
                    Login = Login,
                    Password = Password,
                    FIO = FIO,
                    Email = EMail,
                    Phone = Phone,
                    Image = nameFile.Last(),
                    Status = Status
                };
            }
            catch
            {
                //присвоение полям класса введённых пользователем данных
                users = new Users()
                {
                    Login = Login,
                    Password = Password,
                    FIO = FIO,
                    Email = EMail,
                    Phone = Phone,
                    Image = "",
                    Status = Status
                };
            }

            //проверки данных на валидность
            if (Password == PasswordConfirm)
            {
                if(Password.Length >= 5 && Password.Length <= 20)
                {
                    if(Login.Length >= 5 && Login.Length <= 20)
                    {
                        if (IUsers.CheckUser(Login))
                        {
                            if (ModelState.IsValid)
                            {
                                //функция добавления данных в базу данных
                                IUsers.CreateUser(users);
                                //переход на страницу авторизации
                                return RedirectToAction("Authorization");
                            }
                        }
                        ViewBag.Error = "Пользователь с таким логином уже существует!";
                        return View(users);
                    }
                    ViewBag.Error = "Ваш логин меньше 5 символов, или больше 20 символов!";
                    return View(users);
                }
                ViewBag.Error = "Ваш пароль меньше 5 символов, или больше 20 символов!";
                return View(users);
            }
            ViewBag.Error = "Введённые пароли не совпадают!";
            return View(users);
        }

        [HttpGet]
        public IActionResult Authorization()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Authorization(string Login, string Password)
        {
            //проверка существование логина и пароля в базе данных
            var user = IUsers.AuthUser(Login, Password);
            //существует ли такой пользователь
            if (user != null)
                if (ModelState.IsValid)
                {
                    //присвоение статической переменной IdUser идентификатора пользователя
                    Startup.IdUser = user.Id;
                    //присвоение статической переменной StatusUser статуса пользователя
                    Startup.StatusUser = user.Status;
                    return RedirectToAction("UserAccount", "User");
                }
            ViewBag.Error = "Некорректный логин или пароль";
            return View();
        }
    }
}
