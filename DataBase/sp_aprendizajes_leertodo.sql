DELIMITER $$
DROP PROCEDURE IF EXISTS sp_aprendizajes_leertodo $$
CREATE PROCEDURE sp_aprendizajes_leertodo()
BEGIN
	SELECT codigo, categoria, descripcion, codigoCompetencia, estado
	FROM aprendizaje;
END
$$
