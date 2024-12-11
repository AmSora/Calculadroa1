using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora1.Tests
{
    [TestClass()]
    public class CalculadoraFuncionesTests
    {
        [TestMethod()]

        public void SumarTest()
        {
            // Arrange
            int num1 = 3;
            int num2 = 3;
            CalculadoraFunciones calculadora = new CalculadoraFunciones(num1, num2);

            // Act
            int resultado = calculadora.Sumar();

            // Assert
            Assert.AreEqual(6, resultado);
        }

        [TestMethod()]
        public void RestarTest()
        {
            // Arrange
            int num1 = 2;
            int num2 = 1;
            CalculadoraFunciones calculadora = new CalculadoraFunciones(num1, num2);

            // Act
            int resultado = calculadora.Restar();

            // Assert
            Assert.AreEqual(1, resultado);
        }

        [TestMethod()]
        public void MultiplicarTest()
        {
            // Arrange
            int num1 = 4;
            int num2 = 1;
            CalculadoraFunciones calculadora = new CalculadoraFunciones(num1, num2);

            // Act
            int resultado = calculadora.Multiplicar();

            // Assert
            Assert.AreEqual(3, resultado);
        }

        [TestMethod()]
        public void DividirTest()
        {
            // Caso 1: División válida
            int num1 = 6;
            int num2 = 3;
            CalculadoraFunciones calculadora = new CalculadoraFunciones(num1, num2);
            int resultado = calculadora.Dividir();
            Assert.AreEqual(2, resultado);

            // Caso 2: División por cero
            num1 = 3;
            num2 = 0;
            CalculadoraFunciones calculadora2 = new CalculadoraFunciones(num1, num2);
            Assert.ThrowsException<DivideByZeroException>(() => calculadora2.Dividir());
        }
    }
}