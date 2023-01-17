```mysql
SELECT products.name AS 'Product Name', categories.name AS 'Category Name'
FROM products
LEFT JOIN product_categories ON products.id = product_categories.product_id
LEFT JOIN categories ON product_categories.category_id = categories.id;

```