Console.OutputEncoding = System.Text.Encoding.UTF8;

const string INSTITUCION = "SENA";

string nombreCompleto = "Carlos Andrés Gómez";
int edad = 20;
char genero = 'M';
double estatura = 1.78;
float promedio = 4.2f;
decimal valorMatricula = 350000m;
bool matriculado = true;
long documento = 1023456789L;
byte semestre = 3;

Console.WriteLine($"===== FICHA DEL APRENDIZ - {INSTITUCION} =====");
Console.WriteLine($"Nombre: {nombreCompleto}");
Console.WriteLine($"Documento: {documento}");
Console.WriteLine($"Edad: {edad} años");
Console.WriteLine($"Género: {genero}");
Console.WriteLine($"Estatura: {estatura} m");
Console.WriteLine($"Promedio: {promedio}");
Console.WriteLine($"Semestre: {semestre}");
Console.WriteLine($"Valor matrícula: {valorMatricula:C}");
Console.WriteLine($"¿Matriculado?: {matriculado}");
