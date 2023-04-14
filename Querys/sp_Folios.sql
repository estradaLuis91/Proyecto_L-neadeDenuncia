-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Luis Estrada
-- Create date: 13/04/23
-- Description:	Inserta un nuevo registro en la tabla de Folio
-- =============================================
ALTER PROCEDURE dbo.Insert_Folio
AS
BEGIN
declare @ID INT
SET @ID = (SELECT top 1 Id FROM dbo.Denuncia ORDER BY ID DESC)
DECLARE @FECHAMODF NVARCHAR(15)
SET @FECHAMODF = (SELECT top 1 CONCAT(RIGHT(YEAR(Create_Date),2),
							CASE WHEN MONTH(Create_Date) < 10 THEN CONCAT('0',CONVERT(INT,MONTH(Create_Date)))
						    END,@ID) FROM dbo.Denuncia ORDER BY ID DESC);


INSERT INTO  [dbo].[Folios] (idFolio,Folio)VALUES(@ID,@FECHAMODF)
END
GO


--EXEC dbo.Insert_Folio