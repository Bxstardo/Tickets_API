# Ticket API

## Creación de base de datos

Ir a SQL Server y ejecutar el siguiente script para la creación de base de datos 

```bash
create database pruebaTicket;

use pruebaTicket;

create table ticket
(
idTicket int primary key identity(1,1),
creationDate datetime,
updateDate datetime,
username varchar(50),
status varchar(15)
)
```

## Cadena de conexión

Cambiar el valor de "Data Source" en la cadena de conexion en el archivo appsetting.json
"Data Source=ServerName".

```python
"ConnectionStrings": {
    "TicketApiContext": "Data Source=localhost\\SQLEXPRESS;Initial Catalog=pruebaTicket;Integrated Security=True"
}
```

En caso de que utilize SQL Server con credenciales utilize la siguiente cadena de conexion reemplazando los valores del "User ID" y "Password" segun sus credenciales

```python
"ConnectionStrings": {
    "TicketApiContext": "Data Source=192.168.10.122\SQLEXPRESS;Initial Catalog=pruebaTicket;User ID=sa;Password=***********"
}
```

## Consumir API - POSTMAN
Coloque la siguiente url en postman reemplazando la palabra "PORT" por el puerto en el que se ejecute la aplicación

```python
//GET - Consultar todos los tickets
"https://localhost:PORT/api/Tickets"

//GET - Filtrar ticket especifico
"https://localhost:PORT/api/Tickets/1"

//POST - Agregar ticket
"https://localhost:PORT/api/Tickets"

BODY
{
     "username": "brayandev",
     "status": "Abierto"
}

//PUT - Actualizar ticket
"https://localhost:PORT/api/Tickets/1"

BODY
{
     "username": "colombiadev",
     "status": "Cerrado"
}

//DELETE - Eliminar ticket
"https://localhost:PORT/api/Tickets/1"
```

## Consumir API - AJAX INTERFACE
Al ejecutar la aplicación se abre una interface con la cual podra interactuar con el api por medio de peticiones AJAX 
