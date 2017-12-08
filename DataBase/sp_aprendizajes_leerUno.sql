DELIMITER $$
DROP PROCEDURE IF EXISTS sp_aprendizajes_leerUno $$
CREATE PROCEDURE sp_aprendizajes_leerUno(
	in_codigo INTEGER
)
BEGIN
	SELECT codigo, subCategoria, descripcion, porcentajeLogro, estado
	FROM aprendizaje
	WHERE codigo = in_codigo;
END
$$