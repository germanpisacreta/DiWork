USE [pruebademo]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarRepuesto]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarRepuesto]
    @Id int,
    @Nombre varchar(200),
    @Precio decimal(18,6)
AS
BEGIN
    UPDATE Repuestos
    SET Nombre = @Nombre,
        Precio = @Precio
    WHERE Id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[Automovil_Actualizar]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Automovil_Actualizar]
(
  @Id BIGINT,
  @IdVehiculo BIGINT,
  @Tipo SMALLINT,
  @CantidadPuertas INT,
  @Marca VARCHAR(100),
  @Modelo VARCHAR(100),
  @Patente VARCHAR(100)
)
AS
BEGIN
 
 UPDATE Vehiculo
  SET Marca = @Marca,
      Modelo = @Modelo,
      Patente = @Patente
  WHERE Id = @IdVehiculo
  
  UPDATE Automovil
  SET Tipo = @Tipo,
      CantidadPuertas = @CantidadPuertas
  WHERE Id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[Automovil_Insertar]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Automovil_Insertar]
(
  @Tipo SMALLINT,
  @CantidadPuertas INT,
  @Marca VARCHAR(100),
  @Modelo VARCHAR(100),
  @Patente VARCHAR(100)
)
AS
BEGIN
  
  DECLARE @IdVehiculo int = 0
  
  INSERT INTO Vehiculo (Marca, Modelo, Patente)
  VALUES (@Marca, @Modelo, @Patente)
  SET @IdVehiculo = (SELECT SCOPE_IDENTITY() AS Id)

  INSERT INTO Automovil (IdVehiculo, Tipo, CantidadPuertas)
  VALUES ( @IdVehiculo, @Tipo, @CantidadPuertas)

  SELECT @IdVehiculo AS IdVehiculo
END
GO
/****** Object:  StoredProcedure [dbo].[Automovil_Leer]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Automovil_Leer]
AS
BEGIN
  SELECT A.Id, V.Marca, V.Modelo, V.Patente, A.Tipo, A.CantidadPuertas
  FROM Automovil A
  INNER JOIN Vehiculo V ON A.IdVehiculo = V.Id
END
GO
/****** Object:  StoredProcedure [dbo].[BorrarRepuesto]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BorrarRepuesto]
    @Id int
AS
BEGIN
    DELETE FROM Repuestos
    WHERE Id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[Desperfecto_Actualizar]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Desperfecto_Actualizar]
(
  @id BIGINT,
  @idPresupuesto BIGINT,
  @Descripcion VARCHAR(200),
  @ManoDeObra DECIMAL(18,6),
  @Tiempo INT
)
AS
BEGIN
  UPDATE Desperfecto
  SET idPresupuesto = @idPresupuesto,
      Descripcion = @Descripcion,
      ManoDeObra = @ManoDeObra,
      Tiempo = @Tiempo
  WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[Desperfecto_Insertar]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Desperfecto_Insertar]
(
  @idPresupuesto BIGINT,
  @Descripcion VARCHAR(200),
  @ManoDeObra DECIMAL(18,6),
  @Tiempo INT
)
AS
BEGIN
  INSERT INTO Desperfecto (idPresupuesto, Descripcion, ManoDeObra, Tiempo)
  VALUES (@idPresupuesto, @Descripcion, @ManoDeObra, @Tiempo)

  SELECT SCOPE_IDENTITY() AS Id 
END
GO
/****** Object:  StoredProcedure [dbo].[Desperfecto_Leer]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Desperfecto_Leer]
AS
BEGIN
  SELECT * FROM Desperfecto
END
GO
/****** Object:  StoredProcedure [dbo].[DesperfectoRepuesto_Borrar]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DesperfectoRepuesto_Borrar]
(
  @IdRepuesto BIGINT,
  @IdDesperfecto BIGINT
)
AS
BEGIN
  DELETE FROM DesperfectoRepuesto
  WHERE IdRepuesto = @IdRepuesto AND IdDesperfecto = @IdDesperfecto
END
GO
/****** Object:  StoredProcedure [dbo].[DesperfectoRepuesto_Insertar]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DesperfectoRepuesto_Insertar]
(
  @IdRepuesto BIGINT,
  @IdDesperfecto BIGINT
)
AS
BEGIN
IF ((SELECT COUNT(IdRepuesto) FROM DesperfectoRepuesto WHERE IdRepuesto= @IdRepuesto and IdDesperfecto = @IdDesperfecto) = 0)
	BEGIN
		INSERT INTO DesperfectoRepuesto (IdRepuesto, IdDesperfecto)
		VALUES (@IdRepuesto, @IdDesperfecto)
	END
END
GO
/****** Object:  StoredProcedure [dbo].[DesperfectoRepuesto_LeerTodo]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DesperfectoRepuesto_LeerTodo]
AS
BEGIN
  SELECT * FROM DesperfectoRepuesto
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarRepuesto]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarRepuesto]
    @Nombre varchar(200),
    @Precio decimal(18,6)
AS
BEGIN
    INSERT INTO Repuestos (Nombre, Precio)
    VALUES (@Nombre, @Precio)
END
GO
/****** Object:  StoredProcedure [dbo].[MassiveCharge]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*
EXEC dbo.MassiveCharge 
*/

