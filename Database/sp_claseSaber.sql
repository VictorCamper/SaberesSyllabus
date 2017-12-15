DELIMITER $$
DROP PROCEDURE IF EXISTS sp_claseSaber $$
CREATE PROCEDURE sp_claseSaber
(
	in_idClase VARCHAR(256), 
	in_idSaber VARCHAR(256)
)
BEGIN

	INSERT INTO clase_saber(idClase,codigoSaber)
	VALUES (in_idClase, in_idSaber);
	
END
$$