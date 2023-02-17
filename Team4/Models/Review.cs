namespace Team4.Models;

public class Review
{
    public string UserId { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; }
    public string ProductId { get; set; }

    public Review(string userId, int rating, string comment, string productId)
    {
        UserId = userId;
        Rating = rating;
        Comment = comment;
        ProductId = productId;
    }
}