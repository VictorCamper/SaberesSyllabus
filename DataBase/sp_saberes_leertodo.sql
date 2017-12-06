DELIMITER $$ 
DROP PROCEDURE IF EXISTS sp_saberes_leertodo $$ 
CREATE PROCEDURE sp_saberes_leertodo() 
BEGIN 
  SELECT codigo, descripcion, nivelLogro, codigoAprendizaje, estado 
  FROM saber; 
END 
$$ 