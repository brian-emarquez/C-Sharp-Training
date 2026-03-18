# Tipos de Datos en C#

Este material forma parte del curso de C# y explica los tipos de datos primarios para comenzar a programar de forma sólida.

## 1. Tipos numéricos enteros (sin decimales)
- `int`: Enteros de 32 bits, el más usado para números enteros pequeños y grandes dentro de su rango (-2 147 483 648 a 2 147 483 647).
- `long`: Enteros de 64 bits cuando necesitas un rango mayor.
- `short`/`byte`: Enteros pequeños para optimización de memoria en casos específicos.

## 2. Tipos numéricos con decimales
- `double`: Número de punto flotante de doble precisión (64 bits). Ideal en cálculos científicos y valores con fracción.
- `float`: Número de punto flotante de simple precisión (32 bits). Usar con sufijo `f` (ej. `3.14f`).
- `decimal`: Más preciso para finanzas y cálculos monetarios (128 bits), usar sufijo `m` (ej. `99.99m`).

## 3. Texto y caracteres
- `string`: Cadena de texto, puede contener varias letras, palabras o frases. (Ej. `"Hola Mundo"`).
- `char`: Un solo carácter Unicode. (Ej. `'A'`, `'5'`, `'$'`).

## 4. Booleanos
- `bool`: Valores lógicos de `true` o `false`.

## 5. Ejemplos de uso
```csharp
int edad = 20;
double altura = 1.75;
string nombre = "María";
char inicial = 'M';
bool esEstudiante = true;

Console.WriteLine($"{nombre}, {edad} años, {altura}m, inicial {inicial}, estudiante: {esEstudiante}");
```

## 6. Buenas prácticas
- Usa nombres descriptivos para variables (`numeroClientes`, `precioUnitario`).
- Selecciona el tipo justo según el rango y la precisión requeridos.
- Evita conversiones innecesarias entre tipos.

## 7. Recursos adicionales
- Documentación oficial de Microsoft: https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types
- Ejercicios de laboratorio: crear variables con cada tipo y mostrarlas en consola.
 