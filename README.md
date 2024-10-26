# Juego del Ahorcado en Consola - .NET

![image](https://github.com/user-attachments/assets/f697b03b-c4a1-4900-a63f-26f2fb4ab7fa)

Este proyecto implementa el clásico juego del Ahorcado utilizando C# en una aplicación de consola. 
El jugador debe adivinar una palabra letra por letra. El programa cuenta con un contador de intentos, 
y muestra un "dibujo" del ahorcado conforme se van agotando los intentos.

## Tabla de Contenidos
- [Características](#características)
- [Instrucciones de Juego](#instrucciones-de-juego)
- [Estructura del Código](#estructura-del-código)
- [Ejemplo de Uso](#ejemplo-de-uso)
- [Requisitos](#requisitos)
- [Ejecutar el Programa](#ejecutar-el-programa)
- [Créditos](#créditos)

## Características
- Juego de consola simple, implementado en C#.
- Funcionalidad de selección aleatoria de palabras.
- Dibujo progresivo del ahorcado conforme se fallan intentos.
- Indicador de progreso de la palabra que se está adivinando.
- Mensajes de estado sobre los intentos restantes y letras ya adivinadas.

## Instrucciones de Juego
1. El programa elige una palabra al azar de una lista predefinida.
2. El jugador ingresa una letra en cada turno.
3. Si la letra está en la palabra, se revela en las posiciones correspondientes.
4. Si la letra no está en la palabra, el número de intentos restantes disminuye.
5. El jugador gana si adivina toda la palabra antes de quedarse sin intentos.
6. El jugador pierde si los intentos llegan a cero antes de adivinar toda la palabra.

## Estructura del Código
El código se organiza de la siguiente manera:
- **Main**: Contiene el bucle principal del juego y maneja la lógica de entrada/salida.
- **MostrarDibujo**: Muestra el dibujo del ahorcado según el número de intentos restantes.
- **MostrarProgreso**: Muestra el progreso de la palabra en la que se encuentran letras adivinadas y guiones bajos para letras pendientes.
- **PalabraAdivinada**: Verifica si todas las letras de la palabra han sido adivinadas.

## Ejemplo de Uso
### Ejemplo de ejecución típica
```plaintext
Introduce una letra: a
_ _ a _ _ a _ a _ _ 
Letra incorrecta. Intentos restantes: 5

Introduce una letra: p
_ p _ _ _ a _ a _ _ 
...
```

## Requisitos
- [.NET SDK](https://dotnet.microsoft.com/download) 5.0 o superior
- Editor de código (Visual Studio, Visual Studio Code, etc.)

## Ejecutar el Programa
1. Clona este repositorio o descarga los archivos.
2. Abre una terminal en el directorio del proyecto.
3. Ejecuta el siguiente comando para compilar y ejecutar la aplicación:
   ```bash
   dotnet run
   ```

## Créditos
Este juego del Ahorcado fue creado para ilustrar un ejemplo de aplicación de consola en C# .NET.

¡Disfruta jugando al Ahorcado!
