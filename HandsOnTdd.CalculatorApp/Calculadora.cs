using System.Linq;

namespace HandsOnTdd.CalculatorApp
{
    public class Calculadora
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Dividir(int a, int b)
        {
            return a / b;
        }

        public int SomarVariosNumeros(int[] numeros)
        {
            return numeros.Sum();
        }

        public int SubtrairVariosNumeros(int[] numeros)
        {
            var total = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                total -= numeros[i];
            }

            return total;
        }
    }
}
