
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Luis Alfredo Estrada
-- Create date: 13/04/23
-- Description:	Devuelve Detalle de denuncia en caso de tener comentarios activos
-- =============================================
ALTER PROCEDURE dbo.getDenuncias
AS
BEGIN
SELECT Folio,s.Status,s.comentarios
FROM [dbo].[Denuncia] d
INNER JOIN [dbo].[Status_Denuncia] s ON d.Id = s.Denuncia_Id


END
GO
--exec dbo.getDenuncias