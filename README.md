# Proyecto de ingenieria de software
- Museos de Ciencias y Artes -
## Repositorio 
:fa-github: [https://github.com/pancitoconquesito/conejo ](https://github.com/pancitoconquesito/conejo  "https://github.com/pancitoconquesito/conejo "):fa-github:

------------

------------


## GDD

[![img prototipo](https://raw.githubusercontent.com/pancitoconquesito/conejo/main/_imgs/aw1.png "img prototipo")](https://raw.githubusercontent.com/pancitoconquesito/conejo/main/_imgs/aw1.png "img prototipo")
### Concepto general
•	Género: Walking simulator 3d en tercera persona con algunos elementos de aventura y colectaton, para PC S.O Windows.
•	Público objetivo: niños y preadolescentes.
•	Objetivo principal del software: incentivar e introducir a niños y preadolescentes en las ciencias y el arte. No se busca directamente enseñar, este es el medio para motivar el interés en estas áreas.

------------
### Reseña de la narrativa
Joaquín es un niño de 12 años, una noche mientras jugaba con su telescopio se percata que su perro se escapa, inmediatamente sale por la ventana a buscarlo.
recorre un par de cuadras y entra a un bosque donde atravesando un frondoso arbusto es transportado a otra dimensión, un lugar que parece ser un museo.
después despierta en un hospital sin piernas y su perro nunca existió.

### Mecánicas principales e interacción básica
El personaje se controla en tercera persona, modificando su dirección local en función de la dirección de la cámara, podrá caminar y correr.
	Lectura simple: al acercarse a un letrero o afiche se podrá desplegar en UI su contenido. Avanzar en el texto y salir en cualquier momento, puede contener texto sonidos e imágenes.
	Observación de objetos: en determinados objetos se podrá tomar en la mano y rotar en diferentes sentidos, esta acompañado de un breve texto en UI.
	Espectáculo vitrina: conjunto de animaciones scriptiadas con narración y sonidos.
	Imaginar: cada sector contine un gran afiche en la cual se podrá acerca y ser trasladado al escenario que expone el afiche, estos “escenarios de imaginación” contienen otros controladores principales. 
### Objetivos y avance
El objetivo general es encontrar al perro y volver a la casa.
Para ello se coleccionarán monedas búho y globos, así mismo, se deberán buscar diversos objetos genéricos para ayudar a distintos personajes secundarios.
Para obtener monedas búho se deberá interactuar con los elementos, realizar pruebas, etc. Por otra parte, los globos en su mayoría se obtendrán con estas monedas.
### Controles
Se controla con joystick genérico de PC y teclado y ratón.
	Palanca izquierda: Mover en eje x y z al personaje principal
	Palanca derecha: Mover en eje x e y cámara
	Trigger L: correr
	Botón start: ingresar/salir menú
	Botón 1: aceptar interacción
	Botón 2: cancelar acción

### Arte y estética
La estética es simple, cercano a un anime genérico. Escenarios compuestos de figuras simples (paralelepípedos, esferas, etc.), poco trabajo en texturas albedo, aplicación de normales para complementar la falta de definición de albedo. Texturas de rugosidad, altura y metalicidad se ocuparán solo si es estrictamente necesario.

### Personajes
o	Joaquín: es el personaje principal y es a quien controlamos.
o	Mantequilla: perro que busca Joaquín y que ocasionalmente aparece, pero vuelve a desaparecer. En la última parte aparece para acompañar a Joaquín hasta el final del juego.
o	El vendedor de globos: un señor extraño que vende globos a cambio de monedas de búho. tiene una cabeza grande, gran pelo rojo, ropa colorida y una risa ridícula (como una oveja haciendo bungee).
o	El búho: es un guía del museo, es estricto, habla mucho, suele repetir varias veces las mismas ideas explicando las de maneras distintas.
o	La ardilla detective: es una ardilla desempleada hace 3 años, al entrar en una severa depresión, llego a la conclusión que su misión en la vida es resolver crímenes y misterios. Lleva ya dos años en esta labor, sin embargo, aún no ha resuelto ningún caso. Es amistoso y enérgico, pero tiene poca autoestima y "perseguido", lo que lleva a desanimarse rápidamente, no obstante, se reanima de inmediato.
o	La bruja en práctica: es una bruja adolescente, intenta aparentar ser rebelde, pero es evidente que solo es una niña mimada, es agonista y solo le importa la magia. A pesar de todo, es buena y solo quiere ser reconocida como una bruja poderosa.
o	El árbol tímido: es un árbol que esta perdidamente enamorado de un cartel de "no pisar césped". Al ser muy tímido no es capaz de declararse, siente que solo puede tomar valor si se declara con el regalo perfecto.
o	El ave de piernas largas: es un "fisgón profesional" le gusta observar al resto y escuchar sus conversaciones, su mayor deseo es escribir un libro donde reúna todas las historias que ha escuchado. Es extrañamente ofensivo y gentil al mismo tiempo, suele tartamudear al hablar por estar pensando en otras cosas y nunca prestar la suficiente atención. Tiene piernas muy largas que según él las obtuvo en la adolescencia por comer mucho pescado, lleva un pequeño sombrero con una pluma que le regalo su hermano al mudarse del nido de su madre.
o	Señorita Ivanova Ivanov: es un letrero que antes fue un árbol de circo, su sueño siempre ha sido tocar piano, le gusta escuchar Liszt y ver series policiacas de los 70.

### Escenarios
	Parque central de museo
	Astronomía
	Animales
	Geología
	Música y pintura
	Sistema solar (imaginación de astronomía)
	Sabana con leones (imaginación de animales)
	Cueva (imaginación de geología)
	Concierto de Claude Debussy y Claude Monet (imaginación de música y pintura)

### ítems interactivos principales
TODO
### Interfaz gráfica
Imágenes con colores planos y en 2d, deben aparecer según el contexto para mantener la pantalla lo más limpia posible.
Objetos por indicar:
	Cantidad de monedas de búho
	Cantidad de globos
	Ítems genéricos (a definir)
	Botones constantes
	Botones contextual
	Menú y sus opciones

[IMG UI]

### Sonidos y música
Sonidos suaves y brillantes, deben ser agradables y relajantes.
#### Sonidos principales:
	Al caminar (colección con selección aleatoria)
	Movimientos de animaciones idle
	Entrar al menú
	Hover y clic en opción de menú
	Salir de menú
	Entrada y salida de interacción “lectura simple”
	Entrada y salida de interacción “observación de objeto”
	Entrada y salida de interacción “espectáculo vitrina”
	Entrada y salida de interacción “imaginar”
	Volver al museo desde interacción “imaginar”
	Comenzar y terminar conversación
	Continuar conversación
	Obtener moneda búho
	Obtener globo
	Obtener ítem genérico
	Lograr ayudar a alguien
#### Música ambiental, con sonidos naturales y armonías de jazz. Instrumentación mayoritariamente de piano.
Cada sector deberá tener su propio tema principal, además de variaciones de esta para las interacciones.
### Programas principales:
	Blender v2.9 y v2.8.0
	Unity 3D v2020.3.17f1 (HDRP)
	FL Studio v20
	Spitfire Audio
	Anime Studio Prov v10.1
	Materialize v1.0
	Vroid v0.10.4
	Gimp v2.10.12
	Audacity v2.4.2
	Mixamo.com
	Polyhaven.com
	Texture.com

------------



### Reglas de orden y nombre de archivos
•	Cada prefabs debe comenzar con la primera letra en mayúscula y con un guion bajo
•	Toda colección debe agruparse en un GameObject vacío, y este debe comenzar con un guion bajo y continuar en minúscula
•	El objeto del personaje principal debe escribirse en mayúscula, al igual que el controlador de cámara, estas deben estar dentro de un mismo objeto vacío llamado ‘ALL’
•	El nombre de los materiales debe comenzar con ‘m_’ y continuar en minúscula
•	Los shader deben comenzar con ‘s_’ y continuar en minúscula
•	Todo material que ocupe un shader debe comenzar con ‘ms_’ y continuar en minúscula
•	Post process volume, sky and fog volume y directional light se deben agrupar en un objeto nombrado ‘S’
•	si es necesario separar visualmente objetos en hierarchy agregar un objeto vacío nombrado ‘-----------------------------------‘ y con tag ‘EditorOnly’


### Fases de trabajo
	Fases generales:
1.	Fase de creación de assets principales
	Creación de assets principales (personajes y escenarios)
	Controlador de personaje y cámara
	Primera etapa de integración al motor

2.	Fase de integración de UI
	Objetos interactivos
	UI
	Fin de definición de mecánicas
	Segunda etapa de integración al motor

3.	Fase jugable
	Objetos principales
	guía de progreso jugable
	Tercera etapa de integración al motor


4.	Fase menú
	Menús 
	Objetos secundarios y efectos principales
	Cinemáticas 
	Cuarta etapa de integración al motor


5.	Fase depuración
	Ajuste de efectos y preprocesados.
	Optimización.

	Fases de creación de asset:
1.	concepto artístico y definición de contexto jugable
2.	modelado 3d
3.	texturización y materiales
4.	riggeo y animaciones
5.	integración Unity (materiales y test de animaciones)


### Hoja de ruta
	4 meses Fase 1
	2 meses Fase 2
	3-4 meses Fase 3
	½ mes Fase 4
	½ mes Fase 5
### Roles
	Director general
	Director artístico
	Animador 2D y 3D
	Programador
	Diseñador de niveles
	Sonidista y compositor musical

[ASIGNACION DE ROLES]
