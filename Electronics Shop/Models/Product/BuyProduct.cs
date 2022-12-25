using Electronics_Shop.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Electronics_Shop.Models.Product
{
    public class BuyProduct : BaseModel
    {
        public int? UsersId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }

        public Users Users { get; set; }
    }
}
