using System;

//Dados los catetos de un triángulo rectángulo, calcular su hipotenusa.

namespace Ejercicio5
{
    public class Program
    {
        static void Main(string[] args)
         {
            //definicion de variables
            double cateto1, cateto2,cateto3, hipotenusa, hipoteresul, defProceso, catetoResul;

            //definir si el proceso es para tateto o hipotenusa
            Console.Write("¿Que lado del tringulo desea consultar?");
            Console.Write("\n");
            Console.Write("escriba 1 si desea hayar uno Cateto");
            Console.Write("\n");
            Console.Write("                 ó");
            Console.Write("\n");
            Console.Write("escriba 2 si desea hayar la hipotenusa");
            Console.Write("\n");
            Console.Write("ingresa su solicitud AQUI: ");
            defProceso = Convert.ToDouble(Console.ReadLine());


            //solicitar valores para calcular cateto
            if (defProceso == 1)
            {
                Console.Write("Ingrese la hipotenusa: ");
                hipotenusa = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el cateto del que tiene informacion: ");
                cateto3 = Convert.ToDouble(Console.ReadLine());

                //calcula cateto
                catetoResul = Math.Sqrt((Math.Pow(hipotenusa, 2)) - (Math.Pow(cateto3, 2)));
                
                Console.Write("\n");
                Console.Write("El Cateto resultante es: " + catetoResul);
                Console.Write("\n");


            }
            //solicitar valores para calcular hipotenusa
            if
                (defProceso == 2)
            {
                Console.Write("Ingrese el cateto 1: ");
                cateto1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el cateto 2: ");
                cateto2 = Convert.ToDouble(Console.ReadLine());

                hipoteresul = Math.Sqrt((Math.Pow(cateto1, 2)) + (Math.Pow(cateto2, 2)));

                Console.Write("\n");
                Console.Write("La Hipotenusa resultante es: " + hipoteresul);
                Console.Write("\n");
            }
            else if (defProceso != 1) {
                Console.Write("\n");
                Console.WriteLine("¡¡¡¡ El número ingresado NO es correcto !!!");
            }

           






        }
    }
}

