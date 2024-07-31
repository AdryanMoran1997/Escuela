USE [Fruteria]
GO

/****** Object:  StoredProcedure [dbo].[spFruteriaConsulta]    Script Date: 14/04/2021 07:49:56 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spFruteriaConsulta]
@Idproducto varchar(50)

	
AS
BEGIN
	
	SELECT * FROM Producto WHERE	 Idproducto=@Idproducto
END
GO

