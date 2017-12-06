DELIMITER $$ 
DROP PROCEDURE IF EXISTS sp_saberes_crear $$ 
CREATE PROCEDURE sp_saberes_crear 
( 
    in_codigo VARCHAR(256),  
    in_descripcion VARCHAR(256),
    in_nivelLogro VARCHAR(256), 
    in_codigoAprendizaje INTEGER, 
    in_estado VARCHAR(256) 
) 
BEGIN 
 
  INSERT INTO saber(codigo, descripcion, nivelLogro, codigoAprendizaje, estado) 
  VALUES (in_codigo, in_descripcion, in_nivelLogro, in_codigoAprendizaje, in_estado); 
 
END 
$$