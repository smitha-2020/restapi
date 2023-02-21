namespace Team4.Models;

public class Product
{
    public string Id { get; set; }
    [Required]
    [StringLength(50, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
    public string Title { get; set; }
    [Required]
    public double Price { get; set; }
    [Required]
    [StringLength(150, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
    public string Description { get; set; }
    [Required]
    public string CategoryId { get; set; }
    [Required]
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