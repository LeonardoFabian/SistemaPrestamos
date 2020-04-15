CREATE SCHEMA BANCO AUTHORIZATION dbo;
GO


---------------------------------------------------------------------
-- Create Tables
---------------------------------------------------------------------

-- Create table HR.Employees
CREATE TABLE BANCO.Clientes
(
  id INT NOT NULL IDENTITY,
  cedula VARCHAR(11) NOT NULL,
  nombre VARCHAR(50) NOT NULL,
  apellido VARCHAR(50) NOT NULL,  
  genero VARCHAR(1) NOT NULL,
  fechanacimiento DATETIME NOT NULL,
  fecharegistro DATETIME NOT NULL,
  direccion VARCHAR(60) NOT NULL,  
  telefono VARCHAR(24) NOT NULL,
  correo VARCHAR(80) NOT NULL,
  ultimaactualizacion DATETIME NULL
)



CREATE TABLE BANCO.Cuentas
(
id INT NOT NULL,
idcliente INT NULL
)

CREATE TABLE BANCO.Prestamos
(
id INT NOT NULL IDENTITY,
idtipoprestamo INT NULL,
idcuenta INT NULL,
valorinicial MONEY NOT NULL,
plazo INT NOT NULL,
montocuota MONEY NOT NULL,
fechadesembolso DATETIME NOT NULL,
tasa DECIMAL(4,2) NOT NULL,
cuotaspagadas INT NULL,
estado NVARCHAR DEFAULT '1'
)


CREATE TABLE BANCO.TipoPrestamos
(
id INT NOT NULL IDENTITY,
tipo NVARCHAR(50) NOT NULL,
descripcion TEXT NULL
)


CREATE TABLE BANCO.Transacciones
(
id INT NOT NULL IDENTITY,
idcuenta INT NULL,
idtipotransaccion INT NULL,
monto MONEY NOT NULL,
fecha DATETIME NOT NULL
)

CREATE TABLE BANCO.TipoTransaccion
(
id INT NOT NULL IDENTITY,
tipo NVARCHAR(50) NOT NULL,
descripcion TEXT NULL
)



---------------------------------------------------------------------
-- Create Views
---------------------------------------------------------------------
/*
 CREATE VIEW [BANCO].VW_BALANCE_TOTAL_PRESTAMOS
  AS
  SELECT 	
	cli.id AS idcliente,
	cli.cedula AS cedula,
	CONCAT(cli.nombre ,' ', cli.apellido) AS nombre,
	pre.valorinicial AS balanceinicial, 
	(pre.valorinicial - (pre.montocuota * pre.cuotaspagadas)) AS balanceactual,	
	pre.montocuota AS cuotamensual,	
	
  FROM [prestamos-app].[BANCO].Cuentas cu
  JOIN BANCO.Clientes cli ON cu.idcliente = cli.id
  JOIN BANCO.Prestamos pre ON cu.id = pre.idcuenta
  JOIN BANCO.Transacciones tra ON cu.id = tra.idcuenta
  */

  

  -- VIEW CLIENTE - BALANCE TOTAL PRESTAMOS
   CREATE VIEW [BANCO].VW_BALANCE_TOTAL_PRESTAMOS
  AS
  SELECT DISTINCT
	cu.id AS idcuenta,
	cli.id AS idcliente,
	cli.cedula AS cedula,
	CONCAT(cli.nombre ,' ', cli.apellido) AS nombre,
	pre.valorinicial AS balanceinicial, 	
	(
		(SELECT TOP 1 t1.monto FROM BANCO.Transacciones t1 JOIN BANCO.Cuentas c ON t1.idcuenta = c.id WHERE t1.idtipotransaccion = 2 ORDER BY t1.monto DESC) 
		- 
		(SELECT SUM(t2.monto) FROM BANCO.Transacciones t2 JOIN BANCO.Cuentas c ON t2.idcuenta = c.id WHERE t2.idtipotransaccion = 1)
	) AS balanceactual,	
	pre.montocuota AS cuotamensual,
	(pre.plazo - pre.cuotaspagadas) AS cuotaspendientes
	
  FROM [prestamos-app].[BANCO].Cuentas cu
  JOIN BANCO.Clientes cli ON cu.idcliente = cli.id
  JOIN BANCO.Prestamos pre ON cu.id = pre.idcuenta
  JOIN BANCO.Transacciones tra ON cu.id = tra.idcuenta
  
 

  -- VIEW CLIENTE - DETALLE PRESTAMOS
  CREATE VIEW [BANCO].VW_DETALLE_PRESTAMOS
  AS

  SELECT DISTINCT
	cli.id AS idcliente,
	cli.cedula AS cedula,	
	cu.id AS producto, 
	(
		(SELECT TOP 1 t1.monto FROM BANCO.Transacciones t1 JOIN BANCO.Cuentas c ON t1.idcuenta = c.id WHERE idtipotransaccion = 2) 
		- 
		(SELECT SUM(t2.monto) FROM BANCO.Transacciones t2 JOIN BANCO.Cuentas c ON t2.idcuenta = c.id WHERE idtipotransaccion = 1)
	) AS deudaactual,	
	
	(SELECT 
		DATEADD
		(
			month,
			(SELECT COUNT(t4.fecha) FROM BANCO.Transacciones t4 JOIN BANCO.Cuentas c ON t4.idcuenta = c.id WHERE t4.idtipotransaccion = 1 GROUP BY t4.fecha)
				,
			(SELECT TOP 1 t3.fecha AS fdesembolso FROM BANCO.Transacciones t3 JOIN BANCO.Cuentas c ON t3.idcuenta = c.id WHERE idtipotransaccion = 3 ORDER BY fdesembolso DESC) 
		)AS fproximopago			
	)AS fechaproximopago,
	pre.montocuota AS montocuotas,
	(pre.plazo - pre.cuotaspagadas) AS cuotaspendientes,
	(
		SELECT CASE pre.estado
			WHEN 1 THEN 'Activo'
			ELSE 'Saldado'
		END
	) AS estado,
	pre.tasa
	
  FROM [prestamos-app].[BANCO].Cuentas cu
  JOIN BANCO.Clientes cli ON cu.idcliente = cli.id
  JOIN BANCO.Prestamos pre ON cu.id = pre.idcuenta
  JOIN BANCO.Transacciones tra ON cu.id = tra.idcuenta
 

  -- VIEW CLIENTES
   CREATE VIEW [BANCO].VW_HISTORICO_PRESTAMOS
  AS
  SELECT 
	cu.id AS idcuenta,
	tra.id AS numerotransaccion,	
	tra.fecha AS fecha,
	tip.tipo,	
	tra.monto
	
		
	
  FROM BANCO.Transacciones tra
  JOIN BANCO.Cuentas cu ON tra.idcuenta = cu.id
  JOIN BANCO.TipoTransaccion tip ON tra.idtipotransaccion = tip.id

  
  

  