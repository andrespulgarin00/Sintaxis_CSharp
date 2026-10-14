Console.OutputEncoding = System.Text.Encoding.UTF8;

int a = 20;
int b = 6;

Console.WriteLine("=== OPERADORES ARITMÉTICOS ===");
Console.WriteLine("Suma: " + (a + b));
Console.WriteLine("Resta: " + (a - b));
Console.WriteLine("Multiplicación: " + (a * b));
Console.WriteLine("División entera: " + (a / b));
Console.WriteLine("División decimal: " + ((double)a / b));
Console.WriteLine("Módulo: " + (a % b));

Console.WriteLine("\n=== OPERADORES DE ASIGNACIÓN ===");
int x = 10;
Console.WriteLine("x inicial: " + x);
x += 5; Console.WriteLine("x += 5  -> " + x);
x -= 3; Console.WriteLine("x -= 3  -> " + x);
x *= 2; Console.WriteLine("x *= 2  -> " + x);
x /= 4; Console.WriteLine("x /= 4  -> " + x);
x %= 4; Console.WriteLine("x %= 4  -> " + x);

Console.WriteLine("\n=== INCREMENTO / DECREMENTO ===");
int c = 5;
c++; Console.WriteLine("c++ -> " + c);
c--; Console.WriteLine("c-- -> " + c);

Console.WriteLine("\n=== CÁLCULO BÁSICO: RECTÁNGULO ===");
double largo = 8.5;
double ancho = 4.2;
double area = largo * ancho;
double perimetro = 2 * (largo + ancho);
Console.WriteLine("Área: " + area);
Console.WriteLine("Perímetro: " + perimetro);
