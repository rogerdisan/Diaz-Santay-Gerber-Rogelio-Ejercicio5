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

string resultado = "";
string motivo = "";

switch (tipo)
{
    case 1: // Empleado fijo
        if (historial == 4)
        {
            if (fiador == 'S' && monto < 5000)
            {
                resultado = "Aprobado con condiciones";
                motivo = "Con fiador y monto pequeno";
            }
            else
            {
                resultado = "Rechazado";
                motivo = "Historial malo";
            }
        }
        else if (monto > ingreso * 36)
        {
            resultado = "Rechazado";
            motivo = "Monto muy alto para su ingreso";
        }
        else if (antiguedad < 6)
        {
            resultado = "Aprobado con condiciones";
            motivo = "Poca antiguedad laboral";
        }
        else
        {
            resultado = "Aprobado";
        }
        break;

    case 2: // Temporal
        if (historial == 4)
        {
            if (fiador == 'S' && monto < 3000)
            {
                resultado = "Aprobado con condiciones";
                motivo = "Con fiador y monto pequeno";
            }
            else
            {
                resultado = "Rechazado";
                motivo = "Historial malo";
            }
        }
        else if (antiguedad < 12)
        {
            resultado = "Rechazado";
            motivo = "Poca antiguedad para empleado temporal";
        }
        else if (monto > ingreso * 24)
        {
            resultado = "Rechazado";
            motivo = "Monto muy alto";
        }
        else
        {
            resultado = "Aprobado";
        }
        break;

    case 3: // Independiente
        if (historial == 4)
        {
            resultado = "Rechazado";
            motivo = "Historial malo";
        }
        else if (historial == 3)
        {
            if (fiador == 'S')
            {
                resultado = "Aprobado con condiciones";
                motivo = "Con fiador por historial regular";
            }
            else
            {
                resultado = "Rechazado";
                motivo = "Historial regular sin fiador";
            }
        }
        else if (ingreso < 2000)
        {
            resultado = "Rechazado";
            motivo = "Independiente necesita mayor ingreso";
        }
        else if (monto > ingreso * 30)
        {
            resultado = "Rechazado";
            motivo = "Monto muy alto";
        }
        else
        {
            resultado = "Aprobado";
        }
        break;

    case 4: // Estudiante
        if (fiador == 'S')
        {
            if (historial == 4)
            {
                resultado = "Rechazado";
                motivo = "Historial malo";
            }
            else if (monto > 5000)
            {
                resultado = "Rechazado";
                motivo = "Monto muy alto para estudiante";
            }
            else if (ingreso < 500)
            {
                resultado = "Rechazado";
                motivo = "Ingreso muy bajo";
            }
            else
            {
                resultado = "Aprobado con condiciones";
                motivo = "Con fiador";
            }
        }
        else
        {
            resultado = "Rechazado";
            motivo = "Estudiante necesita fiador";
        }
        break;

    default:
        Console.WriteLine("Tipo no valido");
        return;
}

Console.WriteLine("\n=== RESULTADO ===");
Console.WriteLine("Estado: " + resultado);
if (motivo != "")
{
    Console.WriteLine("Motivo: " + motivo);
}