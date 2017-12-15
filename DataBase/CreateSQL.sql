DROP DATABASE IF EXISTS syllabus;
CREATE DATABASE syllabus
	DEFAULT CHARACTER SET utf8
  	DEFAULT COLLATE utf8_general_ci;

use syllabus;

DROP TABLE IF EXISTS Curso;
DROP TABLE IF EXISTS Unidad;
DROP TABLE IF EXISTS Competencia;
DROP TABLE IF EXISTS Aprendizaje;
DROP TABLE IF EXISTS Saber;
DROP TABLE IF EXISTS Encargado;
DROP TABLE IF EXISTS Evaluacion;
DROP TABLE IF EXISTS Clase;
DROP TABLE IF EXISTS Alumno;
DROP TABLE IF EXISTS Aprendizaje_Saber;
DROP TABLE IF EXISTS Clase_Saber;
DROP TABLE IF EXISTS Evaluacion_Saber;
DROP TABLE IF EXISTS Unidad_Saber;
DROP TABLE IF EXISTS Alumno_Curso;
DROP TABLE IF EXISTS Curso_Encargado;
DROP TABLE IF EXISTS Competencia_Curso;
DROP TABLE IF EXISTS Competencia_Aprendizaje;
DROP TABLE IF EXISTS Unidad_Clase;
DROP TABLE IF EXISTS Curso_Unidad;
DROP TABLE IF EXISTS Unidad_Evaluacion;

CREATE TABLE Curso (
	id VARCHAR(250) NOT NULL,
	nombre TEXT NOT NULL,
	horasPresenciales INTEGER NOT NULL,
	horasAutonomas INTEGER NOT NULL,
	descripcion TEXT NOT NULL,
	estado TEXT NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE Unidad (
	id INTEGER NOT NULL,
	titulo TEXT NOT NULL,
	idCurso VARCHAR(250) NOT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (idCurso) REFERENCES Curso(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Competencia (
	codigo INTEGER AUTO_INCREMENT,
	nombre TEXT NOT NULL,
	descripcion TEXT NOT NULL,
	dominio VARCHAR(250) NOT NULL,
	basico TEXT NOT NULL,
	intermedio TEXT NOT NULL,
	avanzado TEXT NOT NULL,
	tiempoDesarrollo TEXT NOT NULL,
	estado TEXT NOT NULL,
	porcentajeLogro INTEGER NOT NULL,
	PRIMARY KEY (codigo)
);

CREATE TABLE Categoria (
	categoria VARCHAR(250) NOT NULL,
	PRIMARY KEY (categoria)
);

CREATE TABLE Subcategoria (
	id INTEGER AUTO_INCREMENT,
	subcategoria TEXT NOT NULL,
	ref_categoria VARCHAR(250) NOT NULL,
	codigo INTEGER NOT NULL,	
	PRIMARY KEY (id),
	FOREIGN KEY (ref_categoria) REFERENCES Categoria(categoria) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Aprendizaje (
	codigo INTEGER AUTO_INCREMENT,
	ref_subcategoria INTEGER NOT NULL,
	descripcion TEXT NOT NULL,
	porcentajeLogro INTEGER NOT NULL,
	estado TEXT NOT NULL,
	PRIMARY KEY (codigo),
	FOREIGN KEY (ref_subcategoria) REFERENCES Subcategoria(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Saber (
	id INTEGER AUTO_INCREMENT,
	codigo TEXT NOT NULL,
	descripcion TEXT NOT NULL,
	nivelLogro TEXT NOT NULL,
	estado TEXT NOT NULL,
	porcentajeLogro INTEGER NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE Encargado (
	nombre TEXT NOT NULL,
	rut VARCHAR(250) NOT NULL,
	cargo TEXT NOT NULL,
	PRIMARY KEY (rut)
);

CREATE TABLE Evaluacion (
	id INTEGER AUTO_INCREMENT,
	tipoEvaluacion TEXT NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE Clase (
	id INTEGER AUTO_INCREMENT,
	fecha DATE NOT NULL,
	tema TEXT NOT NULL,
	descripcion TEXT NOT NULL,
	tipoClase TEXT NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE Alumno (
	nombre TEXT NOT NULL,
	matricula VARCHAR(250) NOT NULL,
	PRIMARY KEY (matricula)
);

CREATE TABLE Aprendizaje_Saber (
	codigoAprendizaje INTEGER NOT NULL,
	idSaber INTEGER NOT NULL,
	FOREIGN KEY (codigoAprendizaje) REFERENCES Aprendizaje(codigo) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (idSaber) REFERENCES Saber(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Clase_Saber (
	idClase INTEGER NOT NULL,
	idSaber INTEGER NOT NULL,
	FOREIGN KEY (idSaber) REFERENCES Saber(id) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (idClase) REFERENCES Clase(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Evaluacion_Saber (
	idEvaluacion INTEGER NOT NULL,
	idSaber INTEGER NOT NULL,
	FOREIGN KEY (idSaber) REFERENCES Saber(id) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (idEvaluacion) REFERENCES Evaluacion(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Unidad_Saber (
	idUnidad INTEGER NOT NULL,
	idSaber INTEGER NOT NULL,
	FOREIGN KEY (idUnidad) REFERENCES Unidad(id) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (idSaber) REFERENCES Saber(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Alumno_Curso (
	idCurso VARCHAR(250) NOT NULL,
	matriculaAlumno VARCHAR(250) NOT NULL,
	FOREIGN KEY (idCurso) REFERENCES Curso(id) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (matriculaAlumno) REFERENCES Alumno(matricula) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Curso_Encargado (
	idCurso VARCHAR(250) NOT NULL,
	rutEncargado VARCHAR(250) NOT NULL,
	FOREIGN KEY (idCurso) REFERENCES Curso(id) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (rutEncargado) REFERENCES Encargado(rut) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Competencia_Curso (
	codigoCompetencia INTEGER NOT NULL,
	idCurso VARCHAR(250) NOT NULL,
	FOREIGN KEY (idCurso) REFERENCES Curso(id) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (codigoCompetencia) REFERENCES Competencia(codigo) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Competencia_Aprendizaje (
	codigoCompetencia INTEGER NOT NULL,
	codigoAprendizaje INTEGER NOT NULL,
	FOREIGN KEY (codigoCompetencia) REFERENCES Competencia(codigo) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (codigoAprendizaje) REFERENCES Aprendizaje(codigo) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Unidad_Clase (
	idUnidad INTEGER NOT NULL,
	idClase INTEGER NOT NULL,
	FOREIGN KEY (idUnidad) REFERENCES Unidad(id) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (idClase) REFERENCES Clase(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Curso_Unidad (
	idCurso VARCHAR(250) NOT NULL,
	idUnidad INTEGER NOT NULL,
	FOREIGN KEY (idCurso) REFERENCES Curso(id) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (idUnidad) REFERENCES Unidad(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Unidad_Evaluacion (
	idUnidad INTEGER NOT NULL,
	idEvaluacion INTEGER NOT NULL,
	FOREIGN KEY (idUnidad) REFERENCES Unidad(id) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (idEvaluacion) REFERENCES Evaluacion(id) ON DELETE CASCADE ON UPDATE CASCADE
);
