# Backend project

This assignment requires teamwork. Your team has been assigned one of two topics:

1. Library management system
Main features:

    - Users
    - Books
    - Authors
    - Carts
    - Optional: Reviews
    - etc ...

2. E-Commerce Platform
Main features:

    - Users
    - Products
    - Categories
    - Carts
    - Optional: Reviews
    - etc ...

---

Product:
// GET /api/v1/products - Get all products.
// GET /api/v1/products?orderby={order} - Get all products in orderby name
// GET /api/v1/products?orderbyprice={price} - Get all products in orderby price
// GET /api/v1/products?serchby={productname} - Get all the products that match the search.
// GET /api/v1/products?offset={offset}&limit={limit} - Pagination
// GET /api/v1/products/{id} - Get product by specified id
// POST /api/v1/products - Add product
// PUT /api/v1/products/{id} - Update Product
// PATCH /api/v1/products/{id} - Update some Product details based on the specified id.
// DELETE /api/v1/products/{id} - Delete a product based on id. (edited)

Review
// GET /api/v1/reviews - Get all Reviews
// GET /api/v1/reviews?userid={userid} - Get all the reviews for particular user.
// GET /api/v1/reviews/{pid}/comments - Get all comments for the particular product.
// GET /api/v1/reviews/{id} - Get specific product.
// POST /api/v1/reviews - Add Review.
// PUT /api/v1/reviews/{id} - Update Review.
// PATCH /api/v1/reviews/{id} - Update some review properties.
// DELETE /api/v1/reviews/{id} - Delete Review.

## Requirements

*For team assignment, only 1 member in the team should fork the repo. Then, admin can invite other members to contribute in the same repo. Remember to have develop branch before merging to main. And each feature/schema/bug/issue should have it's own branch, and taken by only 1 member. Before making any new branch, make sure you run `git pull` to avoid the conflicts with the remote repo.*

1. Design the API endpoints, following REST API architecture. Only design file needed (either in .txt or diagram, screenshot)
2. Create ERD diagram for database


## Team members
- Timo Baader
- Femi Adesola Oyinloye
- Nhan  Mai
- Smitha Kamanth