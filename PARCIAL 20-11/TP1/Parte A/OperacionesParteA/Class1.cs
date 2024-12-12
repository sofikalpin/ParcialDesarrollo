using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesParteA
{
    public class Aritmetica
    {
        public double Sumar(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Restar(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Dividir(double num1, double num2)
        {
            if (num2 == 0)
                throw new DivideByZeroException("No se puede dividir por cero");
            return (num1 / num2);
        }

    }
    public class Logica
    {
        public bool And(bool num1, bool num2)
        {
            return num1 && num2;
        }
        public bool Or(bool num1, bool num2)
        {
            return num1 || num2;
        }
        public bool Not(bool num)
        {
            return !num;
        }
    }
}
