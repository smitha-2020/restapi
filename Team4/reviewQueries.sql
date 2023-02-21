--Display ALL

SELECT *
FROM reviews;

-- Adding a row in the table

INSERT INTO reviews(user_id,rating,comment,product_id) VALUES(3,4.5,'wonderful user experience',7);

--Updating row in a reviews table

UPDATE reviews as reviews SET comment = 'Good experience' WHERE reviews.id = 10;

--Delete row in a reviews table

DELETE FROM reviews as r WHERE r.id = 11;

--display all the comments from review table for a particular product

SELECT title,comment,username
FROM products  prod
JOIN reviews review
    ON prod.id = review.product_id
JOIN users u
    ON u.id = review.user_id
WHERE prod.id = 3;

--display all the comments made by a particular user

SELECT username,comment from reviews r
JOIN users u
    ON u.id = r.user_id
where u.id = 2;

