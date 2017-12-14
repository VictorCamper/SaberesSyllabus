DELIMITER $$
DROP PROCEDURE IF EXISTS sp_aprendizajes_en_competencia $$
CREATE PROCEDURE sp_aprendizajes_en_competencia(
	in_codigoCompetencia INTEGER
)
BEGIN
	SELECT codigoAprendizaje
	FROM competencia_aprendizaje
	WHERE codigoCompetencia = in_codigoCompetencia;
END
$$