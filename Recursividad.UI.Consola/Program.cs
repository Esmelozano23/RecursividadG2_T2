using Recursividad.Logica;

Console.WriteLine("Métodos recursivos");
Console.WriteLine("\n\nCalcular factorial de 5");

Recursividades oRecusividades = new Recursividades();
int resultado = oRecusividades.CalcularFactorial(5);

Console.WriteLine("Factorial de 5: " + resultado);