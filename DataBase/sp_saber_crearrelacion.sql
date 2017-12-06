DELIMITER $$
DROP PROCEDURE IF EXISTS sp_saber_crearrelacion $$
CREATE PROCEDURE sp_saber_crearrelacion
(
  in_codigoAprendizaje VARCHAR(256),
	in_codigo VARCHAR(256),
  OUT out_codigo INTEGER
)
BEGIN

  INSERT INTO aprendizajetienesaber(codigoAprendizaje, codigoSaber)
  VALUES (in_codigoAprendizaje, in_codigo);

  SET out_codigo = LAST_INSERT_ID();

END
$$
