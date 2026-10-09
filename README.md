# Ejercicios Practicos (ASP.NET Core Razor Pages)

Aplicación web con ejercicios de algoritmos resueltos como formularios: se ingresan datos, se calcula y se muestra el resultado. No usa base de datos.

## Requisitos

| Herramienta | Para qué | Dónde conseguirla |
|---|---|---|
| **.NET SDK 10** | Compilar y ejecutar | https://dotnet.microsoft.com/download |
| **Git** | Clonar el repositorio | https://git-scm.com/downloads |
| Un navegador | Ver la aplicación | Cualquiera |

El proyecto apunta a `net10.0`, así que **necesita el SDK 10**. Con una versión anterior no compila.

Para comprobar que está instalado:

```bash
dotnet --version
```

Debe mostrar un número que empiece con `10.`

### Instalación del SDK

- **Windows:** descarga el instalador desde la página de arriba, o usa `winget install Microsoft.DotNet.SDK.10`.
- **Arch / CachyOS:** `sudo pacman -S dotnet-sdk aspnet-runtime aspnet-targeting-pack` (sin el último paquete aparece el error `NETSDK1226`).
- **Otras distribuciones y macOS:** sigue las instrucciones de la página de descarga.

## Cómo ejecutarlo

```bash
git clone https://github.com/cgarces462-commits/Clase-de-C-.git
cd Feature/Primera-Prueba_C#
dotnet watch
```

`dotnet watch` restaura los paquetes, compila, levanta el servidor y abre el navegador en el menú de ejercicios. Si el navegador no se abre solo, copia la dirección que aparece en la terminal (una línea que dice `Now listening on: http://localhost:XXXX`) y pégala en el navegador.

Alternativa sin recarga automática: `dotnet run`.

Para detener el servidor, presiona `Ctrl + C` en la terminal.

## Abrirlo en un editor

- **Visual Studio Code:** abre la carpeta del proyecto e instala la extensión *C# Dev Kit* si te la sugiere.
- **Visual Studio:** necesitas una versión que soporte .NET 10 (Visual Studio 2026). Visual Studio 2022 no lo reconoce. Abre el archivo `CalculadoraWeb.csproj` y ejecuta con F5.

## Estructura

```
Pages/
├── Index.cshtml        Menú con enlaces a todos los ejercicios
├── Calculadora.cshtml  Suma de dos números
├── Ejercicio3/         Cada carpeta es un ejercicio
├── Ejercicio4/         (un .cshtml con el formulario
├── ...                  y un .cshtml.cs con la lógica en C#)
└── Ejercicio20/
Program.cs              Arranque de la aplicación
Properties/launchSettings.json   Puerto y apertura automática del navegador
```

## Problemas frecuentes

| Problema | Solución |
|---|---|
| `dotnet: command not found` | El SDK no está instalado o la terminal debe reiniciarse. |
| `NETSDK1226` (Linux) | Instala `aspnet-targeting-pack` (ver arriba). |
| Error de que no soporta `net10.0` | Instala el SDK 10 o usa un editor compatible. |
| El puerto ya está en uso | Cierra la otra ejecución, o cambia el puerto en `Properties/launchSettings.json`. |