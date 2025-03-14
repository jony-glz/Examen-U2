CREATE DATABASE agenda;

USE agenda;

CREATE TABLE usuarios(
	id int IDENTITY(1,1) primary key,
	a_paterno varchar(50) NOT NULL,
	a_materno varchar(50) NOT NULL,
	nombre varchar(60) NOT NULL,
	telefono char(10) NOT NULL,
	correo varchar(70) NOT NULL
);

ALTER TABLE usuarios 
ADD CONSTRAINT ck_mail
CHECK (correo LIKE'%@%.%');

SELECT * FROM usuarios;