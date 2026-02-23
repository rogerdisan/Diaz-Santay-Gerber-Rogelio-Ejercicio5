Console.WriteLine("=== Evaluacion de Prestamo ===");
Console.WriteLine("Tipo de solicitante:");
Console.WriteLine("1. Empleado fijo");
Console.WriteLine("2. Temporal");
Console.WriteLine("3. Independiente");
Console.WriteLine("4. Estudiante");
Console.Write("Seleccione: ");

int tipo = int.Parse(Console.ReadLine());

Console.Write("Ingreso mensual: ");
double ingreso = double.Parse(Console.ReadLine());

Console.Write("Antiguedad laboral (meses): ");
int antiguedad = int.Parse(Console.ReadLine());

Console.Write("Monto solicitado: ");
double monto = double.Parse(Console.ReadLine());

Console.WriteLine("Historial crediticio:");
Console.WriteLine("1. Excelente");
Console.WriteLine("2. Bueno");
Console.WriteLine("3. Regular");
Console.WriteLine("4. Malo");
Console.Write("Seleccione: ");
int historial = int.Parse(Console.ReadLine());

Console.Write("Tiene fiador (S/N): ");
char fiador = char.Parse(Console.ReadLine().ToUpper());

if (ingreso <= 0)
{
    Console.WriteLine("Ingreso no valido");
    return;
}
if (monto <= 0)
{
    Console.WriteLine("Monto no valido");
    return;
}
if (historial < 1 || historial > 4)
{
    Console.WriteLine("Historial no valido");
    return;
}

