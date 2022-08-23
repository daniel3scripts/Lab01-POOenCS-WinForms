using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_01
{
    internal class Program
    {
        static int Suma (int a, int b) 
        { return a + b; }

        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                
                Console.WriteLine("La rais cuadarada de {0} es {1}:", i,Math.Sqrt(i));
            }
        }
        static void Conversion_Temp01()
        {
            
            double celsius = double.Parse(Console.ReadLine());

            double kelvin = celsius + 273;
            double fareinheit = (celsius * 9 + (32 * 5)) / 5;

            Console.WriteLine("Calculando la conversion...:-)");
            Console.WriteLine($"Grados Kelvin : {kelvin}");
            Console.WriteLine($"Grados Fareinheit : {fareinheit}");
        }
        static void Conversion_Temp02()
        {
            double fareinheit = double.Parse(Console.ReadLine());

            
            double celsius = ((fareinheit-32)*5)/ 9;
            double kelvin = celsius + 273;

            Console.WriteLine("Calculando la conversion...:-)");
            Console.WriteLine($"Grados Kelvin : {kelvin}");
            Console.WriteLine($"Grados Celsius : {celsius}");
        }
        static void Main(string[] args)

            {
                Console.Title = "Procedimientos y funciones";
                string opcion;
            do

            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[7] Imprimir las Conversiones de temperatura");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el 1er  numero");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el 2do numero");

                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;

                    case "2":

                        Console.WriteLine("Calculando la operacion...:-)");
                        Raiz();
                        Console.ReadKey();
                        break;

                    case "7":
                        Console.WriteLine("Conversion de grados Celsius a kelvin y farenheit");
                        Console.WriteLine("Ingrese un numero para una temperatura celsius");
                        Conversion_Temp01();
                        Console.WriteLine("-------------**********************--------------");
                        Console.WriteLine("Conversion de  grados Farenheit a kelvin y celsius");
                        Console.WriteLine("Ingrese un numero para una temperatura Farenheit");
                        Conversion_Temp02();

                        Console.ReadKey();
                        break;
                }

            } while (!opcion.Equals("0"));
            }
    }
}
