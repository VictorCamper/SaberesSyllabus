DELIMITER $$
DROP PROCEDURE IF EXISTS sp_aprendizajes_editarsubcategoria $$
CREATE PROCEDURE sp_aprendizajes_editarsubcategoria
(
	in_subcategoria VARCHAR(512),
	in_subcategoriaprev VARCHAR(512)
)
BEGIN
	UPDATE subcategoria SET subcategoria = in_subcategoria WHERE subcategoria = in_subcategoriaprev;
END
$$

