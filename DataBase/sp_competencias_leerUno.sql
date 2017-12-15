DELIMITER $$
DROP PROCEDURE IF EXISTS sp_competencias_leerUno $$
CREATE PROCEDURE sp_competencias_leerUno(
	in_codigo INTEGER
)
BEGIN
	SELECT Competencia.*
	FROM Competencia
	WHERE codigo = in_codigo;
END
$$