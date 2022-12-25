using Electronics_Shop.Interfaces;
using Electronics_Shop.Models.Product;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace Electronics_Shop.Controllers
{
    public class BuyProductsController : Controller
    {
        private IBuyProducts IBuyProducts;
        public BuyProductsController(IBuyProducts iBuyProducts)
        {
            IBuyProducts = iBuyProducts;
        }

        public IActionResult ViewUserProducts()
        {
            if(Startup.IdUser != null && Startup.StatusUser == "User")
            {
                IEnumerable<BuyProduct> obj = IBuyProducts.BuyProductsSpecificUser((int)Startup.IdUser);
                return View(obj);
            }
            return RedirectToAction("ErrorStatus", "Home");
        }

        public IActionResult AddBuyProduct()
        {
            if (Startup.IdUser != null && Startup.StatusUser == "User")
            {
                IBuyProducts.CreateBuyProduct();
                Startup.ShopCart.Clear();
                return RedirectToAction("UserAccount", "User");
            }
            return RedirectToAction("ErrorStatus", "Home");
        }


    }
}
