# MindboxTasks

Вопрос 8. Напишите библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. 
Библиотека, тесты и мэйник в одном решении.

Вопрос 9. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории».
CREATE TABLE IF NOT EXISTS "ProductCategory" (
	"prod_id"	INTEGER NOT NULL,
	"cat_id"	INTEGER NOT NULL
);
CREATE TABLE IF NOT EXISTS "Categories" (
	"id"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	"category_name"	TEXT NOT NULL UNIQUE
);
CREATE TABLE IF NOT EXISTS "Products" (
	"id"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	"product_name"	TEXT NOT NULL UNIQUE
);
INSERT INTO "ProductCategory" ("prod_id","cat_id") VALUES (1,1);
INSERT INTO "ProductCategory" ("prod_id","cat_id") VALUES (1,2);
INSERT INTO "ProductCategory" ("prod_id","cat_id") VALUES (2,3);
INSERT INTO "ProductCategory" ("prod_id","cat_id") VALUES (2,4);
INSERT INTO "Categories" ("id","category_name") VALUES (1,'Конфеты');
INSERT INTO "Categories" ("id","category_name") VALUES (2,'Вкусняшки');
INSERT INTO "Categories" ("id","category_name") VALUES (3,'Мясо');
INSERT INTO "Categories" ("id","category_name") VALUES (4,'Птица');
INSERT INTO "Products" ("id","product_name") VALUES (1,'Батончик');
INSERT INTO "Products" ("id","product_name") VALUES (2,'Курица');
INSERT INTO "Products" ("id","product_name") VALUES (3,'Грязь');

Ответ:
SELECT Products.product_name, Categories.category_name 
FROM Products 
LEFT JOIN ProductCategory ON Products.id = prod_id 
LEFT JOIN Categories ON Categories.id = cat_id


