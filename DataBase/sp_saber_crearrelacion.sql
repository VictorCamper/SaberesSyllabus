DELIMITER $$
DROP PROCEDURE IF EXISTS sp_saber_crearrelacion $$
CREATE PROCEDURE sp_saber_crearrelacion
(
	in_codigoAprendizaje VARCHAR(256),
	in_codigoSaber VARCHAR(256)
)
BEGIN

  INSERT INTO Aprendizaje_Saber(codigoAprendizaje, codigoSaber)
  VALUES (in_codigoAprendizaje, codigoSaber);
END
$$
