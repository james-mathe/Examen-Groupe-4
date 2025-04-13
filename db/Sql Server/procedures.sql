
use g_personne
go
-- procedure for inserting personne

create or alter proc addPerson @nom varchar(250),@pnom varchar(250),@prnom varchar(250),@sex char(1)
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
-- procedure for searching personne

-- procedure for deleting personne


exec UpdatePerson 2,'Kahindo','mathe','yvone','F'

select * from personne