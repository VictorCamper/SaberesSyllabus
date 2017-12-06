DELIMITER $$
DROP PROCEDURE IF EXISTS sp_saber_leertodo $$
CREATE PROCEDURE sp_saber_leertodo()
BEGIN
	SELECT codigo, descripcion, nivelLogro, estado
	FROM saber;
END
$$
