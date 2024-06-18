Т.к. отношение "многие ко многим" вероятно должна быть третья связующая таблица ProductsCategories. Тогда запрос такой:

SELECT Products.Name AS 'Продукт', Categories.Name AS 'Категория' FROM Products
LEFT JOIN ProductsCategories ON Products.Id = ProductsCategories.ProductId
LEFT JOIN Categories ON Categories.Id = ProductsCategories.CategoryId;

Если такой таблицы нет, предполагаю повторение продуктов с разными категориями, хоть так быть не должно. Тогда:
SELECT Products.name, Categories.name FROM Products LEFT JOIN Categories ON Products.CategoryId = Categories.Id
