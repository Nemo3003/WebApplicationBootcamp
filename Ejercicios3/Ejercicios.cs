using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios3
{
    class Ejercicios
    {
        public class Persona
        {
            public static void  Mayor100()
            {
                //Pedir un numero al usuario
                Console.WriteLine("Ingrese un numero");
                int num = int.Parse(Console.ReadLine());
                //ver si es mayor a 100
                if (num > 100)
                {
                    Console.WriteLine("El numero es mayor a 100");
                }
                else
                {
                    Console.WriteLine("El numero es menor a 100");
                }
            }
        }
    }
}
