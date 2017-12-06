DELIMITER $$
DROP PROCEDURE IF EXISTS sp_saber_eliminarrelacion $$
CREATE PROCEDURE sp_saber_eliminarrelacion
(
  in_codigoAprendizaje VARCHAR(256),
  in_codigo VARCHAR(256)
)
BEGIN

  DELETE FROM aprendizajetienesaber
  WHERE codigo = in_codigo AND
  codigoAprendizaje = in_codigoAprendizaje;
END
$$
