
use g_personne
go
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
