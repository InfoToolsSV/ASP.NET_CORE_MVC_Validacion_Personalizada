
# Validación Personalizada en ASP.NET Core MVC

Este proyecto demuestra cómo implementar validaciones personalizadas en una aplicación web utilizando ASP.NET Core MVC. Se incluye un formulario de registro de usuario que valida tanto el correo electrónico como la contraseña, asegurando que los datos ingresados sean válidos antes de procesarlos.

## Características

- **Validación del correo electrónico**: Verifica si el correo ya está registrado utilizando una validación remota en el servidor.
- **Validación de contraseñas**: Asegura que las contraseñas cumplan con requisitos específicos (longitud mínima, caracteres especiales, etc.).
- **Mensajes de error personalizados**: Los mensajes de validación se muestran tanto en el cliente como en el servidor.

## Tecnologías Utilizadas

- ASP.NET Core MVC
- Razor Pages
- C#

## Estructura del Proyecto

- **Models/Usuario.cs**: Modelo con atributos de validación personalizados.
- **Controllers/UsuariosController.cs**: Controlador que maneja la lógica de validación y el registro del usuario.
- **Views/Usuarios/Registrar.cshtml**: Vista que contiene el formulario de registro y los mensajes de error.

## Cómo Ejecutar el Proyecto

1. Clona este repositorio:
    ```bash
    git clone https://github.com/InfoToolsSV/ASP.NET_CORE_MVC_Validacion_Personalizada.git
    ```
2. Abre el proyecto en Visual Studio o VSCode.
3. Ejecuta el comando para restaurar paquetes:
    ```bash
    dotnet restore
    ```
4. Ejecuta la aplicación:
    ```bash
    dotnet run
    ```
5. Abre tu navegador en `https://localhost:5001/Usuarios/Registrar` para probar la aplicación.

## Licencia

Este proyecto está bajo la licencia MIT. Consulta el archivo LICENSE para más detalles.

## Agradecimientos

- Miembros del canal InfoToolsSV
- Comunidad de InfoToolsSV
