namespace Controllers;

using Models;

public class ProductControler
{
    [HttpGet("")]
    public async Task<ICollection<Product>> GetAll()
    {
        //code to be implemented
    }

    [HttpGet("{id}")]
    public async Task<Product> Get(string id)
    {
        //code to be implemented
    }

    [HttpPost("")]
    public async Task<Product> Create()
    {
        //code to be implemented
    }

    [HttpPut("")]
    public async Task<Product> Update(string id)
    {
        //code to be implemented
    }

    [HttpPatch("")]
    public async Task<Product> UpdateSome(string id)
    {
        //code to be implemented
    }

    [HttpDelete("{id}")]
    public async Task<Product> Delete(string id)
    {
        //code to be implemented
    }

    [HttpGet("{id}")]
    public async Task<ICollection<Product>> GetByCategoryID(string id)
    {
        //code to be implemented
    }
}