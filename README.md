# AreaCalculatorLibrary
Библиотека классов для расчета площади различных фигур в рамках тестового задания для Mindbox

:white_check_mark: [Unit тесты](https://github.com/T-E-K-K-I-N/AreaCalculatorLibrary/tree/master/AreaCalculatorTests/Models)    
:white_check_mark: Проверка на то, является ли треугольник прямоугольным    
:question: Легкость добавления фигур (Не совсем понял, что имелось в виду)

# Задание с SQL запросом

Для начала создадим нашу БД
```SQL
CREATE TABLE Products (Id INT PRIMARY KEY, "Title" TEXT);
CREATE TABLE Categories (Id INT PRIMARY KEY, "Category" TEXT);
CREATE TABLE ProductCategories (ProductId INT FOREIGN KEY REFERENCES Products(Id), CategoryId INT FOREIGN KEY REFERENCES Categories(Id), PRIMARY KEY (ProductId, CategoryId));
```
Заполним ее значениями

```SQL
INSERT INTO Products VALUES (1, 'Apples'), (2, 'Yogurt'), (3, 'Sour cream'), (4, 'Cucumbers');
INSERT INTO Categories VALUES (1, 'Fruit'), (2, 'Dairy');
INSERT INTO ProductCategories VALUES (1, 1), (2, 2), (3, 2);
```
Решение задачи
```SQL
SELECT P."Title", C."Category"
FROM Products P
LEFT JOIN ProductCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;
```

Итог

![image](https://user-images.githubusercontent.com/79199115/191334798-5f454912-4192-4809-a856-e36156491d13.png)
