ALTER TRIGGER dbo.tg_Folios
   ON [dbo].[Denuncia]
   AFTER INSERT 
AS 
BEGIN
exec dbo.Insert_Folio;

END

/****Se utiliza para insertar un registro en la tabla de folios. El SP que se ejecuta genera el Folio*****/