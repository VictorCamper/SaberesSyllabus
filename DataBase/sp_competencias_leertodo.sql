DELIMITER $$
DROP PROCEDURE IF EXISTS sp_competencias_leertodo $$
CREATE PROCEDURE sp_competencias_leertodo()
BEGIN
	SELECT codigo, descripcion, nivel_dominio, basico, intermedio, avanzado, tiempoDesarrollo, estado
	FROM competencia;
END
$$
