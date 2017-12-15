DELIMITER $$
DROP PROCEDURE IF EXISTS sp_evaluacion_editar $$
CREATE PROCEDURE sp_evaluacion_editar
(
	in_id VARCHAR(256),
	in_tipoevaluacion VARCHAR(256)
)
BEGIN
	UPDATE evaluacion SET tipoEvaluacion = in_tipoevaluacion WHERE evaluacion.id = in_id;
END
$$