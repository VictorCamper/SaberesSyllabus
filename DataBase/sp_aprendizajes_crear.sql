DELIMITER $$
DROP PROCEDURE IF EXISTS sp_aprendizajes_crear $$
CREATE PROCEDURE sp_aprendizajes_crear
(
	in_codigo VARCHAR(250),
  	in_categoria VARCHAR(250),
  	in_subCategoria VARCHAR(250),
  	in_descripcion VARCHAR(250),
  	in_porcentajeLogro INTEGER,
  	in_estado VARCHAR(250)
)
BEGIN

	INSERT INTO aprendizaje(codigo, categoria, subCategoria, descripcion, porcentajeLogro, estado)
	VALUES (in_codigo, in_categoria, in_subCategoria, in_descripcion, in_porcentajeLogro, in_estado);

END
$$