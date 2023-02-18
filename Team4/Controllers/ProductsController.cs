namespace Controllers;

using Models;

[ApiController]
[Route("/api/v1/[controller]")]
public class ProductsController
{
    [HttpGet] // GET /api/v1/products
    public async Task<ICollection<Product>> GetAll()
    {
        //code to be implemented
    }

    [HttpGet("{sortorder}")] // GET /api/v1/products?order={sortorder}
    public async Task<ICollection<Product>> SortByName([FromQuery] string sortorder)
    {
        //code to be implemented
    }

    [HttpGet("{sortprice}")] // GET /api/v1/products?priceorder={sortprice}
    public async Task<ICollection<Product>> SortByPrice([FromQuery] string sortprice)
    {
        //code to be implemented
    }

    [HttpGet("{id}")] // GET /api/v1/products/{id}
    public async Task<Product> Get(string id)
    {
        //code to be implemented
    }

    [HttpPost] // POST /api/v1/products
    public async Task<Product> Create()
    {
        //code to be implemented
    }

    [HttpPut("{id}")] // PUT /api/v1/products/{id}
    public async Task<Product> Update(string id)
    {
        //code to be implemented
    }

    [HttpPatch("{id}")] // PATCH /api/v1/products/{id}
    public async Task<Product> UpdateSome(string id)
    {
        //code to be implemented
    }

    [HttpDelete("{id}")] // DELETE /api/v1/products/{id}
    public async Task<Product> Delete(string id)
    {
        //code to be implemented
    }

}