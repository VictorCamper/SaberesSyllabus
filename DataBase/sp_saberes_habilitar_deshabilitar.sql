DELIMITER $$ 
DROP PROCEDURE IF EXISTS sp_saberes_habilitar_deshabilitar $$ 
CREATE PROCEDURE sp_saberes_habilitar_deshabilitar 
( 
  in_codigo VARCHAR(250), 
  in_estado VARCHAR(250) 
   
) 
BEGIN 
  UPDATE saber 
  SET estado = in_estado 
  WHERE codigo = in_codigo; 
END 
$$