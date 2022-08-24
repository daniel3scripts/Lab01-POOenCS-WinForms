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

        static int Resta(int x, int y)
        {

            return x - y;
        }

        static double Multiplicacion(double m, double n)
        {
            return m * n;
        }

        static double Division(double c, double d)
        {
            //else if (c == 0 && d == 0)    
            //{
            //    Console.WriteLine("Error..No esta existe!!!");
            //    return double.Parse(Console.ReadLine());
            //}
            
         return c / d;
        }

        static void num_primos()
        {
            int n = 2, div = 0;
            while ( n <= 30)
            {
                for (int x = 1; x <= n; x++)
                {
                    if (n % x == 0)
                    {
                        div++;
                    }
                    if (div > 2) { break; }

                }
                if (div == 2)
                {
                    Console.WriteLine("{0}",n);
                }
                div = 0;
                n ++;
            }
            
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
                Console.WriteLine("[3] Resta de dos números");
                Console.WriteLine("[4] Multiplicacion de dos números");
                Console.WriteLine("[5] Division de dos números");
                Console.WriteLine("[6] Imprimir los 10 primeros números primos");
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

                    case "3":
                        Console.WriteLine("Ingrese el 1er  numero");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el 2do numero");

                        int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", x, y, Resta(x, y));
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("Ingrese el 1er  numero");
                        double m = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el 2do numero");

                        double n = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("El producto de {0} y {1} es {2}", m, n, Multiplicacion(m, n));
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.WriteLine("Ingrese el 1er  numero");
                        double c = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el 2do numero");

                        double d = Convert.ToDouble(Console.ReadLine());
                        if (d == 0)
                        {
                            Console.WriteLine("Error...No existe dicho cociente!!!");
                            
                        }
                        else
                        {
                            Console.WriteLine("El cociente de {0} y {1} es {2}", c, d, Division(c, d));
                        }
                        
                        Console.ReadKey();
                        break;

                    case "6":
                        Console.WriteLine("Los 10 primeros numeros primos:");
                        num_primos();

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
