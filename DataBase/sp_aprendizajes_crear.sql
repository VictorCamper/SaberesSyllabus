DELIMITER $$
DROP PROCEDURE IF EXISTS sp_aprendizajes_crear $$
CREATE PROCEDURE sp_aprendizajes_crear
(
	in_codigo VARCHAR(256),
  	in_categoria VARCHAR(256),
  	in_subCategoria VARCHAR(256),
  	in_descripcion VARCHAR(256),
  	in_porcentajeLogro INTEGER,
  	in_estado VARCHAR(256)
)
BEGIN

	INSERT INTO aprendizaje(codigo, categoria, subCategoria, descripcion, porcentajeLogro, estado)
	VALUES (in_codigo, in_categoria, in_subCategoria, in_descripcion, in_porcentajeLogro, in_estado);

END
$$