/*****************************************************************************************/
/*+                                                                                      */
/*+ Nombre  : dbo.MassiveCharge                                                          */
/*+ Objetivo: Insertar en la BD una serie de Respuestos con sus Precios                  */
/*+                                                                                      */
/*****************************************************************************************/

CREATE PROC [dbo].[MassiveCharge] AS
BEGIN

/*+ CreaciC3n de la tabla Temporal que contendrC! los Repuestos con sus precios*/

    CREATE TABLE #TMP_RESPUESTO (Nombre VARCHAR(100),
                                 Precio DECIMAL(18,6))

	 CREATE TABLE #TMP_RESPUESTOSALIDA (Nombre VARCHAR(100),
										Precio DECIMAL(18,6))

/*+ Se generan los registros en la tabla temporal que posteriormente se evaluarC!n para ver si procede su carga en la tabla definitiva de Repuestos*/

    BEGIN /*+ BEGIN INSERT EN LA TEMPORAL DE RESPUESTOS*/
        INSERT INTO #TMP_RESPUESTO VALUES ('B356963821', 17.61)
        INSERT INTO #TMP_RESPUESTO VALUES ('B881468337', 40.88)
        INSERT INTO #TMP_RESPUESTO VALUES ('B867719836', 87.76)
        INSERT INTO #TMP_RESPUESTO VALUES ('B397571688', 13.97)
        INSERT INTO #TMP_RESPUESTO VALUES ('B852883143', 47.97)
        INSERT INTO #TMP_RESPUESTO VALUES ('B461882670', 22.68)
        INSERT INTO #TMP_RESPUESTO VALUES ('B333520964', 82.28)
        INSERT INTO #TMP_RESPUESTO VALUES ('B388445039', 50.71)
        INSERT INTO #TMP_RESPUESTO VALUES ('B648201513', 21.83)
        INSERT INTO #TMP_RESPUESTO VALUES ('B436759416', 35.39)
        INSERT INTO #TMP_RESPUESTO VALUES ('B317533243', 22.84)
        INSERT INTO #TMP_RESPUESTO VALUES ('B666592414', 58.67)
        INSERT INTO #TMP_RESPUESTO VALUES ('B443568817', 53.83)
        INSERT INTO #TMP_RESPUESTO VALUES ('B316416378', 17.74)
        INSERT INTO #TMP_RESPUESTO VALUES ('B252543362', 16.98)
        INSERT INTO #TMP_RESPUESTO VALUES ('B453148609', 14.23)
        INSERT INTO #TMP_RESPUESTO VALUES ('B254958806', 41.19)
        INSERT INTO #TMP_RESPUESTO VALUES ('B356963821', 62.58)
        INSERT INTO #TMP_RESPUESTO VALUES ('B846487171', 92.91)
        INSERT INTO #TMP_RESPUESTO VALUES ('B397571688', 1.04)
        INSERT INTO #TMP_RESPUESTO VALUES ('B535169105', 90.14)
        INSERT INTO #TMP_RESPUESTO VALUES ('B628263302', 78.64)
        INSERT INTO #TMP_RESPUESTO VALUES ('B608816685', 93.73)
        INSERT INTO #TMP_RESPUESTO VALUES ('B660755442', 43.62)
        INSERT INTO #TMP_RESPUESTO VALUES ('B659053715', 90.59)
        INSERT INTO #TMP_RESPUESTO VALUES ('B556344166', 71.62)
        INSERT INTO #TMP_RESPUESTO VALUES ('B216140665', 93.15)
        INSERT INTO #TMP_RESPUESTO VALUES ('B843858581', 66.52)
        INSERT INTO #TMP_RESPUESTO VALUES ('B790077756', 8.91)
        INSERT INTO #TMP_RESPUESTO VALUES ('B916071768', 85.46)
        INSERT INTO #TMP_RESPUESTO VALUES ('B317533243', 7.97)
        INSERT INTO #TMP_RESPUESTO VALUES ('B343454513', 22.91)
        INSERT INTO #TMP_RESPUESTO VALUES ('B986574036', 65.10)
        INSERT INTO #TMP_RESPUESTO VALUES ('B662139869', 3.50)
        INSERT INTO #TMP_RESPUESTO VALUES ('B618792223', 6.87)
        INSERT INTO #TMP_RESPUESTO VALUES ('B578485476', 49.70)
        INSERT INTO #TMP_RESPUESTO VALUES ('B132813434', 32.58)
        INSERT INTO #TMP_RESPUESTO VALUES ('B776163235', 73.64)
        INSERT INTO #TMP_RESPUESTO VALUES ('B215908676', 92.83)
        INSERT INTO #TMP_RESPUESTO VALUES ('B871139440', 31.83)
        INSERT INTO #TMP_RESPUESTO VALUES ('B564893705', 18.91)
        INSERT INTO #TMP_RESPUESTO VALUES ('B634131771', 70.35)
        INSERT INTO #TMP_RESPUESTO VALUES ('B321187273', 91.96)
        INSERT INTO #TMP_RESPUESTO VALUES ('B444737823', 78.73)
        INSERT INTO #TMP_RESPUESTO VALUES ('B413525993', 9.93)
        INSERT INTO #TMP_RESPUESTO VALUES ('B229547877', 97.08)
        INSERT INTO #TMP_RESPUESTO VALUES ('B545788950', 11.84)
        INSERT INTO #TMP_RESPUESTO VALUES ('B658514562', 8.84)
        INSERT INTO #TMP_RESPUESTO VALUES ('B736313138', 78.47)
        INSERT INTO #TMP_RESPUESTO VALUES ('B840888802', 93.85)
        INSERT INTO #TMP_RESPUESTO VALUES ('B883572821', 21.57)
        INSERT INTO #TMP_RESPUESTO VALUES ('B493478663', 76.98)
        INSERT INTO #TMP_RESPUESTO VALUES ('B718838840', 7.41)
        INSERT INTO #TMP_RESPUESTO VALUES ('B183671709', 45.53)
        INSERT INTO #TMP_RESPUESTO VALUES ('B908384721', 14.73)
        INSERT INTO #TMP_RESPUESTO VALUES ('B566417680', 44.04)
        INSERT INTO #TMP_RESPUESTO VALUES ('B633833113', 33.28)
        INSERT INTO #TMP_RESPUESTO VALUES ('B829258206', 41.74)
        INSERT INTO #TMP_RESPUESTO VALUES ('B350041352', 85.13)
        INSERT INTO #TMP_RESPUESTO VALUES ('B548168477', 7.44)
        INSERT INTO #TMP_RESPUESTO VALUES ('B765657146', 89.79)
        INSERT INTO #TMP_RESPUESTO VALUES ('B830231322', 81.42)
        INSERT INTO #TMP_RESPUESTO VALUES ('B816385774', 9.30)
        INSERT INTO #TMP_RESPUESTO VALUES ('B857448796', 77.36)
        INSERT INTO #TMP_RESPUESTO VALUES ('B302875266', 54.89)
        INSERT INTO #TMP_RESPUESTO VALUES ('B790507487', 50.41)
        INSERT INTO #TMP_RESPUESTO VALUES ('B723629401', 65.36)
        INSERT INTO #TMP_RESPUESTO VALUES ('B595728629', 19.94)
        INSERT INTO #TMP_RESPUESTO VALUES ('B472436824', 65.69)
        INSERT INTO #TMP_RESPUESTO VALUES ('B235859870', 66.44)
        INSERT INTO #TMP_RESPUESTO VALUES ('B874178252', 42.38)
        INSERT INTO #TMP_RESPUESTO VALUES ('B777713850', 40.26)
        INSERT INTO #TMP_RESPUESTO VALUES ('B550221285', 8.72)
        INSERT INTO #TMP_RESPUESTO VALUES ('B816043247', 73.97)
        INSERT INTO #TMP_RESPUESTO VALUES ('B607313788', 15.95)
        INSERT INTO #TMP_RESPUESTO VALUES ('B396482694', 45.17)
        INSERT INTO #TMP_RESPUESTO VALUES ('B504021331', 24.52)
        INSERT INTO #TMP_RESPUESTO VALUES ('B651475349', 86.77)
        INSERT INTO #TMP_RESPUESTO VALUES ('B470409863', 11.81)
        INSERT INTO #TMP_RESPUESTO VALUES ('B264135435', 62.58)
        INSERT INTO #TMP_RESPUESTO VALUES ('B755636151', 33.88)
        INSERT INTO #TMP_RESPUESTO VALUES ('B382183955', 0.92)
        INSERT INTO #TMP_RESPUESTO VALUES ('B667316286', 0.29)
        INSERT INTO #TMP_RESPUESTO VALUES ('B783117048', 41.57)
        INSERT INTO #TMP_RESPUESTO VALUES ('B812952354', 86.25)
        INSERT INTO #TMP_RESPUESTO VALUES ('B621838237', 80.54)
        INSERT INTO #TMP_RESPUESTO VALUES ('B665465223', 53.69)
        INSERT INTO #TMP_RESPUESTO VALUES ('B881682635', 64.78)
        INSERT INTO #TMP_RESPUESTO VALUES ('B646289861', 72.01)
        INSERT INTO #TMP_RESPUESTO VALUES ('B852115667', 48.73)
        INSERT INTO #TMP_RESPUESTO VALUES ('B144635415', 34.23)
        INSERT INTO #TMP_RESPUESTO VALUES ('B874863828', 24.70)
        INSERT INTO #TMP_RESPUESTO VALUES ('B333841476', 41.57)
        INSERT INTO #TMP_RESPUESTO VALUES ('B587386017', 45.27)
        INSERT INTO #TMP_RESPUESTO VALUES ('B874270576', 42.38)
        INSERT INTO #TMP_RESPUESTO VALUES ('B300733136', 25.55)
        INSERT INTO #TMP_RESPUESTO VALUES ('B611446656', 60.12)
        INSERT INTO #TMP_RESPUESTO VALUES ('B801300387', 61.04)
        INSERT INTO #TMP_RESPUESTO VALUES ('B845153562', 60.09)
        INSERT INTO #TMP_RESPUESTO VALUES ('B943846621', 37.05)
    END /*+ END INSERT EN LA TEMPORAL DE RESPUESTOS*/
