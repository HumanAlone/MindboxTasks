SELECT Products.product_name, Categories.category_name 
FROM Products 
LEFT JOIN ProductCategory ON Products.id = prod_id 
LEFT JOIN Categories ON Categories.id = cat_id