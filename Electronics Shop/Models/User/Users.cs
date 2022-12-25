using Electronics_Shop.Models.Product;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Electronics_Shop.Models.User
{
    public class Users : BaseModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string FIO { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Image { get; set; }
        public string Status { get; set; }
        public List<BuyProduct> BuyProducts { get; set; }
    }
}
