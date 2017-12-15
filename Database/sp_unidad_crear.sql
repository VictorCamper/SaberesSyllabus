DELIMITER $$
DROP PROCEDURE IF EXISTS sp_unidad_crear $$
CREATE PROCEDURE sp_saber_crear
(
	in_id INTEGER
	in_titulo VARCHAR(250),
  	
)
BEGIN

	INSERT INTO unidad(id,titulo)
	VALUES (in_id, in_titulo);

END
$$
