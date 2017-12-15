DELIMITER $$
DROP PROCEDURE IF EXISTS sp_aprendizaje_eliminarrelacion $$
CREATE PROCEDURE sp_aprendizaje_eliminarrelacion
(
  in_codigoCompetencia INTEGER,
  in_codigoAprendizaje VARCHAR(250)  
)
BEGIN

  DELETE FROM Competencia_Aprendizaje
  WHERE codigoCompetencia = in_codigoCompetencia AND
  codigoAprendizaje = in_codigoAprendizaje;
END
$$