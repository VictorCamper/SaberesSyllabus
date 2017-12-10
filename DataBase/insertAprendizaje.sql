INSERT INTO syllabus.categoria (categoria) VALUES ('AL');
INSERT INTO syllabus.categoria (categoria) VALUES ('AR');
INSERT INTO syllabus.categoria (categoria) VALUES ('CN');

INSERT INTO syllabus.subcategoria (subcategoria, ref_categoria, codigo) VALUES ('Análisis Básico de Algoritmos', 'AL', 1);
INSERT INTO syllabus.subcategoria (subcategoria, ref_categoria, codigo) VALUES ('Estrategias de Diseño de Algoritmos', 'AL', 2);
INSERT INTO syllabus.subcategoria (subcategoria, ref_categoria, codigo) VALUES ('Estructuras de Datos y Algoritmos Fundamentales', 'AL', 3);
INSERT INTO syllabus.subcategoria (subcategoria, ref_categoria, codigo) VALUES ('Computabilidad y Complejidad de Autómatas Básicos', 'AL', 4);
INSERT INTO syllabus.subcategoria (subcategoria, ref_categoria, codigo) VALUES ('Lógica Digital y Sistemas Digitales', 'AR', 1);
INSERT INTO syllabus.subcategoria (subcategoria, ref_categoria, codigo) VALUES ('Representación de datos a nivel de máquina', 'AR', 2);
INSERT INTO syllabus.subcategoria (subcategoria, ref_categoria, codigo) VALUES ('Organización de máquinas a nivel de ensamblador', 'AR', 3);
INSERT INTO syllabus.subcategoria (subcategoria, ref_categoria, codigo) VALUES ('Arquitectura y Organización de Sistemas de Memoria', 'AR', 4);
INSERT INTO syllabus.subcategoria (subcategoria, ref_categoria, codigo) VALUES ('Interfaces y Comunicación', 'CN', 1);
INSERT INTO syllabus.subcategoria (subcategoria, ref_categoria, codigo) VALUES ('Introducción a la modelación y simulación', 'CN', 2);


INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (1, 'Análisis Básico de Algoritmos', 'Conoce tiempo de ejecución de algoritmos', 10,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (2, 'Análisis Básico de Algoritmos', 'Realiza procedimientos básicos de análisis de algoritmos', 22,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (3, 'Estrategias de Diseño de Algoritmos', 'Aplica estrategias básicas de diseño de Algoritmos', 11,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (4, 'Estructuras de Datos y Algoritmos Fundamentales', 'Usa algoritmos fundamentales', 52,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (5, 'Estructuras de Datos y Algoritmos Fundamentales', 'Entiende Estructuras de datos fundamentales', 44,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (6, 'Computabilidad y Complejidad de Autómatas Básicos', 'Maneja autómatas básicos', 95,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (7, 'Computabilidad y Complejidad de Autómatas Básicos', 'Entiende el concepto de "complejidad" asociado a la definición de problemas', 60,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (8, 'Lógica Digital y Sistemas Digitales', 'Conoce los Fundamentos de sistemas digitales', 90,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (9, 'Lógica Digital y Sistemas Digitales', 'Conocer los conceptos básicos de Circuitos digitales', 10, 'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (10, 'Representación de datos a nivel de máquina', 'Conoce los Fundamentos del manejo de datos a nivel de máquina', 90,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (11, 'Organización de máquinas a nivel de ensamblador', 'Conoce conceptos básicos de Arquitectura de Computadores', 90,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (12, 'Organización de máquinas a nivel de ensamblador', 'Conoce el ensamblador y su relación con los lenguajes de alto nivel', 90,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (13, 'Arquitectura y Organización de Sistemas de Memoria', 'Conoce la forma en que se organizan los sistemas de memoria', 90,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (14, 'Interfaces y Comunicación', 'Se familiariza con las formas de comunicación existentes en los sistemas computacionales', 90,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (15, 'Interfaces y Comunicación', 'Conoce organizaciones de redes comunes', 100,'Habilitado');

INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (16, 'Análisis Básico de Algoritmos', 'Analiza informalmente algoritmos específicos', 10,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (17, 'Análisis Básico de Algoritmos', 'Utiliza notación formal para tiempo de ejecución', 10,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (18, 'Análisis Básico de Algoritmos', 'Utiliza ecuaciones de recurrencia', 10,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (19, 'Estrategias de Diseño de Algoritmos', 'Evalúa la aplicación de estrategias básicas en el diseño de algoritmos', 10,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (20, 'Estrategias de Diseño de Algoritmos', 'Utiliza heurísticas para la solución de problemas', 5,'Habilitado');

INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (21, 'Análisis Básico de Algoritmos', 'Realiza evaluaciones empíricas de algoritmos', 100,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (22, 'Estructuras de Datos y Algoritmos Fundamentales', 'Evalúa la aplicabilidad de algoritmos en contextos particulares', 80,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (23, 'Lógica Digital y Sistemas Digitales', 'Circuitos digitales', 10,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (24, 'Interfaces y Comunicación', 'codigoentifica las capas de comunicación necesarias para el traspaso de información a través de redes de computadores.', 10,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (25, 'Introducción a la modelación y simulación', 'Introducción a la modelación', 55,'Habilitado');
INSERT INTO syllabus.aprendizaje (codigo, ref_subcategoria, descripcion, porcentajeLogro, estado) VALUES (26, 'Introducción a la modelación y simulación', 'Introducción a la simulación', 40,'Habilitado');

