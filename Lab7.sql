use DB_B50060;

--1:
go
create procedure ElimEst
	@nombre varchar(30)
	as
	select distinct Estudiante.Cedula
    into #temp
    from Estudiante join Usuarios on Estudiante.Cedula = Usuarios.cedulaUsuario
    where Estudiante.Nombre = @nombre
    delete Usuarios
    where cedulaUsuario in (select * from #temp)
    delete Estudiante
    where Cedula in (select * from #temp)
    drop table #temp
go


insert into Estudiante values(
'743873534', 'copia@inf.com', 'migel', 'wea', 'fiuewb', 'm', '1982-12-11', null, '88118814', 'A56783', 'Activo');
insert into Estudiante values(
'038743682', 'copia@inf.com', 'migel', 'wea', 'fiuewb', 'm', '1982-12-11', null, '88118814', 'A56783', 'Activo');



--2)
CREATE PROCEDURE dbo.agregarUsuario
/*Parámetros: pLogin donde se recibe el nombre de usuario,
pPassword donde se recibe la contraseña, cedula donde se recibe la
cédula del estudiante asociado
a dicho usuario y se declara el parámetro de salida estado que
devuelve 1 si el usuario se pudo guardar en la base de datos y
cualquier otro
número que corresponde al ERROR_MESSAGE() si no se pudo guardar*/
    @pLogin NVARCHAR(50),
    @pPassword NVARCHAR​(50),
    @cedula VARCHAR(10),
	@estado bit OUTPUT
AS
BEGIN​
SET NOCOUNT ON
/*Se genera un salt, el cual corresponde a una llave de
encriptación del password*/
​
DECLARE @salt UNIQUEIDENTIFIER=NEWID()
​
BEGIN TRY
/*Se inserta en la tabla Usuarios los datos de un nuevo usuario,
se encripta la contraseña con un HASHBYTES con el algoritmo
SHA2_512 con la unión
del password digitado y el salt (notese que este salt es único
para cada usuario sin importar que tengan la misma contraseña,
este se almacena
diferente para cada uno)*/
​
INSERT INTO dbo.[Usuarios] (cedulaUsuario, nombreUsuario,
PasswordHash,Salt)
​
VALUES (@cedula, @pLogin, HASHBYTES('SHA2_512', @pPassword+ CAST(@salt AS NVARCHAR (36​))), @salt​)
/* Si la inserción se pudo realizar se devuelve un 1*/
​
SET​ @estado= 1
​
END TRY
​
BEGIN
​
 CATCH
/* En cualquier otro caso se devuelve el mensaje de error*/
​
SET
​
 @estado=ERROR_MESSAGE()
​
END
​
 CATCH
END

--3:
CREATE FUNCTION loginUsuario
    (@pLoginName NVARCHAR​ (254), @pPassword NVARCHAR (50))
RETURNS bit
BEGIN
/*Se declara variable para buscar el usuario*/​
	DECLARE @userID INT, @result bit
/*Se pregunta si existe una cedulaUsuario que tenga en nombreUsuario lo
recibido en pLoginName*/
	IF​ EXISTS (SELECT TOP ​1 cedulaUsuario FROM​ [dbo].[Usuarios] WHERE 
	nombreUsuario=@pLoginName)
​
BEGIN
	/*Si si existe una cédula con este nombreUsuario se pregunta si el
Password de dicho usuario corresponde al recibido por parámetro junto
con el salt de esa tupla*/
​	SET @userID=(SELECT cedulaUsuario FROM [dbo].[Usuarios] WHERE nombreUsuario=@pLoginName AND​
	 PasswordHash=HASHBYTES('SHA2_512',@pPassword+CAST(Salt AS NVARCHAR(36​))))
/*si al final de ambas consultas userID es null se retorna 0*/​
	IF(@userID IS NULL)
		SET @result​ = ​0
/*Si al final de ambas consultas userID no es null se retorna 1*/​
	ELSE​
		set @result​ = 1
​END
/*Si no existe ninguna cédula asociada a ese nombre de usuario se
retorna 0*/​
ELSE​
	SET​ @result​ =​ 0
	​
RETURN​ @result
end;

--4:
GO
CREATE FUNCTION filtrarEstudiantes(@nombre VARCHAR​(​15​), @filtroTexto VARCHAR​(​20​))
RETURNS​​
TABLE
AS
	RETURN​(​ SELECT ​*​ FROM​ Estudiante e​ 
			WHERE​ e.Nombre LIKE '%' + @nombre + '%'
			AND (e.Nombre LIKE '%' + @filtroTexto + '%'
​			OR e.Apellido1 LIKE '%' + @filtroTexto + '%'​
			OR e.Apellido1 LIKE '%' + @filtroTexto + '%'​
			OR e.Cedula LIKE '%' + @filtroTexto + ​'%'​
			OR​ e.Carné LIKE '%' + @filtroTexto + '%'
			)
);

