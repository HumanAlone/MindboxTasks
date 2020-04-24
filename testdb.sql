BEGIN TRANSACTION;
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
COMMIT;
