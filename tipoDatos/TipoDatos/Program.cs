// ===============================================
//  TEMA 1: Variables, tipos de datos y operadores
// ===============================================


string nombre = "Brian";
int edad = 30;
double altura = 1.75;
bool estudia = true;


Console.WriteLine("el nombes es: " + nombre);
Console.WriteLine("el nombes es: " + edad);
Console.WriteLine("el nombes es: " + nombre);
Console.WriteLine("el nombes es: " + estudia);

// --- Operadores aritméticos ---

int a = 10;
int b = 3;

Console.WriteLine("\n--------- Operadores aritméticos 0 ---------");
Console.WriteLine("Suma:        " + (a + b));   // 13
Console.WriteLine("Resta:       " + (a - b));   // 7
Console.WriteLine("Multiplicar: " + (a * b));   // 30
Console.WriteLine("Dividir:     " + (a / b));   // 3  ← división entera!
Console.WriteLine("Módulo:      " + (a % b));   // 1  ← el resto


// --- Ojo con la división entera ---
double resultado = (double) a / b;               // cast a double
Console.WriteLine("----> División real: " + resultado); // 3.333...

// --- Operadores de comparación (devuelven bool) ---
Console.WriteLine("\n------------- Comparaciones 1 ------------------");
Console.WriteLine("¿a > b?  " + (a > b));    // True
Console.WriteLine("¿a == b? " + (a == b));   // False
Console.WriteLine("¿a != b? " + (a != b));   // True


// --- Interpolación de strings (forma moderna) ---
Console.WriteLine("\n---_____________Interpolación ----------------");
Console.WriteLine($"{nombre} tiene {edad} años y mide {altura} m.");

// --- var: el compilador infiere el tipo ---
var ciudad = "Arequipa";   // C# sabe que es string
var año = 2026;         // C# sabe que es int
Console.WriteLine($"Ciudad: {ciudad}, Año: {año}");