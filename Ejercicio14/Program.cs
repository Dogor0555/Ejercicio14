using System;

Console.Write("Ingrese un número: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine($"Tabla de multiplicar de {numero}:");

for (int i = 1; i <= 10; i++)
{
    int resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");
}
