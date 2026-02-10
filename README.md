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

Hola Desde BaseDeDatos

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

  <br>
  <em>Update-Database</em>
</p>


<p align="center">

  <br>
  <em>Update-Database</em>
</p>
---
