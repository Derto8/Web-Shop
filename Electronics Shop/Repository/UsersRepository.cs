using Electronics_Shop.DataBaseContext;
using Electronics_Shop.Interfaces;
using Electronics_Shop.Models.Product;
using Electronics_Shop.Models.User;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Electronics_Shop.Repository
{
    public class UsersRepository : IUsers
    {
        private ApplicationContext applicationContext;
        public UsersRepository(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public IEnumerable<Users> IAllUsers => applicationContext.User;
        
        public IEnumerable<Users> GetUsers()
        {
            IEnumerable<Users> obj = applicationContext.User.Where(u => u.Id != Startup.IdUser).ToList();
            return obj;
        }

        public void CreateUser(Users user)
        {
            Users newUser = new Users();
            newUser.Login = user.Login;
            newUser.Password = user.Password;
            newUser.FIO = user.FIO;
            newUser.Email = user.Email;
            newUser.Phone = user.Phone;
            newUser.Image = "/UsersAvatars/" + user.Image;
            newUser.Status = user.Status;

            //добавление в список на сохранение в базу данных экземпляр новый класса Users
            applicationContext.User.Add(newUser);
            //сохранение в базу данных
            applicationContext.SaveChanges();
        }
        public void DeleteUser(int Id)
        {
            Users obj = applicationContext.User.Where(d => d.Id == Id).FirstOrDefault();
            IEnumerable<BuyProduct> boughtProducts = applicationContext.BuyProducts.Include(p => p.Users).Where(p => p.UsersId == Id).ToList();
            if (boughtProducts.Any())
                foreach(var pr in boughtProducts)
                {
                    applicationContext.Remove(pr);
                }
            applicationContext.Remove(obj);
            applicationContext.SaveChanges();
        }

        public void UpdateUser(Users user)
        {
            Users obj = applicationContext.User.Where(u => u.Id == user.Id).FirstOrDefault();
            obj.Login = user.Login;
            obj.Password = user.Password;
            obj.FIO = user.FIO;
            obj.Email = user.Email;
            obj.Phone = user.Phone;
            obj.Image = "/UsersAvatars/" + user.Image;
            obj.Status = user.Status;
            applicationContext.SaveChanges();
        }

        public bool CheckUser(string Login)
        {
            //запрос к базе данных на выборку пользователя с логином из аргумента функции
            Users obj = applicationContext.User.FirstOrDefault(c => c.Login == Login);
            if (obj != null)
                return false;
            return true;
        }

        public Users AuthUser(string Login, string Password)
        {
            //запрос к базе данных на выборку пользователя с логином и паролем из аргументов функции
            Users obj = applicationContext.User.FirstOrDefault(c => c.Login == Login && c.Password == Password);
            if (obj != null)
                return obj;
            else
                return null;
        }

        public IEnumerable<Users> DataUsersIEnumerable(int Id)
        {
            IEnumerable<Users> obj = applicationContext.User.Where(c => c.Id == Id);
            return obj;
        }

        public Users DataUser(int id)
        {
            Users obj = applicationContext.User.FirstOrDefault(c => c.Id == id);
            return obj;
        }

        public List<Users> UsersBuyProductsList()
        {
            //запрос к базе данных на выборку списка пользователей и их купленных продуктов
            List<Users> users = applicationContext.User.Include(u => u.BuyProducts).Where(u => u.Status == "User").ToList();
            return users;
        }

        public string GetUserLogin(int Id)
        {
            string user = applicationContext.User.Where(c => c.Id == Id).Select(c=> c.Login).FirstOrDefault();
            return user;
        }
    }
}
