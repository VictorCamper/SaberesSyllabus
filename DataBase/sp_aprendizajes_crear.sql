DELIMITER $$
DROP PROCEDURE IF EXISTS sp_aprendizajes_crear $$
CREATE PROCEDURE sp_aprendizajes_crear
(
	in_codigo INTEGER,
  	in_subCategoria VARCHAR(512),
  	in_descripcion VARCHAR(256),
  	in_porcentajeLogro INTEGER,
  	in_estado VARCHAR(256),
  	OUT out_codigo INTEGER

)
BEGIN
	
	INSERT INTO aprendizaje(codigo, subCategoria, descripcion, porcentajeLogro, estado)
	VALUES (in_codigo, in_subCategoria, in_descripcion, in_porcentajeLogro, in_estado);

	SET out_codigo = LAST_INSERT_ID();
END
$$