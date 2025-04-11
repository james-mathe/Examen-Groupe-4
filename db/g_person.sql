create database g_personne
go
use g_personne
go

create table personne
(
	idP bigint identity(1,1) not null,
	nom varchar(50) not null,
	postnom varchar(50),
	prenom varchar(50),
	sexe varchar(1) default 'M' not null
)
go
-- to create a primary key
alter table personne add constraint pk_P primary key(idP)
-- to test if the three fields(name) doesn't exist 
alter table personne add constraint un_P unique(nom,postnom,prenom)
-- to check if the field 'sexe' is equal to 'M' or 'F' and refuse the others
alter table personne add constraint ch_P check(sexe='M' or sexe='F')

go

create table telephone 
(
	idT bigint identity(1,1) not null,
	idP bigint not null,
	initial varchar(4) not null,
	numero varchar(9) not null
)
go

alter table telephone add constraint pk_T primary key(idT)
-- to create a foreign key to link the IdP from telephone to the primary key 'idP' of Personne and will be deleted if the premary key was
alter table telephone add constraint fk_T_P foreign key(idP) references personne(idP) on delete cascade

go

create table adresse
(
	idA bigint identity(1,1) not null,
	idP bigint not null,
	avenue varchar(50),
	quartier varchar(50),
	commune varchar(50),
	ville varchar(50),
	pays varchar(50) not null
)
go 

alter table adresse add constraint pk_A primary key(idA)
alter table adresse add constraint fk_A_P foreign key(idP) references personne(idP) on delete cascade

go

create table users
(
	idU bigint identity(1,1) not null,
	username varchar(50),
	pwd varchar(50)
)
go 

alter table users add constraint pk_U primary key(idU)