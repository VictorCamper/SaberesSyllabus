DELIMITER $$
DROP PROCEDURE IF EXISTS sp_saber_logrado_leertodo $$
CREATE PROCEDURE sp_saber_logrado_leertodo()
BEGIN
	SELECT codigo, descripcion, nivelLogro, estado, porcentajeLogro
	FROM saber
	WHERE porcentajeLogro = 100;
END
$$
