Console.OutputEncoding = System.Text.Encoding.UTF8;

const double IVA = 0.19;

double precioUnitario = 45000;
int cantidad = 3;
double descuentoPorcentaje = 10;

double subtotal = precioUnitario * cantidad;
double descuento = subtotal * descuentoPorcentaje / 100;
double subtotalConDescuento = subtotal - descuento;
double valorIva = subtotalConDescuento * IVA;
double total = subtotalConDescuento + valorIva;

int totalPersonas = 4;
double porPersona = total / totalPersonas;

Console.WriteLine("===== FACTURA =====");
Console.WriteLine($"Subtotal: {subtotal:C}");
Console.WriteLine($"Descuento ({descuentoPorcentaje}%): -{descuento:C}");
Console.WriteLine($"Subtotal con descuento: {subtotalConDescuento:C}");
Console.WriteLine($"IVA (19%): {valorIva:C}");
Console.WriteLine($"TOTAL: {total:C}");
Console.WriteLine($"Dividido entre {totalPersonas} personas: {porPersona:C}");

int contador = 100;
contador += 50;
contador -= 20;
contador *= 2;
contador %= 7;
Console.WriteLine($"Resultado de operaciones de asignación: {contador}");
