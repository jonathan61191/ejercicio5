using System;

//Escribir un programa que convierta un valor dado en grados Fahrenheit a grados Celsius.

namespace Ejercicio6
{
    public class Program
    {
        static void Main(string[] args)
        {
            double tempF, tempc;

            Console.Write("CONVERTIDOR DE GRADOS FAHRENHEIT A CELSIUSF");
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("Ingrese la Temperatura en grados Fahrenheit: ");
            tempF = Convert.ToDouble(Console.ReadLine());

            tempc = (tempF - 32)/1.8;

            Console.Write("\n");
            Console.Write("la Temperatura en grados Celsius es: " + tempc + "°");
            Console.Write("\n");

        }
    }
}