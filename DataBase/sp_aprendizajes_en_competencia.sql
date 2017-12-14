DELIMITER $$
DROP PROCEDURE IF EXISTS sp_aprendizajes_en_competencia $$
CREATE PROCEDURE sp_aprendizajes_en_competencia(
	in_codigoCompetencia INTEGER
)
BEGIN
	SELECT Aprendizaje.* 
	FROM competencia_aprendizaje, Aprendizaje 
	WHERE competencia_aprendizaje.codigoCompetencia = in_codigoCompetencia AND Aprendizaje.codigo = competencia_aprendizaje.codigoAprendizaje 
END
$$