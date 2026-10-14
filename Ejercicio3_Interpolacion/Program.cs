Console.OutputEncoding = System.Text.Encoding.UTF8;

string nombre = "Laura";
int edad = 22;
double promedio = 4.35;
decimal precio = 25999.5m;
const string CURSO = "C# Fundamentos";

Console.WriteLine($"Hola, mi nombre es {nombre} y tengo {edad} años.");
Console.WriteLine($"Estoy cursando {CURSO} con un promedio de {promedio}.");
Console.WriteLine($"El año que viene tendré {edad + 1} años.");
Console.WriteLine($"Precio con formato moneda: {precio:C}");
Console.WriteLine($"Promedio con 1 decimal: {promedio:F1}");
Console.WriteLine($"Número con separador de miles: {1234567:N0}");
Console.WriteLine($"¿Es mayor de edad? {edad >= 18}");

int num1 = 15, num2 = 4;
Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
