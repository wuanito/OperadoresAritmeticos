using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresAritmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte num1 = 20;
            byte num2 = 10;

            int suma = num1 + num2;
            int resta = num1 - num2;
            int multiplicacion = num1 * num2;
            int division = num1 / num2;
            Console.WriteLine("La suma es : {0} y la resta es : {1}, la multiplicacion es {2} la division es {3}", suma,resta,multiplicacion,division);
            Console.ReadLine();
        }
    }
}
