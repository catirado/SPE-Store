SPE Store
===================

Trabajo para la asignatura *Sistemas de Persistencia Especializados* consistente en una pequeña aplicación web (no completa) en la que se utilizan 2 ORM's distintos para conseguir la misma funcionalidad

 - NHibernate (http://nhibernate.info/)
 - NPoco (https://github.com/schotime/NPoco)

La aplicación consiste en un simple carrito de la compra al que añadiremos los distintos productos del catálogo.

![Home](https://cloud.githubusercontent.com/assets/354151/11168494/dffddffc-8b91-11e5-9874-86367eaadb47.PNG)


Instalación
-------------
Antes de ejecutar la solución crear la base de datos utilizando el script ``SPEStore.sql`` incluido en el repositorio.

En el ``web.config`` configurar la ruta de la base de datos en las ``connectionStrings`` y luego añadir el nombre de la connection string que utilicemos dentro de la configuración para el ORM. 

```xml
<add key="ORM" value="NHibernate" />
<add key="ORM:Connection" value="DefaultConnection" />
```

El valor ORM puede ser **NHhibernate** o **NPoco** dependiendo del sistema de persistencia que deseemos utilizar.
