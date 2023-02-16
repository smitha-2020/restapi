namespace Team4.Models;

public class Product
{
    public string Id { get; set; }
    public string? Title { get; set; }
    public double Price { get; set; }
    public string? Description { get; set; }
    public string CategoryId { get; set; }
    public string Image { get; set; }
}