END

--DECLARO VARIABLES
DECLARE @Nombre VARCHAR(100);
DECLARE @Precio DECIMAL(18,6);

BEGIN
DECLARE Cursor1 CURSOR FOR
		SELECT Nombre,
			   Precio
		FROM #TMP_RESPUESTO
OPEN Cursor1;

FETCH NEXT FROM Cursor1 
INTO 
@Nombre,
@Precio;


WHILE @@FETCH_STATUS = 0  
BEGIN
IF(@Precio < 20)
	BEGIN
		IF((SELECT COUNT(ID)FROM Repuesto WHERE Nombre = @Nombre) = 0)
			BEGIN
				INSERT INTO Repuesto (Nombre, Precio)
				VALUES (@Nombre, @Precio)
			END
		ELSE
		    DECLARE @PrecioFinal decimal(18,6) = 0
			SET @PrecioFinal =(SELECT SUM(Precio) FROM #TMP_RESPUESTO WHERE Nombre = @Nombre)
			BEGIN 
				UPDATE Repuesto SET Precio = @PrecioFinal
				WHERE Nombre = @Nombre
			END

	END
ELSE
	BEGIN
		INSERT INTO #TMP_RESPUESTOSALIDA (Nombre, Precio)
		VALUES (@Nombre, @Precio)
	END


FETCH NEXT FROM Cursor1 
INTO 
@Nombre,
@Precio;

END
CLOSE  Cursor1;
DEALLOCATE Cursor1;
SELECT * FROM #TMP_RESPUESTOSALIDA
END
GO
/****** Object:  StoredProcedure [dbo].[Moto_Actualizar]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Moto_Actualizar]
(
  @Id BIGINT,
  @IdVehiculo BIGINT,
  @Cilindrado VARCHAR(50),
  @Marca VARCHAR(100),
  @Modelo VARCHAR(100),
  @Patente VARCHAR(100)
)
AS
BEGIN  

  UPDATE Vehiculo
  SET Marca = @Marca,
      Modelo = @Modelo,
      Patente = @Patente
  WHERE Id = @IdVehiculo

  UPDATE Moto
  SET Cilindrado = @Cilindrado
  WHERE Id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[Moto_Insertar]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Moto_Insertar]
(
  @Cilindrado VARCHAR(50),
  @Marca VARCHAR(100),
  @Modelo VARCHAR(100),
  @Patente VARCHAR(100)
)
AS
BEGIN
  DECLARE @IdVehiculo int = 0;

  INSERT INTO Vehiculo (Marca, Modelo, Patente)
  VALUES (@Marca, @Modelo, @Patente)
  SET @IdVehiculo = (SELECT SCOPE_IDENTITY() AS Id)

  INSERT INTO Moto ( IdVehiculo, Cilindrado)
  VALUES ( @IdVehiculo, @Cilindrado)

  SELECT @IdVehiculo AS IdVehiculo
END
GO
/****** Object:  StoredProcedure [dbo].[Moto_Leer]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Moto_Leer]
AS
BEGIN
  SELECT M.Id, V.Marca, V.Modelo, V.Patente, M.Cilindrado
  FROM Moto M
  INNER JOIN Vehiculo V ON M.IdVehiculo = V.Id
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerAutomovilPorIdVehiculo]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerAutomovilPorIdVehiculo]
 @IdVehiculo bigint
AS
BEGIN
    SELECT TOP (1000) A.[Id]
      ,[IdVehiculo]
      ,[Tipo]
      ,[CantidadPuertas]
	   ,[Marca]
      ,[Modelo]
      ,[Patente]
  FROM [dbo].[Automovil] A
   JOIN [dbo].[Vehiculo] V ON V.Id = A.[IdVehiculo]
  where IdVehiculo = @IdVehiculo
  
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerDesperfectoPorId]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerDesperfectoPorId]
 @idPresupuesto INT
AS
BEGIN
    SELECT TOP (1000) [id]
      ,[idPresupuesto]
      ,[Descripcion]
      ,[ManoDeObra]
      ,[Tiempo]
  FROM [dbo].[Desperfecto]
  where [idPresupuesto] = @idPresupuesto
  
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerDesperfectoRepuesto]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[ObtenerDesperfectoRepuesto]
AS
BEGIN
    SELECT IdDesperfecto
      ,IdRepuesto
	  ,R.Id
	  ,R.Nombre
	  ,R.precio
  FROM [DesperfectoRepuesto] DR
  join Repuesto R ON R.Id = DR.[IdRepuesto] 
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerMotoPorIdVehiculo]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerMotoPorIdVehiculo]
 @IdVehiculo bigint
AS
BEGIN
    SELECT  M.[Id]
      ,[IdVehiculo]
      ,[Cilindrado]
	  ,[Marca]
      ,[Modelo]
      ,[Patente]
  FROM [dbo].[Moto] M
  JOIN [dbo].[Vehiculo] V ON V.Id = M.[IdVehiculo]
  where IdVehiculo = @IdVehiculo
  
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerPresupuesto]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerPresupuesto]
AS
BEGIN
    SELECT  P.[Id]
      ,[Nombre]
      ,[Apellido]
      ,[Email]
      ,[Total]
      ,[IdVehiculo]
	  ,[Marca]
      ,[Modelo]
      ,[Patente]
  FROM [dbo].[Presupuesto] P
  JOIN [dbo].[Vehiculo] V ON V.Id = P.[IdVehiculo]
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerPresupuestoPorId]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerPresupuestoPorId]
 @Id INT
AS
BEGIN
    SELECT  P.[Id]
      ,[Nombre]
      ,[Apellido]
      ,[Email]
      ,[Total]
      ,[IdVehiculo]
	  ,Tipo
	  ,Recargo
  FROM [dbo].[Presupuesto] P
  where Id = @Id
  
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerRepuesto]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerRepuesto]
AS
BEGIN
    SELECT Id, Nombre, Precio
    FROM Repuesto
END
GO
/****** Object:  StoredProcedure [dbo].[Presupuesto_Actualizar]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Presupuesto_Actualizar]
(
  @Id BIGINT,
  @Nombre VARCHAR(50),
  @Apellido VARCHAR(50),
  @Email VARCHAR(100),
  @Recargo DECIMAL(18,6),
   @Total DECIMAL(20,6),
   @Tipo int,
  @IdVehiculo BIGINT
)
AS
BEGIN
  UPDATE Presupuesto
  SET Nombre = @Nombre,
      Apellido = @Apellido,
      Email = @Email,
      Total = @Total,
	  Recargo = @Recargo,
	  Tipo = @Tipo,
      IdVehiculo = @IdVehiculo
  WHERE Id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[Presupuesto_Insertar]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Presupuesto_Insertar]
(
  @Nombre VARCHAR(50),
  @Apellido VARCHAR(50),
  @Email VARCHAR(100),
  @Recargo DECIMAL(18,6),
  @Total DECIMAL(20,6),
  @Tipo int,
  @IdVehiculo BIGINT
)
AS
BEGIN
  INSERT INTO Presupuesto (Nombre, Apellido, Email, Total,Tipo, IdVehiculo,Recargo)
  VALUES (@Nombre, @Apellido, @Email, @Total,@Tipo ,@IdVehiculo,@Recargo)

  SELECT SCOPE_IDENTITY() AS Id 
END
GO
/****** Object:  StoredProcedure [dbo].[Presupuesto_Leer]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Presupuesto_Leer]
AS
BEGIN
  SELECT * FROM Presupuesto
END
GO
/****** Object:  StoredProcedure [dbo].[PromedioMonto]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PromedioMonto]
   
AS
BEGIN
     SELECT AVG(Total) AS Total,
			Marca,
			Modelo
	 FROM [dbo].[Presupuesto] P
	 JOIN [dbo].[Vehiculo] V ON V.[Id] = P.[IdVehiculo]
	 GROUP BY Marca,
			  Modelo
END
GO
/****** Object:  StoredProcedure [dbo].[RepuestoMasUsado]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RepuestoMasUsado]
   
AS
BEGIN
    SELECT V.Marca,
		   V.Modelo, 
		   R.Nombre, 
		   COUNT(*) AS Cantidad
FROM DesperfectoRepuesto DRP
JOIN Desperfecto D ON DRP.IdDesperfecto = D.id
JOIN Presupuesto P ON D.idPresupuesto = P.Id
JOIN Vehiculo V ON P.IdVehiculo = V.Id
JOIN Repuesto R ON DRP.IdRepuesto = R.Id
GROUP BY V.Marca, V.Modelo, R.Nombre
HAVING COUNT(*) = (
    SELECT MAX(Contador)
    FROM (
        SELECT COUNT(*) AS Contador,
				V.Marca, 
				V.Modelo
        FROM DesperfectoRepuesto DRP
        JOIN Desperfecto D ON DRP.IdDesperfecto = D.id
        JOIN Presupuesto P ON D.idPresupuesto = P.Id
        JOIN Vehiculo V ON P.IdVehiculo = V.Id
        JOIN Repuesto R ON DRP.IdRepuesto = R.Id
        GROUP BY V.Marca, V.Modelo, R.Nombre
    ) AS Recuento
    WHERE V.Marca = Recuento.Marca AND V.Modelo = Recuento.Modelo

)
							 
END
GO
/****** Object:  StoredProcedure [dbo].[SumatoriaMonto]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SumatoriaMonto]
   
AS
BEGIN
     SELECT SUM(Total) as Total,
			CASE WHEN Tipo = 0 THEN 'Automovil'
				 WHEN Tipo = 1 THEN 'Moto' END as TipoDescrip
	 FROM [dbo].[Presupuesto] P
	 GROUP BY Tipo
END
GO
/****** Object:  StoredProcedure [dbo].[Vehiculo_Actualizar]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Vehiculo_Actualizar]
(
  @Id BIGINT,
  @Marca VARCHAR(100),
  @Modelo VARCHAR(100),
  @Patente VARCHAR(100)
)
AS
BEGIN
  UPDATE Vehiculo
  SET Marca = @Marca,
      Modelo = @Modelo,
      Patente = @Patente
  WHERE Id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[Vehiculo_Insertar]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Vehiculo_Insertar]
(
  @Marca VARCHAR(100),
  @Modelo VARCHAR(100),
  @Patente VARCHAR(100)
)
AS
BEGIN
  INSERT INTO Vehiculo (Marca, Modelo, Patente)
  VALUES (@Marca, @Modelo, @Patente)
  SELECT SCOPE_IDENTITY() AS Id
END
GO
/****** Object:  StoredProcedure [dbo].[Vehiculo_Leer]    Script Date: 10/7/2023 12:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Vehiculo_Leer]
AS
BEGIN
  SELECT * FROM Vehiculo
END
GO
