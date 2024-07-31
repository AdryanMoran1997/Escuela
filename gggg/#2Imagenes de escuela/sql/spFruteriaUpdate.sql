USE [Fruteria]
GO

/****** Object:  StoredProcedure [dbo].[spFruteriaUpdate]    Script Date: 14/04/2021 07:53:15 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spFruteriaUpdate]
@Idproducto varchar(50),
@Nombre varchar(50),
@Cantidad varchar(50),
@Precio varchar(50),
@FechaUltimaCompra varchar(50)
	
AS
BEGIN
	
	UPDATE Producto SET Nombre= @Nombre, Cantidad = @Cantidad, Precio=@Precio, FechaUltimaCompra=@FechaUltimaCompra
	WHERE Idproducto=@Idproducto
END
GO

