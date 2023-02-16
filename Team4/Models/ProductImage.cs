namespace Team4.Models;

class ProductImage
{
    //primary key for ProductImage
    public int Id { get; set; }
    public string Image { get; set; }
    //FK from Product
    public int ProductId { get; set; }
}