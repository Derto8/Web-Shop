using Electronics_Shop.Models.User;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Electronics_Shop.Interfaces
{
    public interface IUsers
    {
        public IEnumerable<Users> IAllUsers { get; }
        public List<Users> UsersBuyProductsList();
        public IEnumerable<Users> GetUsers();
        public void CreateUser(Users user);
        public bool CheckUser(string Login);
        public string GetUserLogin(int Id);
        public Users AuthUser(string Login, string Password);
        public IEnumerable<Users> DataUsersIEnumerable(int Id);
        public Users DataUser(int Id);
        public void UpdateUser(Users user);
        public void DeleteUser(int Id);
    }
}
