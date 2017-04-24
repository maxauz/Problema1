using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problema1: Ingrese la cadena de caracteres");
          string cadena=  Console.ReadLine();
          Console.WriteLine("El Resultado es:" + ChangeString.build(cadena));
          Console.ReadLine();
        }
    }
}
