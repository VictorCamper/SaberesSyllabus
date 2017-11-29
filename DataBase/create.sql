DROP DATABASE IF EXISTS syllabus;
CREATE DATABASE syllabus;

DROP TABLE IF EXISTS
  syllabus.unidad
DROP TABLE IF EXISTS
  syllabus.curso
DROP TABLE IF EXISTS
  syllabus.competencia
DROP TABLE IF EXISTS
syllabus.saber
DROP TABLE IF EXISTS
syllabus.aprendizaje
DROP TABLE IF EXISTS
syllabus.evaluacion
DROP TABLE IF EXISTS
syllabus.clase
 
CREATE TABLE syllabus.unidad(
  titulo VARCHAR(256),
  PRIMARY KEY(titulo)
);
CREATE TABLE syllabus.curso(
  nombre VARCHAR(256),
  tituloUnidad VARCHAR(256),
  horasPresenciales INTEGER,
  horasAutonomas INTEGER,
  descripcion VARCHAR(256),
  PRIMARY KEY(nombre),
  FOREIGN KEY(tituloUnidad) REFERENCES unidad(titulo) ON DELETE CASCADE
);
CREATE TABLE syllabus.competencia(
  codigo INTEGER,
  nombreCurso_Comp VARCHAR(256),
  descripcion VARCHAR(256),
  nivel VARCHAR(256),
  PRIMARY KEY(codigo),
  FOREIGN KEY(nombreCurso_Comp) REFERENCES curso(nombre) ON DELETE CASCADE
);
CREATE TABLE syllabus.saber(
  codigo INTEGER,
  descripcion VARCHAR(256),
  nivelLogro VARCHAR(256),
  PRIMARY KEY(codigo)
);
CREATE TABLE syllabus.aprendizaje(
  codigo INTEGER,
  codigoCompetencia INTEGER,
  codigoSaber INTEGER,
  categoria VARCHAR(256),
  descripcion VARCHAR(256),
  PRIMARY KEY(codigo),
  FOREIGN KEY(codigoCompetencia) REFERENCES competencia(codigo) ON DELETE CASCADE,
  FOREIGN KEY(codigoSaber) REFERENCES saber(codigo) ON DELETE CASCADE

);
CREATE TABLE syllabus.evaluacion(
  tituloUnidad VARCHAR(256),
  codigoSaber INTEGER,
  tipo VARCHAR(256),
  FOREIGN KEY(tituloUnidad) REFERENCES unidad(titulo) ON DELETE CASCADE,
  FOREIGN KEY(codigoSaber) REFERENCES saber(codigo) ON DELETE CASCADE
);
CREATE TABLE syllabus.clase(
  codigo INTEGER,
  nombreUnidad VARCHAR(256),
  codigoSaber INTEGER,
  fecha DATE,
  horaInicio TIME,
  horaTermino TIME,
  tema VARCHAR(256),
  descripcion VARCHAR(256),
  PRIMARY KEY(codigo),
  FOREIGN KEY(nombreUnidad) REFERENCES unidad(titulo) ON DELETE CASCADE,
  FOREIGN KEY(codigoSaber) REFERENCES saber(codigo) ON DELETE CASCADE
);