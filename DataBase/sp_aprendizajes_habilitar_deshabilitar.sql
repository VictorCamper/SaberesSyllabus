DELIMITER $$
DROP PROCEDURE IF EXISTS sp_aprendizajes_habilitar_deshabilitar $$
CREATE PROCEDURE sp_aprendizajes_habilitar_deshabilitar
(
	in_codigo VARCHAR(256),
	in_estado VARCHAR(256)
	
)
BEGIN
	UPDATE aprendizaje
	SET estado = in_estado
	WHERE codigo = in_codigo;
END
$$