using Electronics_Shop.Models.Product;
using System.Collections;
using System.Collections.Generic;

namespace Electronics_Shop.Interfaces
{
    public interface IBuyProducts
    {
        public IEnumerable<BuyProduct> IAllBuyProducts { get; }
        public IEnumerable<BuyProduct> BuyProductsSpecificUser(int Id);
        public BuyProduct GetOneBuyProduct(int IdProduct, int UserId);
        public void CreateBuyProduct();
        public void CreateBuyProductAdm(BuyProduct product);
        public void UpdateBuyProduct(BuyProduct buyProduct);
        public void DeleteBuyProduct(int Id);
    }
}
