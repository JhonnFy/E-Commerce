# E-Commerce

Aplicación desarrollada en .NET 9 MVC 

---

## Tabla de Contenidos

1. [Interfaces](#Interfaces)  
2. [BaseDeDatos](#BaseDeDatos)
3. [ComoFueCreado](#ComoFueCreado)
---

## Interfaces

Hola Desde Interface

---

## BaseDeDatos
<p align="center">
 <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/ecaa2d2b-f05d-4ceb-84b1-8fa0e6048ed7" />
  <br>
  <em>Diagrama Db</em>
</p>

---


## ComoFueCreado
🛠️ **PASO1:** Configuración Inicial Del proyecto
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/e33ff26d-398e-4073-982f-351c60e40906" />
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/db95ba8c-631c-4702-9282-562346b7298f" />
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/f23f7616-bd52-4370-ac77-f45a57c3e6fd" />
<img width="1360" height="768" alt="image" src="https://github.com/user-attachments/assets/ace3fce3-642f-46dc-a96c-f804f8e3c362" />

🛠️ **PASO2:** Crear Entidades
<p align="center">
  <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/0e182a59-a801-466b-a7e6-9aa3e457cc42" />
  <br>
  <em>Category</em>
</p>

<p align="center">
  <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/f8f11943-ccb7-46aa-923c-a2b19cba0a8e" />
  <br>
  <em>Order</em>
</p>

<p align="center">
  <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/14a3906f-6a1f-4755-933c-f8b86be39fc1" />
  <br>
  <em>OrderItem</em>
</p>

<p align="center">
  <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/db2e508b-2924-4ca4-b6c3-f9acc36556bd" />
  <br>
  <em>Product</em>
</p>

<p align="center">
  <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/226e4c56-a404-475a-86b7-0b157c9947ef" />
  <br>
  <em>User</em>
</p>

🛠️ **PASO3:** Instalar FrameworkCore.SqlServer
<p align="center">
  <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/7ca706c7-e025-4c95-8799-fb367214f28f" />
  <br>
  <em>Dependencies</em>
</p>

<p align="center">
  <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/cc78dead-57e8-40d8-a8a3-6ab4434657cf" />
  <br>
  <em>Paquete1: Microsoft.EntityFrameworkCore.SqlServer</em>
</p>

<p align="center">
  <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/851f5a97-2c93-4a0e-b9c1-e75a2b564c4f" />
  <br>
  <em>Paquete2: Microsoft.EntityFrameworkCore.Tools</em>
</p>

<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/b3d1d3ef-eb26-4485-ab44-1d5cd56c3d47" />
  <br>
  <em>Paquetes Instalados Vrs 9.0.7</em>
</p>

🛠️ **PASO4:** AppDbContext
<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/77485e96-2b83-455f-80b1-04c0a4443769" />
  <br>
  <em>Context</em>
</p>

<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/ccafe6f6-3619-47cc-b390-721a5aa6e4bd" />
  <br>
  <em>AppDbContext</em>
</p>

<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/44c14eef-7266-4129-a2e0-8164559209dd" />
  <br>
  <em>Estructura De Las Tablas</em>
</p>


🛠️ **PASO5:** Modelado De Tablas
<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/a8f4159b-7a59-4894-9769-64999f40911a" />
  <br>
  <em>Category</em>
</p>

<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/b31f3b31-8e90-44b9-83fe-67c489112701" />
  <br>
  <em>Product</em>
</p>

<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/30deae6b-ed92-4ae8-95c4-f7b8b0363088" />
  <br>
  <em>User</em>
</p>

<p align="center">
  <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/2a641a8b-27de-4a79-9f88-da7c4ea16882" />
  <br>
  <em>Order</em>
</p>

<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/43b428ad-242f-4964-bff0-a88c74cc5478" />
  <br>
  <em>OrderItem</em>
</p>

🛠️ **PASO6:** Crear Cadena De Conexión
<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/489d35d6-5010-4063-9c9c-910d9e3d5e4b" />
  <br>
  <em>Crear Variables De Entorno</em>
</p>

<p align="center">
  <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/6738a321-e3bc-4672-b889-69716142f79f" />
  <br>
  <em>Asignar La Conexión</em>
</p>

🛠️ **PASO7:** Crear Relación AppDbContext Cadena De Conexión
<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/621cd2f0-9533-4cd5-910c-f0c9b0f769ee" />
  <br>
  <em>Asignar Valores</em>
</p>

<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/447e0a5e-e3d3-4758-a133-b3a276f5d8b4" />
  <br>
  <em>Invocar La Cadena</em>
</p>

<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/ad6e89cc-da06-461d-9031-1cbb904c9ab6" />
  <br>
  <em>Abrir La Consola</em>
</p>

<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/85072e02-9d7d-4273-b645-2951175b7b4b" />
  <br>
  <em>Add-Migration firstMigration</em>
</p>

<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/847ab97b-22a1-49b6-9ec5-fc888da1034b" />
  <br>
  <em>Update-Database</em>
</p>

<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/6218b7b1-79b1-4e6c-bc8f-9190d608ff28" />
  <br>
  <em>Consultar En Sql</em>
</p>

<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/24f0c442-3db1-4abe-b73d-3badc9333a28" />
  <br>
  <em>Diagrama</em>
</p>

🛠️ **PASO8:** Mantenimiento De Las Categorias
<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/cd847dec-3621-40d2-92f2-52c74d9bc8e2" />
  <br>
  <em>Controlador </em>
</p>

<p align="center">
  <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/e2667ef1-5c80-4c93-af09-da8fd5543bef" />
<br>
  <em>CategoryController</em>
</p>

<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/ae64d9cb-b5c8-44f9-9eaf-a861df36c13e" />
<br>
  <em>Retornar Las Categorias</em>
</p>

<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/3a495411-b255-46f2-9bd2-875b7f53cc6a" />
<br>
  <em>Crear La Vista Index</em>
</p>

<p align="center">
  <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/85df9ece-9532-4fcc-aaa7-eff699b19666" />
<br>
  <em>Crear La Vista Categories</em>
</p>

<p align="center">
  <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/5510de44-9fe2-4dbb-809b-ef29df00cd69" />
<br>
  <em>Vincular Vista</em>
</p>

<p align="center">
  <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/b8517994-edd5-46c1-8307-a6c65cb4daa5" />
  <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/013d81d2-393f-4692-888c-08d23869397e" />
  <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/c31cc257-992c-47e3-bc82-0ed1bd6724f0" />
<br>
  <em>Compilado</em>
</p>


<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/0e77c9bd-7244-485f-b4f1-ee1f0656c148" />
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/73c07883-daaf-4683-8507-0617c32378e1" />
<br>
  <em>CategoryVM</em>
</p>

<p align="center">
  <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/63ad177d-7849-4cd3-9937-0acf2316b51e" />
<br>
  <em>Asignar View Model</em>
</p>

🛠️ **PASO9:** Repositorios & Persistencia De Datos
Los repositorios se comunican con los métodos básicos para consultar la DB; en este punto se realiza la separación de responsabilidades.

<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/8e50e4ee-2084-45d9-9878-a79baf56d145" />
<br>
  <em>Asignar Folder</em>
</p>

<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/ef56f1b4-93fb-405c-b5fe-3b5cef37c032" />
<br>
  <em>Asignar Clase</em>
</p>


<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/1ba9bd1a-f5dd-42fa-a597-b72d90e1ba53" />
<br>
  <em>Asignar Repositorio</em>
</p>

<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/ad866df5-c387-4009-a96b-1858fb5588e0" />
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/54eae0f1-dac6-45e4-a61e-866b201a41f0" />
<br>
  <em>Asignar Servicio</em>
</p>

<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/45de088a-1045-4895-abd6-b2a3c196345c" />
<br>
  <em>Modificar El Controller</em>
</p>

<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/46043e90-9df6-4aff-a823-a662912687c2" />
<br>
  <em>Modificar Programcs</em>
</p>

🛠️ **PASO 10:** Eventos
Crear Categorias Editar Eliminar
<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/614eba5d-af15-48a8-995c-8cd94986731f" />
<br>
  <em>Crear Metodos Crud</em>
</p>

<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/6a25d23d-3476-4854-87ee-13248b91535e" />
<br>
  <em>Metodo AddAsync Agregar</em>
</p>

<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/a0f39ca7-0e13-4afd-bf45-ad87c6fea64c" />
<br>
  <em>Crear HttpPost HttpGet</em>
</p>

<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/ab859ba2-d7bf-42fc-8fa3-56afc466b16f" />
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/46d39edb-c912-42fa-8a40-f43ee5ed673d" />
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/58920d44-1c23-4a7a-9d61-0971946f6e8e" />
 <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/f885b12a-1481-401a-a723-9c2dc62af4a4" />
<br>
  <em>Crear La Vista AddEdit</em>
</p>

<p align="center">
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/b11cd793-43fd-4070-87af-71dfe49703e0" />
<br>
  <em>Href A /Category/Create</em>
</p>

<p align="center">
 <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/239236cc-9184-4f42-88fe-202d88d6e18e" />
 <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/e61981d1-bb2e-43cc-b45d-dca237fc76e8" />
 <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/23a26f0c-2468-4fdb-939d-118dd7464eb2" />
 <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/836f8316-754c-4f86-b120-e68e7ec50a39" />
 <img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/4c2af353-c979-4303-97c3-65e6f4c9e433" />
<br>
  <em>Agregar Desde La Vista</em>
</p>



---
