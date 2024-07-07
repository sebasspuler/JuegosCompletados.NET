# Proyecto: Gestor de Juegos Completados

Una aplicación personal para llevar un registro de mis Juegos Completados. Desarrollada en .NET con C# y WinForms, implementando el patrón MVC y conectada a SQL Server para operaciones de Crear, Leer, Actualizar y Borrar (CRUD) de juegos.

## Características
- **Interfaz de Usuario Intuitiva**: Utiliza `DataGridView` para mostrar todos los juegos con opciones de edición y eliminación mediante la propiedad `DataGridViewLinkCell`.
- **Registrar los Juegos**: Mediante un segundo formulario conectado con el principal, permite agregar nuevos juegos completados a la base de datos.
- **Visualización de Juegos Completados**: Permite visualizar los juegos completados almacenados en la base de datos mediante un componente grilla.
- **Modificación de Juegos**: Permite modificar la información de los juegos completados existentes.
- **Eliminación de Juegos**: Permite eliminar juegos de la base de datos.
- **Búsqueda de Juegos**: El formulario principal cuenta con una barra de búsqueda para filtrar juegos por nombre, logros, notas u otros criterios.

## Restaurar la Base de Datos

### Usando el archivo .bak

1. Abre SQL Server Management Studio (SSMS).
2. Conéctate a tu servidor de SQL Server.
3. Haz clic derecho en `Databases` > `Restore Database...`.
4. Selecciona `Device` y elige el archivo `GestorJuegosCompletados.bak`.
5. Sigue las instrucciones para restaurar la base de datos.

### Usando el archivo .sql

1. Abre SQL Server Management Studio (SSMS).
2. Conéctate a tu servidor de SQL Server.
3. Abre una nueva `Query`.
4. En el menú superior, selecciona `Query -> SQLCMD Mode` para habilitar el `SQLCMD Mode`.
5. Copia y pega el contenido de `GestorJuegosCompletados.sql` en la `Query`.
6. Ejecuta el script para crear la base de datos.

## Instalación y Conexión a la Base de Datos

1. Clona el repositorio: `git clone "https://github.com/tu-usuario/tu-repositorio.git"`.
2. Ve a la carpeta "Conexión Database".
3. Haz doble clic en el archivo `conexion.udl`.
4. Ve a SQL Server y copia el nombre del servidor tal cual.
5. Selecciona la opción de seguridad integrada o usa un nombre de usuario si así lo deseas.
6. En "Seleccione la base de datos del servidor", si los datos anteriores son correctos, aparecerá tu Base de Datos previamente creada.
7. Haz clic en "Probar conexión" y luego en "Aceptar".
8. Abre el archivo `conexion.udl` con un editor de texto y copia la línea generada similar a esta: `Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Gestor Juegos Completados;Data Source=DESKTOP-IIGG7JF`.
9. Ve al proyecto en Visual Studio, a la `CapaAccesoADatos` y reemplaza la línea con los datos copiados previamente: `private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Gestor Juegos Completados;Data Source=DESKTOP-IIGG7JF");`.
10. Una vez configurado esto y con la base de datos ya creada, podrás ejecutar la aplicación de Juegos Completados correctamente.