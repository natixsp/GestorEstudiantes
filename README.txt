AlumnoManager

Este proyecto es un sistema sencillo para gestionar estudiantes. Permite
registrar alumnos, ver sus datos, calcular promedios, guardar en un CSV
y hasta enviar correos con la información.

Instalación

1.  Descarga o clona este proyecto.
2.  Abre la solución en Visual Studio.
3.  Revisa que tengas .NET Framework instalado (o el que el profe haya
    pedido).
4.  Antes de ejecutar, revisa el archivo App.config y pon tu correo y
    contraseña (o contraseña de aplicación de Gmail).

Uso

1.  Abre el programa y ve a la pestaña de Registro.
2.  Ingresa nombre, edad, género, actividades y notas.
3.  Haz clic en Registrar para guardar.
4.  Los estudiantes aparecen en la tabla (DataGridView).
5.  Puedes buscar estudiantes por nombre, ver sus datos y eliminar con
    doble clic.
6.  En la pestaña de Correo, selecciona el estudiante y escribe un
    correo de destino. Al hacer clic en Enviar, se envía la info y
    adjunto el CSV.

Posibles Errores y Soluciones

-   Error: “La cadena de entrada no tiene el formato correcto”
    -   Causa: El CSV tiene valores no numéricos en las columnas de
        notas o edad.
    -   Solución: Revisa el archivo CSV y asegúrate de que las notas y
        la edad son números válidos (usa punto . para decimales).
-   Error de credenciales al enviar correo
    -   Causa: Gmail bloquea el acceso si no usas contraseña de
        aplicación.
    -   Solución: Activa la verificación en dos pasos en tu cuenta de
        Gmail, genera una contraseña de aplicación y colócala en
        App.config.
-   DataGridView no muestra bien los datos
    -   Causa: Columnas mal configuradas o datos vacíos.
    -   Solución: Verifica que ActualizarDataGridView() se llama después
        de registrar o cargar estudiantes.
-   El programa no encuentra el CSV
    -   Causa: Carpeta Data no existe.
    -   Solución: Crea una carpeta llamada Data en la carpeta del
        proyecto y vuelve a ejecutar.



Proyecto desarrollado por Natalia Sanchez Perdomo.
