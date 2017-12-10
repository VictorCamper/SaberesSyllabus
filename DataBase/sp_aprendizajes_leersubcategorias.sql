DELIMITER $$
DROP PROCEDURE IF EXISTS sp_aprendizajes_leertodo $$
CREATE PROCEDURE sp_aprendizajes_leersubcategorias(
	in_categoria VARCHAR(256)
)
BEGIN
	SELECT subCategoria, codigo
	FROM subcategoria
	WHERE ref_categoria = in_categoria;
END
$$
