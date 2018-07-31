using System.Collections.Generic;

namespace GarageSale.Models
{
    public class Product
    {
        public int Id { get; }
        public string Title { get; private set; }
        public string ShortDescription { get; private set; }
        public string Description { get; private set; }
        public List<string> Images { get; private set; }
        public double Price { get; private set; }
        public string Availability { get; private set; }
        public bool Sold { get; private set; }

        public Product(int id, string title, string shortDescription, string description, List<string> images, double price, string availability, bool sold)
        {
            Id = id;
            Title = title;
            ShortDescription = shortDescription;
            Description = description;
            Images = images;
            Price = price;
            Availability = availability;
            Sold = sold;
        }
    }
}
