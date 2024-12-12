namespace Biblio
{
    public class Servicio : IServicio
    {
        public double obtenerdiv(double num1, double num2)
        {
            if (num2 == 0) {
                throw new DivideByZeroException("No se puede dividir por 0");
            }

            double result = num1 / num2;

            return result;

        }
    }
}
