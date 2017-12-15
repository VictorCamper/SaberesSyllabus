DELIMITER $$
DROP PROCEDURE IF EXISTS sp_evaluacionsaber_crear $$
CREATE PROCEDURE sp_evaluacionsaber_crear
(
    in_idevaluacion VARCHAR(256),
    in_idsaber VARCHAR(256)
)
BEGIN

	INSERT INTO evaluacionsaber(idEvaluacion, codigoSaber)
	VALUES (in_idevaluacion ,in_idsaber);

	SET out_codigo = LAST_INSERT_ID();
END
$$