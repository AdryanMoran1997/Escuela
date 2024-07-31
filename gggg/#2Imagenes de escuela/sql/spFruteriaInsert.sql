USE [Fruteria]
GO

/****** Object:  StoredProcedure [dbo].[spFruteriaInsert]    Script Date: 14/04/2021 07:53:01 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spFruteriaInsert]
@Idproducto varchar(50),
@Nombre varchar(50),
@Cantidad varchar(50),
@Precio varchar(50),
@FechaUltimaCompra varchar(50)
	
AS
BEGIN
	INSERT INTO Producto values(@Idproducto,@Nombre, @Cantidad,@Precio,@FechaUltimaCompra)
	
END
GO

