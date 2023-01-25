// See https://aka.ms/new-console-template for more information

int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


var numerofiltrados = numeros.Where(n=> n > 4);   

foreach (int numero in numerofiltrados)
{
    Console.WriteLine(numero);
}

Console.ReadKey();  
