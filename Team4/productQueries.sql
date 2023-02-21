--display all the orders which belongs to the particular user

SELECT *
FROM orders o
JOIN orderitems items
    ON o.id = items.order_id
JOIN products p
    ON items.product_id = p.id
JOIN users u
    ON o.user_id = u.id
WHERE u.id = 3;

--Pagination

SELECT *
FROM products as prod
ORDER BY prod.price DESC
LIMIT 3
OFFSET 2;

--Display ALL

SELECT *
FROM products;

--display all products based on price in ascending order

SELECT *
FROM products as products ORDER BY  products.price ASC;

--display all products based on price in descending order

SELECT *
FROM products as products ORDER BY  products.price DESC;

--display all products based on title in descending order

SELECT * FROM products as products ORDER BY  products.title DESC;

--display all products based on title in ascending  order

SELECT * FROM products as products ORDER BY products.title ASC;

--update products title

UPDATE products  as prod SET  title = 'Macbook pro 10', price=2344 WHERE  id = 3;

--Delete product based on id

DELETE FROM products WHERE  id = 9;

--update category id

UPDATE products  as prod SET category_id = 2 WHERE id = 5;

--display all products based on a particular category

SELECT *
FROM categories as categories
JOIN products as product
ON product.category_id = categories.id
WHERE product.category_id = 2;
