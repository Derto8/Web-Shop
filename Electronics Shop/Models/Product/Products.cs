namespace Electronics_Shop.Models.Product
{
    public class Products : BaseModel
    {
        public Products() { }
        public Products(Products products)
        {
            Id = products.Id;
            Name = products.Name;
            Description = products.Description;
            Price = products.Price;
            Image = products.Image;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
    }
}
