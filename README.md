# TechnicalTest
# Sistema de Información - Agentes A, B, y C

## Descripción

Este software de consola en C# implementa un sistema de información con tres agentes (A, B, y C), donde cada agente cumple con dos funcionalidades principales:

1. **Obtener Media**:
   - **Agente A**: Calcula la media aritmética.
   - **Agente B**: Calcula la media armónica.
   - **Agente C**: Encuentra la mediana.

2. **Escalera**:
   - **Agente A**: Dibuja una escalera alineada a la derecha con la base y altura igual a n.
   - **Agente B**: Dibuja una escalera invertida alineada a la derecha con la cima y altura igual a n.
   - **Agente C**: Dibuja una escalera centrada con la base y cima igual a n, y una distancia en el centro.

## Instalación

Para ejecutar esta aplicación, asegúrate de tener instalado [.NET Core SDK](https://dotnet.microsoft.com/download) en tu sistema.

1. Clona este repositorio o descarga el código fuente.
2. Navega hasta el directorio del proyecto desde tu terminal o línea de comandos.
3. Compila el proyecto usando el comando:

```bash
dotnet build
```

## Uso

```bash
dotnet run
```

**Funcionalidades**
1. Obtener Media
  - **Para Agente A (Media Aritmética):**
Ingresa una lista de números reales separados por espacios.

  - **Para Agente B (Media Armónica):**
Sigue las mismas instrucciones que para el Agente A.

  - **Para Agente C (Mediana):**
Proporciona la misma entrada que para los Agentes A y B.

2. **Escalera**
  - **Para Agente A:**
Ingresa un número entero n para dibujar la escalera alineada a la derecha.


## Ejemplos
Para ejecutar las funcionalidades, la aplicación te pedirá que selecciones el agente y luego la funcionalidad específica que deseas ejecutar. Aquí tienes un ejemplo de cómo se vería la entrada y salida para cada agente:

```bash
Bienvenido al programa de utilidades
Seleccione el agente (A, B, C):
A
Selecciona la funcionalidad:
1: Generador de escaleras
2: Cálculo de medias
3: Salir
Opción: 2
Ingrese los números separados por espacio: 1 2 3 4 5
El resultado es: 3
```
Sigue las instrucciones en pantalla para explorar las diferentes funcionalidades de cada agente.
  - **Para Agente B:**
Utiliza el mismo método de entrada que para el Agente A.

  - **Para Agente C:**
Ingresa un número entero n para dibujar la escalera centrada.
