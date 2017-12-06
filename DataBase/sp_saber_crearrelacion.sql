DELIMITER $$
DROP PROCEDURE IF EXISTS sp_saber_crearrelacion $$
CREATE PROCEDURE sp_saber_crearrelacion
(
  in_codigoAprendizaje VARCHAR(256),
	in_codigo VARCHAR(256)  
)
BEGIN

  INSERT INTO aprendizajetienesaber(codigoAprendizaje, codigoSaber)
  VALUES (in_codigoAprendizaje, in_codigo);

END
$$
