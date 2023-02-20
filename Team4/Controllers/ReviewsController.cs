namespace Controllers;

using Models;

[ApiController]
[Route("/api/v1/[controller]")]
public class ReviewsController
{
    [HttpGet] // GET /api/v1/reviews
    public async Task<ICollection<Review>> GetAll()
    {
        //code to be implemented
    }

    [HttpGet("{userid}")] // GET /api/v1/reviews?userid={userid}
    public async Task<ICollection<Review>> GetUserReviews([FromQuery] string userid)
    {
        //code to be implemented
    }

    [HttpGet("{pid}")] // GET /api/v1/reviews/{pid}/comments
    public async Task<ICollection<Review>> GetProductComments([FromRoute] string pid)
    {
        //code to be implemented
    }

    [HttpGet("{id}")] // GET /api/v1/reviews/{id}
    public async Task<Review> Get(string id)
    {
        //code to be implemented
    }

    [HttpPost] // POST /api/v1/reviews
    public async Task<Review> Create()
    {
        //code to be implemented
    }

    [HttpPut("{id}")] // PUT /api/v1/reviews/{id}
    public async Task<Review> Update(string id)
    {
        //code to be implemented
    }

    [HttpPatch("{id}")] // PATCH /api/v1/reviews/{id}
    public async Task<Review> UpdateSome(string id)
    {
        //code to be implemented
    }

    [HttpDelete("{id}")] // DELETE /api/v1/reviews/{id}
    public async Task<Review> Delete(string id)
    {
        //code to be implemented
    }
}