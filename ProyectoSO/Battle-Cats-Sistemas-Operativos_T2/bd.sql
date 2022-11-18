DROP DATABASE IF EXISTS bd;

CREATE DATABASE bd; 



USE bd;



CREATE TABLE partidas (

  IDPartida int(10) ,

  IDEquipo1 int(10) ,	

  IDEquipo2 int(10) ,

  FechayHoraFinal datetime not NULL ,

  Duracion int(3),

  Resultado tinyint(1)

);



CREATE TABLE RelacionIDsPartidas (

  IDJugador int(10) ,

  IDEquipo int(10) , 
  
  IDPartida int(10)

);



CREATE TABLE jugador (

  ID int(10) ,

  Username varchar(20) ,

  Correo varchar(25) ,

  Contrasenya varchar(12) ,

  FechaDeNacimiento DATE not NULL
  
  );



INSERT INTO partidas (IDPartida,IDEquipo1,IDEquipo2,FechayHoraFinal,Duracion,Resultado) VALUES (145678902,143548890,145789086,'2022-8-21 14:33:56', 250,1);

INSERT INTO partidas (IDPartida,IDEquipo1,IDEquipo2,FechayHoraFinal,Duracion,Resultado) VALUES (10986724,76354424,24098810,'2022-8-24 17:33:25', 225,0);

INSERT INTO partidas (IDPartida,IDEquipo1,IDEquipo2,FechayHoraFinal,Duracion,Resultado) VALUES (19036278,36589070,09875512,'2022-7-2  12:09:13', 250,1);



INSERT INTO jugador (ID,Username,Correo,Contrasenya,FechaDeNacimiento) VALUES (1,'ElRulas','joseAntonio@gmail.com','Egipto4523','2004-8-21');

INSERT INTO jugador (ID,Username,Correo,Contrasenya,FechaDeNacimiento) VALUES (2,'ElBotellas','xmax@gmail.com','123456','2003-12-08');

INSERT INTO jugador (ID,Username,Correo,Contrasenya,FechaDeNacimiento) VALUES (3,'Eltovallons','Pep@gmail.com','452389','2002-1-03');



INSERT INTO RelacionIDsPartidas (IDJugador,IDEquipo,IDPartida) VALUES (1,143548890,145678902);

INSERT INTO RelacionIDsPartidas (IDJugador,IDEquipo,IDPartida) VALUES (2,143548890,145678902);

INSERT INTO RelacionIDsPartidas (IDJugador,IDEquipo,IDPartida) VALUES (3,145789086,145678902);

INSERT INTO RelacionIDsPartidas (IDJugador,IDEquipo,IDPartida) VALUES (3,76354424,10986724);

INSERT INTO RelacionIDsPartidas (IDJugador,IDEquipo,IDPartida) VALUES (1,24098810,10986724);

INSERT INTO RelacionIDsPartidas (IDJugador,IDEquipo,IDPartida) VALUES (2,24098810,10986724);

INSERT INTO RelacionIDsPartidas (IDJugador,IDEquipo,IDPartida) VALUES (1,36589070,19036278);

INSERT INTO RelacionIDsPartidas (IDJugador,IDEquipo,IDPartida) VALUES (2,36589070,19036278);

INSERT INTO RelacionIDsPartidas (IDJugador,IDEquipo,IDPartida) VALUES (3,09875512,19036278);







