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

Console.WriteLine("\n--------- Operadores aritméticos ---------");
Console.WriteLine("Suma:        " + (a + b));   // 13
Console.WriteLine("Resta:       " + (a - b));   // 7
Console.WriteLine("Multiplicar: " + (a * b));   // 30
Console.WriteLine("Dividir:     " + (a / b));   // 3  ← división entera!
Console.WriteLine("Módulo:      " + (a % b));   // 1  ← el resto


// --- Ojo con la división entera ---
double resultado = (double) a / b;               // cast a double
Console.WriteLine("----> División real: " + resultado); // 3.333...

// --- Operadores de comparación (devuelven bool) ---
Console.WriteLine("\n------------- Comparaciones ------------------");
Console.WriteLine("¿a > b?  " + (a > b));    // True
Console.WriteLine("¿a == b? " + (a == b));   // False
Console.WriteLine("¿a != b? " + (a != b));   // True