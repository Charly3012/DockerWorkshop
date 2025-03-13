#Agregar la imagen base: una imagen base de java 21, version slim que solo tiene lo necesario para ejecutar java
FROM openjdk:21-jdk-slim

#Define una variable llamada JAR_FILE, que por defecto apunta al .jar que es la aplicación base
ARG JAR_FILE=target/ToDo-0.0.1-SNAPSHOT.jar

#Copia el archivo JAR desde nuestra maquina hacia la imagen de Docker con el nombre ToDoApp.jar
COPY ${JAR_FILE} ToDoApp.jar

#Indica que la aplicación usará el puerto 8001, pero no lo mapea automáticamente. 
#Solo es informativo para herramientas como Docker Compose.
EXPOSE 8080

#Indica el comando que se ejecuta cuando se inicia el contenedor
#Es como si en nuestra maquina escribieramos el comando "java -jar .\ToDo-0.0.1-SNAPSHOT.jar"
ENTRYPOINT ["java", "-jar", "ToDoApp.jar"]

