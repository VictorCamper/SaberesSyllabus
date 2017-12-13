DELIMITER $$
DROP PROCEDURE IF EXISTS sp_saber_crear $$
CREATE PROCEDURE sp_saber_crear
(
	in_codigo VARCHAR(250),
  	in_descripcion VARCHAR(250),
  	in_nivelLogro VARCHAR(250),
  	in_estado VARCHAR(250),
  	in_porcentajeLogro INTEGER
	
)
BEGIN

	INSERT INTO saber(codigo, descripcion, nivelLogro, estado, porcentajeLogro)
	VALUES (in_codigo, in_descripcion, in_nivelLogro, in_estado, in_porcentajeLogro);

END
$$
