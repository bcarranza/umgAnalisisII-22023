# Database

En este ejemplo, creamos una cadena de conexión de base de datos y luego creamos una conexión de base de datos. Luego creamos dos consultas y las ejecutamos simultáneamente usando la clase Task. La clase Task nos permite ejecutar tareas de forma asincrónica, lo que significa que se pueden ejecutar al mismo tiempo. El método Wait() en la clase Task nos permite esperar a que la tarea termine de ejecutarse.

Este ejemplo muestra cómo manejar la concurrencia en una base de datos. Al ejecutar consultas simultáneamente, podemos mejorar el rendimiento de nuestra aplicación.

# Como ejecutar correctamente este programa
1. Debes de tener Docker instalado en tu equipo.
2. Correr un nuevo sql server con el siguiente comando
```
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=UMGGT2023*' -e 'MSSQL_PID=Developer' -p 1433:1433 --name sql_server_container -d mcr.microsoft.com/mssql/server:2017-latest
```
3. Instalar Azure Database Studio: https://azure.microsoft.com/en-us/products/data-studio
4. Conectar a sql server
5. Ejecutar el siguiente script de DML

```
CREATE DATABASE Northwind
```

```
USE Northwind

CREATE TABLE Customers (
  CustomerID int IDENTITY(1,1) NOT NULL,
  CompanyName varchar(40) NOT NULL,
  ContactName varchar(30) NOT NULL,
  ContactTitle varchar(30) NOT NULL,
  Address varchar(60) NOT NULL,
  City varchar(30) NOT NULL,
  Region varchar(15) NULL,
  PostalCode varchar(10) NULL,
  Country varchar(20) NOT NULL,
  Phone varchar(20) NOT NULL,
  Fax varchar(20) NULL)

CREATE TABLE Products (
  ProductID int IDENTITY(1,1) NOT NULL,
  ProductName varchar(40) NOT NULL,
  SupplierID int NOT NULL,
  CategoryID int NOT NULL,
  QuantityPerUnit varchar(20) NOT NULL,
  UnitPrice decimal(10,2) NOT NULL,
  UnitsInStock int NOT NULL,
  UnitsOnOrder int NOT NULL,
  Discontinued bit NOT NULL)

INSERT INTO Customers (CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax)
VALUES ('Alfreds Futterkiste', 'Maria Anders', 'Sales Representative', 'Obere Str. 57', 'Berlin', 'Germany', '12209', 'Germany', '(030) 555-0123', '(030) 555-0134')

INSERT INTO Products (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, Discontinued)
VALUES ('Chai', 1, 1, '10 boxes x 20 bags', 18.00, 39, 0, 0)

INSERT INTO Products (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, Discontinued)
VALUES ('Chang', 1, 1, '24 - 12 oz bottles', 19.00, 13, 13, 0)

```

6. dotnet build
7. dotnet run