DELIMITER $$
DROP PROCEDURE IF EXISTS leer_listaClaseUnidad$$
CREATE PROCEDURE leer_listaClaseUnidad(
	in_tituloUnidad VARCHAR(256)
)
BEGIN
SELECT clase.fecha,
	   clase.tema,
	   clase.descripcion,
	   clase.tipoClase

FROM unidad INNER JOIN unidad_clase ON unidad.id = unidad_clase.idUnidad
		    INNER JOIN clase ON unidad_clase.idClase = clase.id

WHERE unidad.titulo = in_tituloUnidad;

END
$$


