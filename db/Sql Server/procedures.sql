
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

-- procedure for searching users

-- procedure for deleting users


-- ==================== END USER PROCEDURE==========================================


-- ==================== START TELEPHONE PROCEDURE==========================================


-- procedure for inserting telephone

-- procedure for updating telephone

-- procedure for searching telephone

-- procedure for deleting telephone


-- ==================== END TELEPHONE PROCEDURE==========================================


-- ==================== START ADDRESS PROCEDURE==========================================


-- procedure for inserting adresse

-- procedure for updating adresse

-- procedure for searching adresse

-- procedure for deleting adresse


-- ==================== END ADDRESS PROCEDURE==========================================