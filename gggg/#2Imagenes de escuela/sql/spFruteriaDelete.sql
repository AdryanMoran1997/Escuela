USE [Fruteria]
GO

/****** Object:  StoredProcedure [dbo].[spFruteriaDelete]    Script Date: 14/04/2021 07:50:12 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- Create Procedure (New Menu).SQL

CREATE PROCEDURE [dbo].[spFruteriaDelete]
@Idproducto varchar(50)

	
AS
BEGIN
	
	DELETE FROM Producto WHERE Idproducto=@Idproducto
END
GO

