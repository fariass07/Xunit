using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConsoleApp1
{
    public class CalculadoraTeste
    {
        [Fact]
        public void TesteSomar()
        {
            double resultado = Calculadora.Somar(3, 2);
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void TesteSubtrair()
        {
            double resultado = Calculadora.Subtrair(3, 2);
            Assert.Equal(1, resultado);
        }

        [Fact]
        public void TesteMultiplicar()
        {
            double resultado = Calculadora.Multiplicar(3, 2);
            Assert.Equal(6, resultado);
        }

        [Fact]
        public void TesteDividir()
        {
            double resultado = Calculadora.Dividir(3, 2);
            Assert.Equal(1.5, resultado);
        }

        [Fact]
        public void TesteDividirZero()
        {
            double resultado = Calculadora.Dividir(3, 0);
            Assert.Equal(double.PositiveInfinity, resultado);
        }
    }
}   
