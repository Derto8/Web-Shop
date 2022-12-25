using Electronics_Shop.Models.Product;
using Electronics_Shop.Models.User;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Electronics_Shop.DataBaseContext
{
    public class DBObjects
    {
        public static void Initial(ApplicationContext context)
        {
            //ApplicationContext context = app.ApplicationServices.GetRequiredService<ApplicationContext>();
            if (!context.Products.Any())
            {
                context.AddRange(
                        new Products
                        {
                            Name = "Iphone 10",
                            Description = "Устаревшая модель! Покупай 13-ый айфон!",
                            Image = "/ProductsImages/56546461.jpg",
                            Price = 50000,
                        },
                        new Products
                        {
                            Name = "Iphone 11",
                            Description = "Не очень красивый, и не очень мощный!",
                            Image = "/ProductsImages/38289546.jpg",
                            Price = 70000,
                        }, 
                        new Products
                        {
                            Name = "Iphone 12",
                            Description = "Красивый, но не мощный!",
                            Image = "/ProductsImages/32222623.jpg",
                            Price = 90000,
                        }, 
                        new Products
                        {
                            Name = "Iphone 13",
                            Description = "Самый красивый и самый мощный!",
                            Image = "/ProductsImages/4.jpg",
                            Price = 120000,
                        }
                    );
            }

            if (!context.User.Any())
            {
                context.AddRange(

                        new Users
                        {
                            Login = "Derto93",
                            Password = "12345",
                            FIO = "Ощепков Александр Олегович",
                            Email = "aooshchepkov@permaviat.ru",
                            Phone = "+79925541264",
                            Image = "/UsersAvatars/9853417donut.png",
                            Status = "User"
                        },

                        new Users
                        {
                            Login = "root",
                            Password = "root",
                            FIO = "Полозов Николай Владимирович",
                            Email = "kolya.polozov@inbox.ru",
                            Phone = "+79922161570",
                            Image = "/UsersAvatars/tekst-pesni-tomas-shelbi-kambulat.jpg",
                            Status = "Adm"
                        }
                    );
            }
            if (!context.BuyProducts.Any())
            {

            }

            context.SaveChanges();
        }
    }
}
