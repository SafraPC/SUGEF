create database SUGEF;

USE SUGEF;

create table Users(
userId integer AUTO_INCREMENT,
userName  varchar(50) not null,
userTipo varchar(50) not null,
userLogin Varchar(50) not null UNIQUE,
userSenha Varchar(100) not null,
userNascimento date not null,
userCpf varchar(11) not null,
userFoto longblob NULL,
CONSTRAINT pk_userId PRIMARY KEY (userId)
);

create table Materia(
materiaId integer auto_increment,
userId integer NOT null,
materiaNome varchar(50) Not NULL,
CONSTRAINT pk_materiaId PRIMARY KEY (materiaId),
CONSTRAINT fk_userProf FOREIGN KEY (userId) REFERENCES Users (userId)
);

create table Turma(
turmaId integer auto_increment,
materiaId integer not NULL,
turmaPeriodo varchar(20) NOT NULL,
turmaAno year NOT NULL,
turmaFaltas integer not null,
CONSTRAINT pk_turmaId PRIMARY KEY (turmaId),
CONSTRAINT fk_materiaId FOREIGN KEY (materiaId) REFERENCES Materia (materiaId)
);

create table Matricula(
matriculaId integer auto_increment,
UserId integer,
turmaId Integer,
totalFaltas integer not null,
Primary KEY (matriculaId),
CONSTRAINT fk_UserAluno FOREIGN KEY (USerId) REFERENCES Users (UserId),
CONSTRAINT fk_turmaId FOREIGN KEY (turmaId) REFERENCES Turma (TurmaId)
);

create table Notas(
notasId integer auto_increment, 
matriculaId integer,
userId integer,
nota1 float,
nota2 float,
nota3 float,
nota4 float,
CONSTRAINT pk_notasId Primary Key (notasId),
CONSTRAINT fk_matriculaId FOREIGN KEY (matriculaId) references Matricula (matriculaId),
CONSTRAINT fk_userIdAluno FOREIGN KEY (userId) references Users (userId)
);



