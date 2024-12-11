using System;

namespace Calculadora1
{
    public class CalculadoraFunciones
    {
        private int numero1;
        private int numero2;

        public CalculadoraFunciones(int num1, int num2)
        {
            numero1 = num1;
            numero2 = num2;
        }

        public int Sumar()
        {
            return numero1 + numero2;
        }

        public int Restar()
        {
            return numero1 - numero2;
        }

        public int Multiplicar()
        {
            return numero1 * numero2;
        }

        public int Dividir()
        {
            if (numero2 == 0)
                throw new DivideByZeroException("No se puede dividir entre cero.");
            return numero1 / numero2;
        }
    }
}