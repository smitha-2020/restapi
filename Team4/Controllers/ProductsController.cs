namespace Controllers;

using Models.Product;

[ApiController]
[Route("/api/v1/[controller]")]
public class ProductsController
{
    [HttpGet] // GET /api/v1/products
    public async Task<ICollection<Product>> GetAll()
    {
        //code to be implemented
    }

    [HttpGet("{order}")] // GET /api/v1/products?orderby={order}
    public async Task<ICollection<Product>> SortByName([FromQuery] string order)
    {
        //code to be implemented
    }

    [HttpGet("{price}")] // GET /api/v1/products?orderbyprice={price}
    public async Task<ICollection<Product>> SortByPrice([FromQuery] string price)
    {
        //code to be implemented
    }

    [HttpGet("{offset}")] // GET /api/v1/products?offset={offset}&limit={limit}
    public async Task<ICollection<Product>> Pagination([FromQuery] string offset, [FromQuery] string limit)
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
    public async Task<Product> Update(Product p,[FromRoute] int i)
    {
        //code to be implemented
    }

    [HttpPatch("{id}")] // PATCH /api/v1/products/{id}
    public async Task<Product> UpdateSome(Product p,[FromRoute] string id)
    {
        //code to be implemented
    }

    [HttpDelete("{id}")] // DELETE /api/v1/products/{id}
    public async Task<Product> Delete(string id)
    {
        //code to be implemented
    }
}