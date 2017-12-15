DELIMITER $$
DROP PROCEDURE IF EXISTS sp_saber_leerNoRelacion $$
CREATE PROCEDURE sp_saber_leerNoRelacion
(
	in_codigoClase VARCHAR(256)
)
BEGIN

	SELECT saber.codigo, saber.descripcion, saber.estado, saber.nivelLogro, saber.porcentajeLogro 
	FROM saber
	WHERE saber.codigo
	NOT IN
	(SELECT saber.codigo
	FROM clase_saber, saber
	WHERE clase_saber.idClase=in_codigoClase AND saber.codigo=clase_saber.codigoSaber);

END
$$