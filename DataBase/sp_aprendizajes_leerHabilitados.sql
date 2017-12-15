DELIMITER $$
DROP PROCEDURE IF EXISTS sp_aprendizajes_leerHabilitados $$
CREATE PROCEDURE sp_aprendizajes_leerHabilitados()
BEGIN
	SELECT codigo, descripcion, porcentajeLogro, estado
	FROM aprendizaje
	WHERE estado = 'Habilitado';
END
$$