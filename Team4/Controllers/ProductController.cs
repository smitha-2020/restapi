namespace Controllers;

using Models;

public class ProductControler
{
    [HttpGet("")] // GET /api/v1/products
    public async Task<ICollection<Product>> GetAll()
    {
        //code to be implemented
    }

    [HttpGet("{id}")] // GET /api/v1/products/{id}
    public async Task<Product> Get(string id)
    {
        //code to be implemented
    }

    [HttpPost("")] // POST /api/v1/products
    public async Task<Product> Create()
    {
        //code to be implemented
    }

    [HttpPut("")] // PUT /api/v1/products/{id}
    public async Task<Product> Update(string id)
    {
        //code to be implemented
    }

    [HttpPatch("")] // PATCH /api/v1/products/{id}
    public async Task<Product> UpdateSome(string id)
    {
        //code to be implemented
    }

    [HttpDelete("{id}")] // DELETE /api/v1/products/{id}
    public async Task<Product> Delete(string id)
    {
        //code to be implemented
    }

    [HttpGet("{id}")] // GET /api/v1/products/{id}
    public async Task<ICollection<Product>> GetByCategoryID(string id)
    {
        //code to be implemented
    }
}