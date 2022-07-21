CREATE DATABASE NaumovMindBox;
GO
USE NaumovMindBox;

BEGIN TRANSACTION;

CREATE TABLE [products] (
	id INT PRIMARY KEY IDENTITY,
	[name] varchar(255) NOT NULL
);
GO
CREATE TABLE [categories] (
	id INT PRIMARY KEY IDENTITY,
	[name] varchar(255) NOT NULL
);
GO
CREATE TABLE [product_category] (
	id INT PRIMARY KEY IDENTITY,
	product_id int NOT NULL,
	category_id int NOT NULL,
	CONSTRAINT FK_category FOREIGN KEY (category_id)  REFERENCES [categories] (id),
	CONSTRAINT FK_product FOREIGN KEY (product_id)  REFERENCES [products] (id)
);
GO

INSERT INTO [products] (name) VALUES ('Молоко'),('Клей'),('Печенье'), ('Стакан');
INSERT INTO	[categories] (name) VALUES ('Продукты'), ('Важное'), ('Быт');
GO

INSERT INTO [product_category] (product_id, category_id) VALUES (1,1), (1,2), (2,2), (2,3), (3,1), (3,2);
GO

SELECT [products].[name], [categories].[name] FROM [products] 
LEFT JOIN [product_category] ON [products].id = product_id
LEFT JOIN  [categories] ON [categories].id = category_id;
GO

COMMIT;