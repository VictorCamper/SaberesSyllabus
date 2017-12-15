DELIMITER $$
DROP PROCEDURE IF EXISTS leer_listaSaberesUnidad $$
CREATE PROCEDURE leer_listaSaberesUnidad(
	in_tituloUnidad VARCHAR(256)
)
BEGIN
	SELECT saber.descripcion,
		   saber.nivelLogro,
		   saber.estado,
		   saber.porcentajeLogro

	FROM unidad INNER JOIN unidad_saber ON unidad.id = unidad_saber.idUnidad
			    INNER JOIN saber ON unidad_saber.codigoSaber = saber.codigo

	WHERE unidad.titulo = in_tituloUnidad ;
END
$$




