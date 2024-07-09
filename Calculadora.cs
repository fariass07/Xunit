using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Calculadora
    {
        public static double Somar(double x, double y)
        {
            return x + y;
        }

        public static double Subtrair(double x, double y)
        {
            return x - y;
        }
        public static double Multiplicar(double x, double y)
        {
            return x * y;
        }

        public static double Dividir(double x, double y)
        {
            return x / y;
        }
    }
}
