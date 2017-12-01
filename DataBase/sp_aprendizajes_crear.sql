DELIMITER $$
DROP PROCEDURE IF EXISTS sp_aprendizajes_crear $$
CREATE PROCEDURE sp_aprendizajes_crear
(
	in_codigo VARCHAR(256),
  	in_categoria VARCHAR(256),
  	in_descripcion VARCHAR(256),
  	in_codigoCompetencia INTEGER,
  	in_estado ARCHAR(256)
)
BEGIN

	INSERT INTO aprendizaje(codigo, categoria, descripcion, codigoCompetencia, estado)
	VALUES (in_codigo, in_categoria, in_descripcion, in_codigoCompetencia, in_estado);

END
$$