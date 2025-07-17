-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Хост: MySQL-8.2
-- Время создания: Апр 22 2025 г., 11:00
-- Версия сервера: 8.2.0
-- Версия PHP: 8.3.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `VavilovBD`
--

-- --------------------------------------------------------

--
-- Структура таблицы `Categories`
--

CREATE TABLE `Categories` (
  `CategoryID` int NOT NULL,
  `CategoryName` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `Departments`
--

CREATE TABLE `Departments` (
  `DepartmentID` int NOT NULL,
  `DepartmentName` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `Departments`
--

INSERT INTO `Departments` (`DepartmentID`, `DepartmentName`) VALUES
(1, 'Бухгалтерия'),
(2, 'Отдел продаж'),
(3, 'ИТ'),
(4, 'Логистика');

-- --------------------------------------------------------

--
-- Структура таблицы `Employees`
--

CREATE TABLE `Employees` (
  `EmployeeID` int NOT NULL,
  `EmployeeName` varchar(100) NOT NULL,
  `Role` varchar(50) DEFAULT NULL,
  `DepartmentID` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `InventoryRecords`
--

CREATE TABLE `InventoryRecords` (
  `ProductID` int NOT NULL,
  `LocationID` int NOT NULL,
  `CurrentQuantity` int NOT NULL,
  `ReorderThreshold` int NOT NULL,
  `LastUpdateDate` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `InventoryRecords`
--

INSERT INTO `InventoryRecords` (`ProductID`, `LocationID`, `CurrentQuantity`, `ReorderThreshold`, `LastUpdateDate`) VALUES
(1, 1, 100, 50, '26/03/20204'),
(1, 2, 1, 1, NULL),
(2, 1, 200, 100, '26/03/20204'),
(3, 2, 500, 250, '26/03/20204'),
(4, 2, 150, 100, '26/03/20204'),
(5, 1, 80, 50, '26/03/20204');

-- --------------------------------------------------------

--
-- Структура таблицы `Orders`
--

CREATE TABLE `Orders` (
  `OrderID` int NOT NULL,
  `VendorID` int DEFAULT NULL,
  `OrderDate` date NOT NULL,
  `TotalAmount` decimal(10,2) DEFAULT NULL,
  `Status` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `Orders`
--

INSERT INTO `Orders` (`OrderID`, `VendorID`, `OrderDate`, `TotalAmount`, `Status`) VALUES
(1, 1, '2023-01-15', 500.00, 'В обработке'),
(2, 2, '2023-02-10', 1200.00, 'Завершен'),
(3, 1, '2025-04-19', 1.00, 'Завершен');

-- --------------------------------------------------------

--
-- Структура таблицы `Order_Details`
--

CREATE TABLE `Order_Details` (
  `OrderID` int NOT NULL,
  `ProductID` int NOT NULL,
  `Quantity` int NOT NULL,
  `UnitPrice` decimal(10,2) NOT NULL,
  `TotalPrice` decimal(10,2) GENERATED ALWAYS AS ((`Quantity` * `UnitPrice`)) STORED
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `Order_Details`
--

INSERT INTO `Order_Details` (`OrderID`, `ProductID`, `Quantity`, `UnitPrice`) VALUES
(1, 1, 20, 10.50),
(1, 2, 30, 5.00),
(1, 3, 1, 1.00),
(2, 3, 50, 50.00),
(2, 4, 20, 20.00);

-- --------------------------------------------------------

--
-- Структура таблицы `Products`
--

CREATE TABLE `Products` (
  `ProductID` int NOT NULL,
  `Name` varchar(100) NOT NULL,
  `ShelfLife` int DEFAULT NULL,
  `CategoryID` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `Products`
--

INSERT INTO `Products` (`ProductID`, `Name`, `ShelfLife`, `CategoryID`) VALUES
(1, 'Ручкаfffff', 3700, NULL),
(2, 'Карандаш', 730, NULL),
(3, 'Листы бумаги', 180, NULL),
(4, 'Блокнот', 365, NULL),
(5, 'Маркер', 180, NULL),
(6, 'Шапка', 300, NULL),
(7, 'gfdg', 766, NULL),
(8, 'jhfjhgj', 765, NULL),
(10, 'ААААААААА', 1, NULL),
(11, '7777', 7777, NULL),
(13, '444444', 3, NULL),
(18, 'пвапавп', 56465, NULL),
(19, '6666666666', 66666, NULL);

-- --------------------------------------------------------

--
-- Структура таблицы `Product_Department`
--

CREATE TABLE `Product_Department` (
  `RequirementID` int NOT NULL,
  `DepartmentID` int DEFAULT NULL,
  `ProductID` int DEFAULT NULL,
  `RequiredQuantity` int NOT NULL,
  `RequiredDate` date NOT NULL,
  `Priority` int DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `Product_Department`
--

INSERT INTO `Product_Department` (`RequirementID`, `DepartmentID`, `ProductID`, `RequiredQuantity`, `RequiredDate`, `Priority`) VALUES
(1, 1, 1, 30, '2023-03-01', 1),
(2, 2, 2, 50, '2023-03-05', 2),
(3, 3, 3, 100, '2023-04-01', 1),
(4, 4, 4, 20, '2023-03-10', 3),
(5, 1, 5, 10, '2023-03-15', 2);

-- --------------------------------------------------------

--
-- Структура таблицы `Product_Vendor`
--

CREATE TABLE `Product_Vendor` (
  `ProductID` int NOT NULL,
  `VendorID` int NOT NULL,
  `Price` decimal(10,2) NOT NULL,
  `DeliveryTime` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `Product_Vendor`
--

INSERT INTO `Product_Vendor` (`ProductID`, `VendorID`, `Price`, `DeliveryTime`) VALUES
(1, 1, 10.50, 3),
(1, 2, 10.00, 5),
(2, 1, 5.00, 3),
(2, 2, 30.00, 1),
(3, 2, 50.00, 7),
(4, 3, 20.00, 4),
(5, 1, 15.00, 3),
(5, 2, 50.00, 5),
(5, 3, 14.50, 2);

-- --------------------------------------------------------

--
-- Структура таблицы `PurchaseRequests`
--

CREATE TABLE `PurchaseRequests` (
  `RequestID` int NOT NULL,
  `DepartmentID` int DEFAULT NULL,
  `RequestDate` date NOT NULL,
  `Status` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `StorageLocations`
--

CREATE TABLE `StorageLocations` (
  `LocationID` int NOT NULL,
  `LocationName` varchar(100) NOT NULL,
  `Address` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `StorageLocations`
--

INSERT INTO `StorageLocations` (`LocationID`, `LocationName`, `Address`) VALUES
(1, 'Главный склад', 'ул. Центральная, 1'),
(2, 'Вторичный склад', 'ул. Лесная, 5');

-- --------------------------------------------------------

--
-- Структура таблицы `Vendors`
--

CREATE TABLE `Vendors` (
  `VendorID` int NOT NULL,
  `VendorName` varchar(100) NOT NULL,
  `Address` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `Vendors`
--

INSERT INTO `Vendors` (`VendorID`, `VendorName`, `Address`) VALUES
(1, 'Office Supplies Inc.', 'ул. Промышленная, 10'),
(2, 'Stationery World', 'ул. Речной, 25'),
(3, 'Best Stationery', 'ул. Советская, 7'),
(4, 'New', 'fdsfdf');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `Categories`
--
ALTER TABLE `Categories`
  ADD PRIMARY KEY (`CategoryID`);

--
-- Индексы таблицы `Departments`
--
ALTER TABLE `Departments`
  ADD PRIMARY KEY (`DepartmentID`);

--
-- Индексы таблицы `Employees`
--
ALTER TABLE `Employees`
  ADD PRIMARY KEY (`EmployeeID`),
  ADD KEY `DepartmentID` (`DepartmentID`);

--
-- Индексы таблицы `InventoryRecords`
--
ALTER TABLE `InventoryRecords`
  ADD PRIMARY KEY (`ProductID`,`LocationID`),
  ADD KEY `LocationID` (`LocationID`);

--
-- Индексы таблицы `Orders`
--
ALTER TABLE `Orders`
  ADD PRIMARY KEY (`OrderID`),
  ADD KEY `VendorID` (`VendorID`);

--
-- Индексы таблицы `Order_Details`
--
ALTER TABLE `Order_Details`
  ADD PRIMARY KEY (`OrderID`,`ProductID`),
  ADD KEY `ProductID` (`ProductID`);

--
-- Индексы таблицы `Products`
--
ALTER TABLE `Products`
  ADD PRIMARY KEY (`ProductID`),
  ADD KEY `CategoryID` (`CategoryID`);

--
-- Индексы таблицы `Product_Department`
--
ALTER TABLE `Product_Department`
  ADD PRIMARY KEY (`RequirementID`),
  ADD KEY `DepartmentID` (`DepartmentID`),
  ADD KEY `ProductID` (`ProductID`);

--
-- Индексы таблицы `Product_Vendor`
--
ALTER TABLE `Product_Vendor`
  ADD PRIMARY KEY (`ProductID`,`VendorID`),
  ADD KEY `VendorID` (`VendorID`);

--
-- Индексы таблицы `PurchaseRequests`
--
ALTER TABLE `PurchaseRequests`
  ADD PRIMARY KEY (`RequestID`),
  ADD KEY `DepartmentID` (`DepartmentID`);

--
-- Индексы таблицы `StorageLocations`
--
ALTER TABLE `StorageLocations`
  ADD PRIMARY KEY (`LocationID`);

--
-- Индексы таблицы `Vendors`
--
ALTER TABLE `Vendors`
  ADD PRIMARY KEY (`VendorID`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `Categories`
--
ALTER TABLE `Categories`
  MODIFY `CategoryID` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `Departments`
--
ALTER TABLE `Departments`
  MODIFY `DepartmentID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `Employees`
--
ALTER TABLE `Employees`
  MODIFY `EmployeeID` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `Orders`
--
ALTER TABLE `Orders`
  MODIFY `OrderID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `Products`
--
ALTER TABLE `Products`
  MODIFY `ProductID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT для таблицы `Product_Department`
--
ALTER TABLE `Product_Department`
  MODIFY `RequirementID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `PurchaseRequests`
--
ALTER TABLE `PurchaseRequests`
  MODIFY `RequestID` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `StorageLocations`
--
ALTER TABLE `StorageLocations`
  MODIFY `LocationID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `Vendors`
--
ALTER TABLE `Vendors`
  MODIFY `VendorID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `Employees`
--
ALTER TABLE `Employees`
  ADD CONSTRAINT `employees_ibfk_1` FOREIGN KEY (`DepartmentID`) REFERENCES `Departments` (`DepartmentID`);

--
-- Ограничения внешнего ключа таблицы `InventoryRecords`
--
ALTER TABLE `InventoryRecords`
  ADD CONSTRAINT `inventoryrecords_ibfk_1` FOREIGN KEY (`ProductID`) REFERENCES `Products` (`ProductID`),
  ADD CONSTRAINT `inventoryrecords_ibfk_2` FOREIGN KEY (`LocationID`) REFERENCES `StorageLocations` (`LocationID`);

--
-- Ограничения внешнего ключа таблицы `Orders`
--
ALTER TABLE `Orders`
  ADD CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`VendorID`) REFERENCES `Vendors` (`VendorID`);

--
-- Ограничения внешнего ключа таблицы `Order_Details`
--
ALTER TABLE `Order_Details`
  ADD CONSTRAINT `order_details_ibfk_1` FOREIGN KEY (`OrderID`) REFERENCES `Orders` (`OrderID`),
  ADD CONSTRAINT `order_details_ibfk_2` FOREIGN KEY (`ProductID`) REFERENCES `Products` (`ProductID`);

--
-- Ограничения внешнего ключа таблицы `Products`
--
ALTER TABLE `Products`
  ADD CONSTRAINT `products_ibfk_1` FOREIGN KEY (`CategoryID`) REFERENCES `Categories` (`CategoryID`);

--
-- Ограничения внешнего ключа таблицы `Product_Department`
--
ALTER TABLE `Product_Department`
  ADD CONSTRAINT `product_department_ibfk_1` FOREIGN KEY (`DepartmentID`) REFERENCES `Departments` (`DepartmentID`),
  ADD CONSTRAINT `product_department_ibfk_2` FOREIGN KEY (`ProductID`) REFERENCES `Products` (`ProductID`);

--
-- Ограничения внешнего ключа таблицы `Product_Vendor`
--
ALTER TABLE `Product_Vendor`
  ADD CONSTRAINT `product_vendor_ibfk_1` FOREIGN KEY (`ProductID`) REFERENCES `Products` (`ProductID`),
  ADD CONSTRAINT `product_vendor_ibfk_2` FOREIGN KEY (`VendorID`) REFERENCES `Vendors` (`VendorID`);

--
-- Ограничения внешнего ключа таблицы `PurchaseRequests`
--
ALTER TABLE `PurchaseRequests`
  ADD CONSTRAINT `purchaserequests_ibfk_1` FOREIGN KEY (`DepartmentID`) REFERENCES `Departments` (`DepartmentID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
