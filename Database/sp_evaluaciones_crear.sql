DELIMITER $$
DROP PROCEDURE IF EXISTS sp_evaluaciones_crear $$
CREATE PROCEDURE sp_evaluaciones_crear
(
    in_id VARCHAR(256),
    in_tipoEvaluacion VARCHAR(256)
)
BEGIN

	INSERT INTO evaluacion(id, tipoEvaluacion)
	VALUES (in_id ,in_tipoEvaluacion);

	SET out_codigo = LAST_INSERT_ID();
END
$$