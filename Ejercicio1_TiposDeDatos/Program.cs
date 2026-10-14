// Ejercicio 1: Declaración e impresión de variables con distintos tipos de datos
Console.OutputEncoding = System.Text.Encoding.UTF8;

int edad = 25;
long poblacionMundial = 8000000000L;
double altura = 1.75;
float peso = 70.5f;
decimal saldoCuenta = 1500000.75m;
char inicial = 'J';
string nombre = "Juan Pérez";
bool esEstudiante = true;
byte nota = 95;

const double PI = 3.14159;

Console.WriteLine("=== TIPOS DE DATOS ===");
Console.WriteLine("Nombre (string): " + nombre);
Console.WriteLine("Inicial (char): " + inicial);
Console.WriteLine("Edad (int): " + edad);
Console.WriteLine("Población mundial (long): " + poblacionMundial);
Console.WriteLine("Altura (double): " + altura);
Console.WriteLine("Peso (float): " + peso);
Console.WriteLine("Saldo (decimal): " + saldoCuenta);
Console.WriteLine("Es estudiante (bool): " + esEstudiante);
Console.WriteLine("Nota (byte): " + nota);
Console.WriteLine("Constante PI (const double): " + PI);
