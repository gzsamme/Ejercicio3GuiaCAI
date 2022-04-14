using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3GuiaCAI
{
    class Ejercicio3GuiaCAI
    {
        //15. Solicite un ingreso al usuario y determine si puede ser interpretado como un valor numérico.
        public void EJ15()
        {
            while (true)
            {
                Console.WriteLine("Por favor ingrese algo");
                string ingreso = Console.ReadLine();
                if(!int.TryParse(ingreso, out int salida))
                {
                    Console.WriteLine("El ingreso no es interpretado como un numero");
                }
                else
                {
                    Console.WriteLine("El valor es interpretado como un numero y es el " + salida);
                }
                break;
            }
        }

        public void EJ16()
        {
            //16. Solicite un ingreso al usuario y determine si puede ser interpretado como un número entero.
            //(De aquí en más todos los ingresos del usuario deben ser verificados,
            //finalizando el programa con un mensaje de error en caso de ser inválidos)
            while (true)
            {
                Console.WriteLine("Por favor ingrese algo");
                string ingreso = Console.ReadLine();
                if (!int.TryParse(ingreso, out int salida))
                {
                    Console.WriteLine("El ingreso no es interpretado como un numero entero");
                }
                else
                {
                    Console.WriteLine("El valor es interpretado como un numero y es el " + salida);
                }
                break;
            }

        }

        public void EJ17()
        {
            //17. Solicite el ingreso de dos números al usuario y presente la suma, la resta,
            //la multiplicación, la división, el resto, el primero elevado a la potencia del segundo.

            Console.WriteLine("Por favor ingrese 2 numeros");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numero1 + numero2);
            Console.WriteLine(numero1 - numero2);
            Console.WriteLine(numero1 * numero2);
            Console.WriteLine(numero1 / numero2);
            Console.WriteLine(numero1 % numero2);
            Console.WriteLine(Math.Pow(numero1, numero2));
        }

        public void EJ18()
        {
            //18. Solicite el ingreso de un número al usuario y lo presente redondeado a dos decimales.
            Console.WriteLine("Por favor ingrese un numero");
            decimal numero1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(Math.Round(numero1, 2));
        }

        public void EJ19()
        {
            //19. Solicite el ingreso de un número al usuario y presente la parte entera.
            Console.WriteLine("Por favor ingrese un numero");
            decimal numero1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(Math.Truncate(numero1));
        }

        public void EJ20()
        {
            //20. Solicite el ingreso de 2 números al usuario y determine el mayor.
            Console.WriteLine("Por favor ingrese 2 numeros");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());
            if (numero1 > numero2 & numero1 != numero2)
            {
                Console.WriteLine("el numero 1 es mayor");
            }
            if (numero1 < numero2 & numero1 != numero2)
            {
                Console.WriteLine("el numero 2 es mayor");
            }            

        }






    }
}
