DELIMITER $$
DROP PROCEDURE IF EXISTS sp_clases_leertodo $$
CREATE PROCEDURE sp_clases_leertodo()
BEGIN
	SELECT id, fecha, descripcion
	FROM clase;
END
$$
