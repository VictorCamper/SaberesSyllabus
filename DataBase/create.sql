DROP DATABASE IF EXISTS syllabus;
CREATE DATABASE syllabus;

DROP TABLE IF EXISTS
  syllabus.competencia;
DROP TABLE IF EXISTS
  syllabus.aprendizaje;
DROP TABLE IF EXISTS
  syllabus.saber;
DROP TABLE IF EXISTS
  syllabus.curso;
DROP TABLE IF EXISTS
  syllabus.unidad;
DROP TABLE IF EXISTS
  syllabus.evaluacion;
DROP TABLE IF EXISTS
  syllabus.clase;
DROP TABLE IF EXISTS
  syllabus.cursoposeecompetencia;
DROP TABLE IF EXISTS
  syllabus.unidadtienesaber;
DROP TABLE IF EXISTS
  syllabus.claseposeesaber;

USE syllabus;

CREATE TABLE syllabus.competencia(
  codigo INTEGER PRIMARY KEY AUTO_INCREMENT,
  descripcion VARCHAR(256),
  nivel_dominio VARCHAR(256),
  basico TEXT,
  intermedio TEXT,
  avanzado TEXT,
  tiempoDesarrollo VARCHAR(256),
  estado VARCHAR(256)
);

CREATE TABLE syllabus.aprendizaje(
  codigo VARCHAR(256),
  categoria VARCHAR(256),
  descripcion VARCHAR(256),
  codigoCompetencia INTEGER,
  estado VARCHAR(256),
  PRIMARY KEY(codigo),
  FOREIGN KEY(codigoCompetencia) REFERENCES competencia(codigo) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE syllabus.nivelLogroaprendizaje (
  codigo INTEGER PRIMARY KEY AUTO_INCREMENT,
  codigoAprendizaje VARCHAR(256),
  nivelLogro VARCHAR(256),
  FOREIGN KEY(codigoAprendizaje) REFERENCES aprendizaje(codigo) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE syllabus.saber(
  codigo VARCHAR(256) PRIMARY KEY,
  descripcion VARCHAR(256),
  codigoAprendizaje VARCHAR(256),
  estado VARCHAR(256),
  FOREIGN KEY(codigoAprendizaje) REFERENCES aprendizaje(codigo) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE syllabus.nivelLogroTieneSaber (
  codigoNivelLogro INTEGER PRIMARY KEY,
  codigoSaber VARCHAR(256),
  FOREIGN KEY(codigoNivelLogro) REFERENCES nivelLogroaprendizaje(codigo) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY(codigoSaber) REFERENCES saber(codigo) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE syllabus.usuario(
  username varchar(200) PRIMARY KEY,
  passwrd varchar(200) NOT NULL,
  email varchar(256),
  cargo varchar(200),
  estado varchar(256)
);

CREATE TABLE syllabus.curso(
  nombre VARCHAR(256),
  horasPresenciales INTEGER,
  horasAutonomas INTEGER,
  descripcion VARCHAR(256),
  PRIMARY KEY(nombre)
);

CREATE TABLE syllabus.cursotienencargado(
  id INTEGER PRIMARY KEY AUTO_INCREMENT,
  codigousuario varchar(200),
  nombrecurso varchar(256),
  FOREIGN KEY(codigousuario) REFERENCES usuario(username) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY(nombreCurso) REFERENCES curso(nombre) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE syllabus.unidad(
  titulo VARCHAR(256),
  nombreCurso VARCHAR(256),
  PRIMARY KEY(titulo),
  FOREIGN KEY(nombreCurso) REFERENCES curso(nombre) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE syllabus.evaluacion(
  tituloUnidad VARCHAR(256),
  codigoSaber VARCHAR(256),
  tipo VARCHAR(256),
  FOREIGN KEY(tituloUnidad) REFERENCES unidad(titulo) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY(codigoSaber) REFERENCES saber(codigo) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE syllabus.clase(
  codigo INTEGER,
  fecha DATE,
  horaInicio TIME,
  horaTermino TIME,
  tema VARCHAR(256),
  descripcion VARCHAR(256),
  nombreUnidad VARCHAR(256),
  PRIMARY KEY(codigo),
  FOREIGN KEY(nombreUnidad) REFERENCES unidad(titulo) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE syllabus.cursoposeecompetencia(
  codigoCompetencia INTEGER,
  nombreCurso VARCHAR(256),
  nivelLogro VARCHAR(256),
  FOREIGN KEY(codigoCompetencia) REFERENCES competencia(codigo) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY(nombreCurso) REFERENCES curso(nombre) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE syllabus.unidadtienesaber(
  tituloUnidad VARCHAR(256),
  codigoSaber VARCHAR(256),
  FOREIGN KEY(tituloUnidad) REFERENCES unidad(titulo) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY(codigoSaber) REFERENCES saber(codigo) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE syllabus.claseposeesaber(
  codigoClase INTEGER,
  codigoSaber VARCHAR(256),
  FOREIGN KEY(codigoClase) REFERENCES clase(codigo) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY(codigoSaber) REFERENCES saber(codigo) ON DELETE CASCADE ON UPDATE CASCADE
);