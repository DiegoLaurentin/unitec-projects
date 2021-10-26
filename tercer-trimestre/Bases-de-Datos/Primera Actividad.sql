create database CurriculumV1

create table datos_curriculum
(
nombre varchar(50),
apellido varchar(50),
cedula int,
edad int,
carrera varchar(50),
universidad varchar(50),
programa1 varchar(50),
programa2 varchar(50),
programa3 varchar(50),
programa4 varchar(50),
programa5 varchar(50),
)

insert into datos_curriculum values ('Diego', 'Laurentin', 30096907, 18, 'Ing. Informática', 'UNITEC', 'Adobe Photoshop', 'Adobe XD', 'Adobe Lightroom', 'Adobe Premier Pro', 'Adobe Illustrator');
