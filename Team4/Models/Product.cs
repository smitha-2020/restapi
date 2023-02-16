namespace Team4.Models;

public class Product
{
    //primary key for Product
    public string Id { get; set; }
    public string? Title { get; set; }
    public double Price { get; set; }
    public string? Description { get; set; }   
    //FK from Category
    public string CategoryId { get; set; }
    //FK from Revew
    public string ReviewId {get; set;}
}