using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aquí empieza nuestro programa! Bien!");
            // Creamos un objeto de la clase Program (esta misma)
            var p = new Program();
            // Llamamos a nuestro método de tablas de multiplicar
            p.tablasMultiplicar();
            // Llamamos a nuestro método de multiplicar dos números
            p.operaDosNumeros();


            // Esto es para que no se cierre la consola hasta que pulsemos
            Console.ReadKey();
        }

        /// <summary>
        /// Método que muestra las tablas de multiplicar del 1 al 10
        /// </summary>
        public void tablasMultiplicar()
        {

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("============================");
                Console.WriteLine("Tabla de Multiplicar del {0}", i);
                Console.WriteLine("============================");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0}*{1}={2}", i, j, i * j);
                }
            }

        }

        /// <summary>
        /// Método que se encarga de recoger dos números y mandarlos a hacer algo
        /// </summary>
        public void operaDosNumeros()
        {
            // Declaramos dos variables que usaremos para meter el valor de salida
            float primero, segundo;
            // Necesitamos esto por si el TryParse falla
            bool convierte;
            // Obtenemos dos números leyendo, float.TryParse comprueba si puede convertir la cadena que metemos a float
            // En caso de no poder lo capturamos en nuestro boolean, además el resultado lo mete en las variables primero y segundo
            Console.WriteLine("Introduce el primer número:");
            convierte = float.TryParse(Console.ReadLine(), out primero);
            Console.WriteLine("Introduce el segundo número:");
            convierte = float.TryParse(Console.ReadLine(), out segundo);

            if (convierte)
                Console.WriteLine("La multiplicación es: {0}*{1}={2}", primero, segundo, multiplicar(primero, segundo));
            else
                Console.WriteLine("No has metido números!");
        }

        /// <summary>
        /// Método que multiplica dos números dados
        /// </summary>
        /// <param name="primero"></param>
        /// <param name="segundo"></param>
        /// <returns></returns>
        public float multiplicar(float primero, float segundo)
        {
            return primero * segundo;
        }


    }
}
