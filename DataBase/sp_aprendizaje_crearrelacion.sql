DELIMITER $$
DROP PROCEDURE IF EXISTS sp_aprendizaje_crearrelacion $$
CREATE PROCEDURE sp_aprendizaje_crearrelacion
(
	in_codigoCompentencia INTEGER,
	in_codigoAprendizaje VARCHAR(250)
)
BEGIN

  INSERT INTO Competencia_Aprendizaje(codigoCompetencia, codigoAprendizaje)
  VALUES (in_codigoCompentencia, in_codigoAprendizaje);
END
$$
