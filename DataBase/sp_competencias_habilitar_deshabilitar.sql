DELIMITER $$
DROP PROCEDURE IF EXISTS sp_competencias_habilitar_deshabilitar $$
CREATE PROCEDURE sp_competencias_habilitar_deshabilitar
(
	in_codigo bigint,
	in_estado VARCHAR(256)
	
)
BEGIN

	UPDATE competencia
	SET estado = in_estado
	WHERE codigo = in_codigo;
END
$$