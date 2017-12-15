INSERT INTO syllabus.categoria (categoria) VALUES ('AL');
INSERT INTO syllabus.categoria (categoria) VALUES ('AR');
INSERT INTO syllabus.categoria (categoria) VALUES ('CN');



INSERT INTO syllabus.subcategoria (id, subcategoria, ref_categoria, codigo) VALUES (1, 'Análisis Básico de Algoritmos', 'AL', 1);
INSERT INTO syllabus.subcategoria (id, subcategoria, ref_categoria, codigo) VALUES (2, 'Estrategias de Diseño de Algoritmos', 'AL', 2);
INSERT INTO syllabus.subcategoria (id, subcategoria, ref_categoria, codigo) VALUES (3, 'Estructuras de Datos y Algoritmos Fundamentales', 'AL', 3);
INSERT INTO syllabus.subcategoria (id, subcategoria, ref_categoria, codigo) VALUES (4, 'Computabilidad y Complejidad de Autómatas Básicos', 'AL', 4);
INSERT INTO syllabus.subcategoria (id, subcategoria, ref_categoria, codigo) VALUES (5, 'Lógica Digital y Sistemas Digitales', 'AR', 1);
INSERT INTO syllabus.subcategoria (id, subcategoria, ref_categoria, codigo) VALUES (6, 'Representación de datos a nivel de máquina', 'AR', 2);
INSERT INTO syllabus.subcategoria (id, subcategoria, ref_categoria, codigo) VALUES (7, 'Organización de máquinas a nivel de ensamblador', 'AR', 3);
INSERT INTO syllabus.subcategoria (id, subcategoria, ref_categoria, codigo) VALUES (8, 'Arquitectura y Organización de Sistemas de Memoria', 'AR', 4);
INSERT INTO syllabus.subcategoria (id, subcategoria, ref_categoria, codigo) VALUES (9, 'Interfaces y Comunicación', 'CN', 1);
INSERT INTO syllabus.subcategoria (id, subcategoria, ref_categoria, codigo) VALUES (10, 'Introducción a la modelación y simulación', 'CN', 2);



INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (1, 1, 'Conoce tiempo de ejecución de algoritmos', 10,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (2, 1, 'Realiza procedimientos básicos de análisis de algoritmos', 22,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (3, 2, 'Aplica estrategias básicas de diseño de Algoritmos', 11,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (4, 3, 'Usa algoritmos fundamentales', 52,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (5, 3, 'Entiende Estructuras de datos fundamentales', 44,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (6, 4, 'Maneja autómatas básicos', 95,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (7, 4, 'Entiende el concepto de "complejidad" asociado a la definición de problemas', 60,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (8, 5, 'Conoce los Fundamentos de sistemas digitales', 90,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (9, 5, 'Conocer los conceptos básicos de Circuitos digitales', 10, 'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (10, 6, 'Conoce los Fundamentos del manejo de datos a nivel de máquina', 90,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (11, 7, 'Conoce conceptos básicos de Arquitectura de Computadores', 90,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (12, 7, 'Conoce el ensamblador y su relación con los lenguajes de alto nivel', 90,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (13, 8, 'Conoce la forma en que se organizan los sistemas de memoria', 90,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (14, 9, 'Se familiariza con las formas de comunicación existentes en los sistemas computacionales', 90,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (15, 9, 'Conoce organizaciones de redes comunes', 100,'Habilitado');

INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (16, 1, 'Analiza informalmente algoritmos específicos', 10,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (17, 1, 'Utiliza notación formal para tiempo de ejecución', 10,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (18, 1, 'Utiliza ecuaciones de recurrencia', 10,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (19, 2, 'Evalúa la aplicación de estrategias básicas en el diseño de algoritmos', 10,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (20, 2, 'Utiliza heurísticas para la solución de problemas', 5,'Habilitado');

INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (21, 1, 'Realiza evaluaciones empíricas de algoritmos', 100,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (22, 3, 'Evalúa la aplicabilidad de algoritmos en contextos particulares', 80,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (23, 5, 'Circuitos digitales', 10,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (24, 9, 'codigoentifica las capas de comunicación necesarias para el traspaso de información a través de redes de computadores.', 10,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (25, 10, 'Introducción a la modelación', 55,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (26, 10, 'Introducción a la simulación', 40,'Habilitado');

