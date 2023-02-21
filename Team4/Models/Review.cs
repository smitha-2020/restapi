namespace Team4.Models;

public class Review
{
    public string Id { get; set; }
    [Required]
    public string UserId { get; set; }
    [Required]
    [Range(0, 5, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
    public int Rating { get; set; }
    [Required]
    [StringLength(150, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
    public string Comment { get; set; }
    [Required]
    public string ProductId { get; set; }

    public Review(string userId, int rating, string comment, string productId)
    {
        UserId = userId;
        Rating = rating;
        Comment = comment;
        ProductId = productId;
    }
}