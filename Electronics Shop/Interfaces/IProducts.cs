using Electronics_Shop.Models.Product;
using System.Collections.Generic;

namespace Electronics_Shop.Interfaces
{
    public interface IProducts
    {
        public IEnumerable<Products> IAllProducts { get; }
        public void CreateProduct(Products product);
        public void UpdateProduct(Products product);
        public void DeleteProduct(int Id);
        public Products DataProduct(int Id);
    }
}
