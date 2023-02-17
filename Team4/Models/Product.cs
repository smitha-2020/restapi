namespace Team4.Models;

public class Product
{
    public string Title { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public string CategoryId { get; set; }
    public string Image { get; set; }

    public Product(string title, double price, string description, string catId, string image)
    {
        Title = title;
        Price = price;
        Description = description;
        CategoryId = catId;
        Image = image;
    }
}