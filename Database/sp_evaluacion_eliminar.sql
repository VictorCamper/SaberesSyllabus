DELIMITER $$
DROP PROCEDURE IF EXISTS sp_evaluacion_eliminar $$
CREATE PROCEDURE sp_evaluacion_eliminar
(
    in_id VARCHAR(256)
)
BEGIN

	DELETE FROM evaluacion
	WHERE in_id = evaluacion.id;

END
$$