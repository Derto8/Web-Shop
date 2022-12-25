using ClosedXML.Excel;
using Electronics_Shop.Interfaces;
using Electronics_Shop.Models.User;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace Electronics_Shop.Controllers
{
    public class UserController : Controller
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private Users users;
        public IUsers IUser;
        private Random randomNamePhoto = new Random();

        public UserController(IUsers IUser, IWebHostEnvironment webHostEnvironment)
        {
            this.IUser = IUser;
            this.webHostEnvironment = webHostEnvironment;
        }
        public IActionResult UserAccount()
        {
            if (Startup.IdUser != null)
            {
                IEnumerable<Users> obj = IUser.DataUsersIEnumerable((int)Startup.IdUser);
                return View(obj);
            }
            return RedirectToAction("ErrorStatus", "Home");
        }

        [HttpGet]
        public IActionResult ChangeUserSettings()
        {
            if (Startup.IdUser != null && Startup.StatusUser == "User")
            {
                Users obj = IUser.DataUser((int)Startup.IdUser);
                return View(obj);
            }
            return RedirectToAction("ErrorStatus", "Home");
        }

        [HttpPost]
        public IActionResult ChangeUserSettings(string Login, string Password, string PasswordConfirm, string FIO, string EMail, string Phone, IFormFile files)
        {
            Users users;

            if (Startup.IdUser != null && Startup.StatusUser == "User")
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
                    Id = (int)Startup.IdUser,
                    Login = Login,
                    Password = Password,
                    FIO = FIO,
                    Email = EMail,
                    Phone = Phone,
                    Image = nameFile.Last(),
                    Status = "User"
                };

                if (Password == PasswordConfirm && Password != null)
                {
                    if (Password.Length >= 5 && Password.Length <= 20)
                    {
                        if (Login.Length >= 5 && Login.Length <= 20)
                        {
                            string UserLogin = IUser.GetUserLogin((int)Startup.IdUser);
                            if (UserLogin == Login)
                            {
                                if (ModelState.IsValid)
                                {
                                    IUser.UpdateUser(users);
                                    return RedirectToAction("UserAccount");
                                }
                                return View(users);
                            }

                            if (IUser.CheckUser(Login))
                            {
                                if (ModelState.IsValid)
                                {
                                    IUser.UpdateUser(users);
                                    return RedirectToAction("UserAccount");
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
            return RedirectToAction("ErrorStatus", "Home");
        }

        public IActionResult DeleteUser()
        {
            if(Startup.IdUser != null && Startup.StatusUser == "User")
            {
                IUser.DeleteUser((int)Startup.IdUser);
                Startup.IdUser = null;
                Startup.StatusUser = null;
                Startup.ShopCart.Clear();
                return RedirectToAction("List", "Items");
            }
            return RedirectToAction("ErrorStatus", "Home");

        }

        public IActionResult ExitUser()
        {
            Startup.IdUser = null;
            Startup.StatusUser = null;
            Startup.ShopCart.Clear();
            return RedirectToAction("List", "Items");
        }

        [HttpGet]
        public IActionResult ChangeAdminSettings()
        {
            if (Startup.IdUser != null && Startup.StatusUser == "Adm")
            {
                Users obj = IUser.DataUser((int)Startup.IdUser);
                return View(obj);
            }
            return RedirectToAction("ErrorStatus", "Home");
        }

        [HttpPost]
        public IActionResult ChangeAdminSettings(string Login, string Password, string FIO, string EMail, string Phone, IFormFile files)
        {
            if (Startup.IdUser != null && Startup.StatusUser == "Adm")
            {
                string file;
                var uploads = Path.Combine(webHostEnvironment.ContentRootPath, "UsersAvatars");
                var filePath = Path.Combine(uploads, files.FileName);

                using ( Bitmap btm = new Bitmap(Image.FromFile($"{filePath}"), 300, 300))
                {
                    string fileName = $"{randomNamePhoto.Next(1, 9999999)}" + $"{files.FileName}";
                    var newUpload = Path.Combine(webHostEnvironment.WebRootPath, "UsersAvatars");
                    file = Path.Combine(newUpload, fileName);
                    btm.Save($"{file}");
                }
                string[] nameFile = file.Split("\\");

                users = new Users()
                {
                    Id = (int)Startup.IdUser,
                    Login = Login,
                    Password = Password,
                    FIO = FIO,
                    Email = EMail,
                    Phone = Phone,
                    Image = nameFile.Last(),
                    Status = "Adm"
                };

                string UserLogin = IUser.GetUserLogin((int)Startup.IdUser);
                if (UserLogin == Login)
                {
                    if (ModelState.IsValid)
                    {
                        IUser.UpdateUser(users);
                        return RedirectToAction("UserAccount");
                    }
                    return View(users);
                }

                if(Password != null)
                {
                    if (IUser.CheckUser(Login))
                    {
                        if (ModelState.IsValid)
                        {
                            IUser.UpdateUser(users);
                            return RedirectToAction("UserAccount");
                        }
                    }
                    ViewBag.Error = "Ошибка ввода данных";
                    return View(users);
                }
                ViewBag.Error = "Введите пароль!";
                return View(users);
            }
            return RedirectToAction("ErrorStatus", "Home");
        }

        public IActionResult ExportExcel()
        {
            //создание переменной класса
            using(XLWorkbook workbook = new XLWorkbook(XLEventTracking.Disabled))
            {
                //объявление таблицы
                var worksheet = workbook.Worksheets.Add("BuyProducts");

                worksheet.ColumnWidth = 40;

                //заголовки
                worksheet.Cell("A1").Value = "Пользователь";
                worksheet.Cell("B1").Value = "Список покупок";
                worksheet.Row(1).Style.Font.Bold = true;

                //запрос к базе данных, забираем все покупки пользователей
                List<Users> users = IUser.UsersBuyProductsList();

                int carriageProduct = 2;
                int carriageUser = 0;
                //добавление в таблицу данных
                foreach (var user in users)
                {
                    worksheet.Cell(carriageUser + 2, 1).Value = users[carriageUser].Login;
                    carriageProduct = 2;
                    foreach (var buyProduct in user.BuyProducts)
                    {
                        worksheet.Cell(carriageUser + 2, carriageProduct).Value = buyProduct.Name;
                        carriageProduct++;
                    }
                    carriageUser++;
                }

                //сохранение Excel файла и скачивание Excel-файла
                using(var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    stream.Flush();

                    //скачать Excel-файл
                    return new FileContentResult(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
                    {
                        FileDownloadName = $"СписокПокупок_{DateTime.UtcNow.ToShortDateString()}.xlsx"
                    };
                }

            }
        }
    }
}
