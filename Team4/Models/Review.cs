namespace Team4.Models;

public class Review
{
    public string Id { get; set; }
    public string UserId { get; set; }
    public int Rating { get; set; }
    public text Comment { get; set; }
    public string ProductId { get; set; }
}