DELIMITER $$
DROP PROCEDURE IF EXISTS leer_listaEvaluacionUnidad $$
CREATE PROCEDURE leer_listaEvaluacionUnidad(
	in_tituloUnidad VARCHAR(256)
)
BEGIN
	SELECT   evaluacion.tipoEvaluacion

	FROM unidad INNER JOIN unidad_evaluacion ON unidad.id = unidad_evaluacion.idUnidad
			    INNER JOIN evaluacion ON unidad_evaluacion.idEvaluacion = evaluacion.id

	WHERE unidad.titulo = in_tituloUnidad;
END
$$


