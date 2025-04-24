
use g_personne
go
-- ==================== START PERSON PROCEDURE==========================================


-- procedure for inserting personne

create or alter proc AddPerson @nom varchar(250),@pnom varchar(250),@prnom varchar(250),@sex char(1)
as
begin
	insert into personne(nom,postnom,prenom,sexe) values(@nom,@pnom,@prnom,@sex)
end
go

-- procedure for updating personne

create or alter proc UpdatePerson @id bigint,@nom varchar(250),@pnom varchar(250),@prnom varchar(250),@sex char(1)
as
begin
	update personne set nom=@nom,postnom=@pnom,prenom=@prnom,sexe=@sex where idP=@id
end
go

-- procedure for searching personne

create or alter proc SearchPerson @nom varchar(250),@pnom varchar(250),@prnom varchar(250),@sex char(1)
as
begin
	select * from personne  where nom like '%'+@nom+'%' or postnom like '%'+@pnom+'%' or prenom like '%'+@prnom+'%' or sexe like '%'+@sex+'%'
end
go

-- procedure for deleting personne

create or alter proc DeletePerson @id bigint
as
begin
	delete from personne  where idP=@id
end
go

-- procedure for Selecting personne

create or alter proc SelectPerson
as
begin
	select * from personne
end
go

-- ==================== END PERSON PROCEDURE==========================================


-- ==================== START USER PROCEDURE==========================================


-- procedure for inserting users

create or alter proc AddUser @username varchar(250),@pwd varchar(250)
as
begin
	insert into users(username,pwd) values(@username,@pwd)
end
go

-- procedure for updating users

create or alter proc UpdateUser @id bigint,@username varchar(250),@pwd varchar(250)
as
begin
	Update users set username=@username,pwd=@pwd where idU=@id
end
go

-- procedure for searching users

create or alter proc SearchUser @username varchar(250)
as
begin
	select * from users where username like '%'+@username+'%'
end
go

-- procedure for deleting users

create or alter proc DeleteUser @id bigint
as
begin
	delete from users where idU=@id
end
go

-- ==================== END USER PROCEDURE==========================================


-- ==================== START TELEPHONE PROCEDURE==========================================

-- procedure for inserting telephone

create or alter proc AddPhone @idP bigint,@initial varchar(4),@numero varchar(9)
as
begin
	insert into telephone(idP,initial,numero) values(@idP,@initial,@numero)
end
go

-- procedure for updating telephone

create or alter proc UpdatePhone @idT bigint,@idP bigint,@initial varchar(4),@numero varchar(9)
as
begin
	update telephone set idP=@idP,initial=@initial,numero=@numero where idT=@idT
end
go

-- procedure for searching telephone

create or alter proc SearchPhone @fullname varchar(250),@initial varchar(4),@numero varchar(9)
as
begin
	select * from listPersonNumber where fullname like '%'+@fullname+'%' or initial like '%'+@initial+'%' or numero like '%'+@numero+'%' 
end
go

-- procedure for deleting telephone

create or alter proc DeletePhone @idT bigint
as
begin
	delete from telephone where idT=@idT
end
go


-- ==================== END TELEPHONE PROCEDURE==========================================


-- ==================== START ADDRESS PROCEDURE==========================================


-- procedure for inserting adresse

create or alter proc AddAddress @idP bigint,@av varchar(250),@qua varchar(250),@com varchar(250),@ville varchar(250),@pays varchar(250)
as
begin
	insert into adresse(idP,avenue,quartier,commune,ville,pays) values(@idP,@av,@qua,@com,@ville,@pays)
end
go

-- procedure for updating adresse

create or alter proc UpdateAddress @idA bigint,@idP bigint,@av varchar(250),@qua varchar(250),@com varchar(250),@ville varchar(250),@pays varchar(250)
as
begin
	update adresse set idP=@idP,avenue=@av,quartier=@qua,commune=@com,ville=@ville,pays=@pays where idA=@idA
end
go

-- procedure for searching adresse

create or alter proc SearchAddress @fullname varchar(250),@av varchar(250),@qua varchar(250),@com varchar(250),@ville varchar(250),@pays varchar(250)
as
begin
	select * from listPersonAddress where fullname like '%'+@fullname+'%' or avenue like '%'+@av+'%' or quartier like '%'+@qua+'%' or ville like '%'+@ville+'%' or commune like '%'+@com+'%' or pays like '%'+@pays+'%'
end
go

-- procedure for deleting adresse

create or alter proc DeleteAddress @idA bigint
as
begin
	delete from adresse  where idA=@idA
end
go


-- ==================== END ADDRESS PROCEDURE==========================================