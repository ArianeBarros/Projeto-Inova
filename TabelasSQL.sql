


create table UsuarioI9(
cod int primary key,
nome varchar(30),
senha varchar(10),
dataNascimento datetime,
imagem ntext,
pontuacao int
)

select * from UsuarioI9

create table Evento(
id int primary key,
quando datetime,
localizacao ntext,
descricao ntext
)

select * from Evento

create table Realizacao(
cod int primary key,
descricao varchar(40),
dia datetime
)

create table Noticia(
cod int primary key,
link ntext,
imagem ntext,
manchete varchar(30)
)

select * from Noticia

create table Sonho(
cod int primary key,
descricao ntext
)

select * from Sonho