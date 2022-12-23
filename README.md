# PersonasAPI
Crear un backend para exponer SERVICIOS REST siguiendo los siguientes lineamientos:

b.        Backend: NET Core (web api)

c.        Base de datos: a elección

Esta aplicación deberá contener una tabla de base de datos (ej Persona, que modele a una persona, 3 o 4 columnas). El backend deberá exponer un servicio REST que liste todas las personas de la base de datos.

Tratar de usar una arquitectura en capas.

A nivel back tienen que estar claras 3 capas al menos.

Aplicar inyección de dependencias.

Parte B: Crear un servicio REST para dar de alta personas. Considerar validaciones de campos obligatorios, formatos. Pensar bien donde poner las validaciones. El sistema solo debe permitir dar de alta personas mayores de 18 años.

Explicar que tipos de validaciones hay en que capas van cada tipo de validaciones

Parte C: La personas tendrán que tener un campo autocalculado que se persista en la BD, que dependiendo la fecha de nacimiento categorice a las personas como: Niños < 11, Adolescentes >=11 & < 18, Adultos >=18 & < 80, Octogenario >= 80.

Implementar test unitarios para esta logica.

PENSAR bien donde ubicar esta lógica y en donde iría esta responsabilidad.

Tratar de identificar/aplicar 2 o 3 patrones de diseño en el backend.
    
    ---
    

1. ¿Qué es un ORM? Ventajas y desventajas.
    
    Una ORM, o sistema de mapeo objeto-relacional, es una herramienta que ayuda a los desarrolladores de software a gestionar la interacción entre una base de datos y un lenguaje de programación orientado a objetos. Una ORM permite a los desarrolladores trabajar con datos en formato de objetos en lugar de tener que escribir código SQL explícito para cada operación de base de datos.
    
    Las ventajas de usar una ORM incluyen una mayor productividad del desarrollador ya que el código es más fácil de escribir y mantener, una mejor integración entre la aplicación y la base de datos, y una mayor portabilidad ya que el código de la ORM puede ser utilizado con diferentes bases de datos sin necesidad de cambios significativos.
    
    Algunas desventajas de usar una ORM incluyen una mayor complejidad en el código ya que se debe trabajar con dos lenguajes (el lenguaje de programación y SQL), un rendimiento potencialmente inferior debido a que las consultas generadas por la ORM pueden no ser tan eficientes como las escritas manualmente, y una mayor dificultad para depurar el código debido a que puede ser difícil rastrear errores que ocurren en la capa de la ORM.
    
2. Diferencias entre: cliente de BD vs driver de conexión de BD vs motor de base de datos (Dar ejemplos)

    Un cliente de base de datos es un programa que se utiliza para interactuar con una base de datos. Por ejemplo, un cliente de base de datos puede permitir realizar consultas a la base de datos, modificar datos en la base de datos o incluso crear nuevas tablas y bases de datos.
    Algunos ejemplos comunes de clientes de base de datos incluyen MySQL Workbench, PHPMyAdmin y Microsoft Access. Estos programas permiten interactuar con la base de datos de diferentes maneras, dependiendo de las necesidades de la aplicación. Por ejemplo, MySQL Workbench es una herramienta que permite realizar casi cualquier tarea relacionada con la base de datos, mientras que PHPMyAdmin es más bien una herramienta web interactua con la base de datos a través de un navegador web.
    
    Un driver de conexión de base de datos es un software que se utiliza para establecer una conexión entre el cliente de base de datos y la base de datos en sí. El driver actúa como un intermediario entre el cliente y la base de datos, permitiendo que el cliente envíe consultas a la base de datos y reciba respuestas de vuelta.
    Algunos ejemplos comunes de drivers de conexión de base de datos incluyen el controlador JDBC para MySQL y el controlador ODBC para Microsoft SQL Server. Estos controladores permiten establecer una conexión entre la aplicación y la base de datos, de manera de poder enviar consultas y recibir resultados. Por ejemplo, al desarrollar una aplicación Java que se conecte a una base de datos MySQL, se podria utilizar el controlador JDBC para establecer la conexión y realizar las consultas necesarias.
    
    Un motor de base de datos es el software que se encarga de almacenar y gestionar los datos en una base de datos. El motor de base de datos se encarga de ejecutar las consultas enviadas por el cliente de base de datos, y devolver los resultados de estas consultas al cliente a través del driver de conexión.
    Algunos ejemplos comunes de motores de base de datos incluyen MySQL Server, Microsoft SQL Server y Oracle Database. Estos motores se encargan de almacenar y gestionar los datos en la base de datos, y de ejecutar las consultas enviadas por el cliente. Por ejemplo, al utilizar MySQL Workbench como cliente de base de datos, es posible conectarse a una instancia de MySQL Server para realizar consultas y modificar los datos en la base de datos.
    
    En resumen, el motor de base de datos es la parte "interna" de una base de datos, mientras que el cliente y el driver son las partes "externas" que se utilizan para interactuar con la base de datos.
    
3. ¿Qué es una API REST?
    
    API REST, o interfaz de programación de aplicaciones (Application Programming Interface, API) representacional de estado de transferencia (REpresentational State Transfer), es un estilo de arquitectura de software para sistemas distribuidos, como por ejemplo la web. Las APIs REST ofrecen una manera estandarizada de acceder a datos en un servidor y realizar operaciones en él mediante un conjunto bien definido de operaciones, llamadas métodos, que utilizan diferentes verbos HTTP, como GET, POST, PUT y DELETE.
    Una de las principales ventajas de las APIs REST es que permiten a las aplicaciones interactuar de manera simple y consistente con diferentes sistemas y servicios, lo que facilita la integración y la interoperabilidad entre diferentes componentes de un sistema. Además, las APIs REST también son escalables, lo que permite a las aplicaciones manejar un gran número de usuarios y solicitudes de manera eficiente.
