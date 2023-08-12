# Diseno de Base de Datos

## Correr un MYSQL en Docker para pruebas
```
docker run -d --name mysql-container \
  -e MYSQL_ROOT_PASSWORD='Guatemala2023*' \
  -e MYSQL_DATABASE=analisisII \
  -p 3306:3306 \
  mysql:latest
```

## Descargar MYSQL Workbench
https://dev.mysql.com/downloads/workbench/

## Enunciado
"Se necesita diseñar un modelo entidad-relación para una aplicación de gestión de una biblioteca universitaria. La biblioteca cuenta con una colección de libros de diversos géneros y autores. Cada libro tiene un título, un número de identificación único (ISBN), una fecha de publicación y una cantidad disponible en el inventario.

Cada autor es identificado por su nombre, tiene una nacionalidad y puede estar asociado con uno o varios libros. Un mismo libro puede tener uno o más autores. Los autores pueden ser únicos o colaborar en múltiples obras.

Los estudiantes de la universidad pueden registrarse en la biblioteca para realizar préstamos de libros. Cada estudiante tiene un número de identificación único, nombre, dirección de correo electrónico y programa académico. Un estudiante puede realizar múltiples préstamos y cada préstamo está asociado a un solo estudiante.

Cada préstamo de libro tiene una fecha de inicio y una fecha de vencimiento. La biblioteca registra la fecha de devolución de cada libro prestado. Un préstamo puede involucrar uno o varios libros, y un libro puede ser prestado en múltiples préstamos a lo largo del tiempo.

Se necesita capturar la información necesaria para administrar el inventario de libros, rastrear la relación entre autores y libros, gestionar los préstamos de libros por parte de los estudiantes y mantener los datos de los estudiantes para fines de seguimiento y contacto."


## Modelo 
![Texto alternativo](URL de la imagen)
## Scripts


