DELIMITER $$
DROP PROCEDURE IF EXISTS sp_claseSaberQuitar $$
CREATE PROCEDURE sp_claseSaberQuitar
(
	in_idClase VARCHAR(256), 
	in_idSaber VARCHAR(256)
)
BEGIN
	DELETE FROM clase_saber
	WHERE clase_saber.idClase=in_idClase AND clase_saber.codigoSaber=in_idSaber;

END
$$