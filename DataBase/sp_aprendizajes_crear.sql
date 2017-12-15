DELIMITER $$
DROP PROCEDURE IF EXISTS sp_aprendizajes_crear $$
CREATE PROCEDURE sp_aprendizajes_crear
(
	in_subCategoria INTEGER,
  	in_descripcion VARCHAR(250),
  	in_porcentajeLogro INTEGER,
  	in_estado VARCHAR(250),
  	OUT out_codigo INTEGER

)
BEGIN
	
	INSERT INTO aprendizaje(ref_subCategoria, descripcion, porcentajeLogro, estado)
	VALUES (in_subCategoria, in_descripcion, in_porcentajeLogro, in_estado);

	SET out_codigo = LAST_INSERT_ID();
END
$$
