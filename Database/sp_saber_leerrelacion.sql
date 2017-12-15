DELIMITER $$
DROP PROCEDURE IF EXISTS sp_saber_leerrelacion $$
CREATE PROCEDURE sp_saber_leerrelacion
(
	in_codigoClase VARCHAR(256)
)
BEGIN

	SELECT saber.codigo, saber.descripcion, saber.estado, saber.nivelLogro, saber.porcentajeLogro 
	FROM clase_saber, saber
	WHERE clase_saber.idClase=in_codigoClase AND saber.codigo=clase_saber.codigoSaber;

END
$$