insert into Users 
values
(default,'Brad Pit','Aluno','Brad123','1111','1966/10/10','11111111111','https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn-icons-png.flaticon.com%2F512%2F2145%2F2145119.png&imgrefurl=https%3A%2F%2Fwww.flaticon.com%2Fbr%2Ficone-gratis%2Fprogramacao_2145119&tbnid=KIkEJdsH5EcS7M&vet=12ahUKEwjfw7ylwYr4AhW7N7kGHY7lDA8QMygAegUIARC9AQ..i&docid=jLIA9lbzJZH-JM&w=512&h=512&q=imagem%20de%20programa%C3%A7%C3%A3o%20png&ved=2ahUKEwjfw7ylwYr4AhW7N7kGHY7lDA8QMygAegUIARC9AQ'),
(default,'Nicolas Cage','Aluno','Nicolas123','1212','1952/09/30','22222222222','https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn-icons-png.flaticon.com%2F512%2F2145%2F2145119.png&imgrefurl=https%3A%2F%2Fwww.flaticon.com%2Fbr%2Ficone-gratis%2Fprogramacao_2145119&tbnid=KIkEJdsH5EcS7M&vet=12ahUKEwjfw7ylwYr4AhW7N7kGHY7lDA8QMygAegUIARC9AQ..i&docid=jLIA9lbzJZH-JM&w=512&h=512&q=imagem%20de%20programa%C3%A7%C3%A3o%20png&ved=2ahUKEwjfw7ylwYr4AhW7N7kGHY7lDA8QMygAegUIARC9AQ'),
(default,'Uma Turman','Aluno','Uma123','1313','1972/03/15','33333333333','https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn-icons-png.flaticon.com%2F512%2F2145%2F2145119.png&imgrefurl=https%3A%2F%2Fwww.flaticon.com%2Fbr%2Ficone-gratis%2Fprogramacao_2145119&tbnid=KIkEJdsH5EcS7M&vet=12ahUKEwjfw7ylwYr4AhW7N7kGHY7lDA8QMygAegUIARC9AQ..i&docid=jLIA9lbzJZH-JM&w=512&h=512&q=imagem%20de%20programa%C3%A7%C3%A3o%20png&ved=2ahUKEwjfw7ylwYr4AhW7N7kGHY7lDA8QMygAegUIARC9AQ'),
(default,'Nicole Kidman','Professor','Nicole123','1414','1970/12/12','44444444444','https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn-icons-png.flaticon.com%2F512%2F2145%2F2145119.png&imgrefurl=https%3A%2F%2Fwww.flaticon.com%2Fbr%2Ficone-gratis%2Fprogramacao_2145119&tbnid=KIkEJdsH5EcS7M&vet=12ahUKEwjfw7ylwYr4AhW7N7kGHY7lDA8QMygAegUIARC9AQ..i&docid=jLIA9lbzJZH-JM&w=512&h=512&q=imagem%20de%20programa%C3%A7%C3%A3o%20png&ved=2ahUKEwjfw7ylwYr4AhW7N7kGHY7lDA8QMygAegUIARC9AQ'),
(default,'Samuel Jackson','Professor','samuel123','1515','1966/10/10','55555555555','https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn-icons-png.flaticon.com%2F512%2F2145%2F2145119.png&imgrefurl=https%3A%2F%2Fwww.flaticon.com%2Fbr%2Ficone-gratis%2Fprogramacao_2145119&tbnid=KIkEJdsH5EcS7M&vet=12ahUKEwjfw7ylwYr4AhW7N7kGHY7lDA8QMygAegUIARC9AQ..i&docid=jLIA9lbzJZH-JM&w=512&h=512&q=imagem%20de%20programa%C3%A7%C3%A3o%20png&ved=2ahUKEwjfw7ylwYr4AhW7N7kGHY7lDA8QMygAegUIARC9AQ'),
(default,'Marcelo Almeida','Aluno','marcelo123','1616','1967/11/11','66666666666','https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn-icons-png.flaticon.com%2F512%2F2145%2F2145119.png&imgrefurl=https%3A%2F%2Fwww.flaticon.com%2Fbr%2Ficone-gratis%2Fprogramacao_2145119&tbnid=KIkEJdsH5EcS7M&vet=12ahUKEwjfw7ylwYr4AhW7N7kGHY7lDA8QMygAegUIARC9AQ..i&docid=jLIA9lbzJZH-JM&w=512&h=512&q=imagem%20de%20programa%C3%A7%C3%A3o%20png&ved=2ahUKEwjfw7ylwYr4AhW7N7kGHY7lDA8QMygAegUIARC9AQ'),
(default,'Marcos Almeida','Professor','marcos123','1717','1968/10/10','77777777777','https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn-icons-png.flaticon.com%2F512%2F2145%2F2145119.png&imgrefurl=https%3A%2F%2Fwww.flaticon.com%2Fbr%2Ficone-gratis%2Fprogramacao_2145119&tbnid=KIkEJdsH5EcS7M&vet=12ahUKEwjfw7ylwYr4AhW7N7kGHY7lDA8QMygAegUIARC9AQ..i&docid=jLIA9lbzJZH-JM&w=512&h=512&q=imagem%20de%20programa%C3%A7%C3%A3o%20png&ved=2ahUKEwjfw7ylwYr4AhW7N7kGHY7lDA8QMygAegUIARC9AQ'),
(default,'Cleide','Aluno','cleide123','1818','1969/10/10','88888888888','https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn-icons-png.flaticon.com%2F512%2F2145%2F2145119.png&imgrefurl=https%3A%2F%2Fwww.flaticon.com%2Fbr%2Ficone-gratis%2Fprogramacao_2145119&tbnid=KIkEJdsH5EcS7M&vet=12ahUKEwjfw7ylwYr4AhW7N7kGHY7lDA8QMygAegUIARC9AQ..i&docid=jLIA9lbzJZH-JM&w=512&h=512&q=imagem%20de%20programa%C3%A7%C3%A3o%20png&ved=2ahUKEwjfw7ylwYr4AhW7N7kGHY7lDA8QMygAegUIARC9AQ'),
(default,'Tatiane Regina','Aluno','tati123','1919','1970/10/10','99999999999','https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn-icons-png.flaticon.com%2F512%2F2145%2F2145119.png&imgrefurl=https%3A%2F%2Fwww.flaticon.com%2Fbr%2Ficone-gratis%2Fprogramacao_2145119&tbnid=KIkEJdsH5EcS7M&vet=12ahUKEwjfw7ylwYr4AhW7N7kGHY7lDA8QMygAegUIARC9AQ..i&docid=jLIA9lbzJZH-JM&w=512&h=512&q=imagem%20de%20programa%C3%A7%C3%A3o%20png&ved=2ahUKEwjfw7ylwYr4AhW7N7kGHY7lDA8QMygAegUIARC9AQ'),
(default,'Adevando Alves','Aluno','Nando123','2020','1971/10/10','01010101010','https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn-icons-png.flaticon.com%2F512%2F2145%2F2145119.png&imgrefurl=https%3A%2F%2Fwww.flaticon.com%2Fbr%2Ficone-gratis%2Fprogramacao_2145119&tbnid=KIkEJdsH5EcS7M&vet=12ahUKEwjfw7ylwYr4AhW7N7kGHY7lDA8QMygAegUIARC9AQ..i&docid=jLIA9lbzJZH-JM&w=512&h=512&q=imagem%20de%20programa%C3%A7%C3%A3o%20png&ved=2ahUKEwjfw7ylwYr4AhW7N7kGHY7lDA8QMygAegUIARC9AQ');

INSERT INTO Users 
values
(default,'Director Test','Diretor','diretor','123','1966/10/10','66666666662',''),
(default,'Professor Test','Professor','professor','123','1966/10/10','66666666661',''),
(default,'Aluno Test','Aluno','Aluno','123','1966/10/10','66666666665','');



Insert Into Materia
values
(default,4,'Portugues'),
(default,5,'Matematica'),
(default,4,'Geografia'),
(default,5,'Fisica'),
(default,4,'Biologa');

Insert Into Turma
values
(default,3,'Noturno',2020,100),
(default,2,'Noturno',2019,100),
(default,4,'Noturno',2020,100),
(default,5,'Noturno',2020,100);

Insert into Matricula
values
(default,1,1,15),
(default,2,3,49),
(default,3,2,39),
(default,6,2,24),
(default,8,2,0),
(default,9,2,5),
(default,10,2,10);

Insert into Notas
values
(default,1,1,7,0,0,0),
(default,2,3,7,0,0,0),
(default,3,2,8,0,0,0),
(default,4,6,8,0,0,0),
(default,5,8,8,0,0,0),
(default,6,9,8,0,0,0),
(default,7,10,9,0,0,0);