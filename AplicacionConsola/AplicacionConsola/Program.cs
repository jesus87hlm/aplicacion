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
            Console.WriteLine("Hola Mundo!");
            var p = new Program();
            p.tablasMultiplicar();
            Console.ReadKey();
        }

        public void tablasMultiplicar()
        {

            for(int i=1; i<=10; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
