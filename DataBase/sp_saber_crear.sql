DELIMITER $$
DROP PROCEDURE IF EXISTS sp_saber_crear $$
CREATE PROCEDURE sp_saber_crear
(
	in_codigo VARCHAR(256),
  	in_descripcion VARCHAR(256),
  	in_nivelLogro VARCHAR(256),
  	in_estado VARCHAR(256),
  	in_porcentajeLogro INTEGER,
	OUT out_codigo INTEGER
)
BEGIN

	INSERT INTO saber(codigo, descripcion, nivelLogro, estado, porcentajeLogro)
	VALUES (in_codigo, in_descripcion, in_nivelLogro, in_estado, in_porcentajeLogro);

END
$$
