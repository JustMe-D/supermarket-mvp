CREATE TABLE Customer (
    Customer_Id INT PRIMARY KEY IDENTITY(10,1), -- ID como clave primaria con incremento automático
    Customer_Document CHAR(15) NOT NULL UNIQUE, -- Número de documento, único y no nulo
    Customer_FirstName NVARCHAR(50) NOT NULL, -- Nombre, no nulo
    Customer_LastName NVARCHAR(50) NOT NULL, -- Apellido, no nulo
    Customer_Address CHAR(80), -- Dirección, longitud fija de 80 caracteres
    Customer_Birthday DATE, -- Fecha de nacimiento
    Customer_PhoneNumber CHAR(16), -- Número de teléfono
    Customer_Email CHAR(100) -- Correo electrónico, longitud fija de 100 caracteres
);