using System;
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
            if (numeros is null || numeros.Length == 0)
            {
                throw new ArgumentException("A lista não pode estar vazia");
            }

            if (numeros.Length == 1)
            {
                throw new ArgumentException("A lista deve ter pelo menos 2 itens para serem somados");
            }

            return numeros.Sum();
        }

        public int SubtrairVariosNumeros(int[] numeros)
        {
            if (numeros is null || numeros.Length == 0)
            {
                throw new ArgumentException("A lista não pode estar vazia");
            }

            if (numeros.Length == 1)
            {
                throw new ArgumentException("A lista deve ter pelo menos 2 itens para serem subtraídos");
            }

            var total = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                total -= numeros[i];
            }

            return total;
        }

        public double CalcularDescontoProduto(double precoProduto, double valorDesconto)
        {
            if (precoProduto <= 0d)
            {
                throw new ArgumentException("O valor do produto não pode ser menor ou igual a zero");
            }

            if (valorDesconto < 0d)
            {
                throw new ArgumentException("O valor do desconto não pode ser menor que 0%");
            }

            if (valorDesconto > 1d)
            {
                throw new ArgumentException("O valor do desconto não pode ser maior que 100%");
            }

            var desconto = precoProduto * valorDesconto;

            return precoProduto - desconto;
        }

        public double CalcularDescontoProdutoPorUsuario(bool usuarioVip, double precoProduto, double valorDesconto)
        {
            const double VALOR_DESCONTO_VIP = 0.3d;

            if (usuarioVip)
            {
                return CalcularDescontoProduto(precoProduto, VALOR_DESCONTO_VIP);
            }

            if (valorDesconto > VALOR_DESCONTO_VIP)
            {
                throw new ArgumentException("O descondo para o cliente não VIP é inválido");
            }

            return CalcularDescontoProduto(precoProduto, valorDesconto);
        }
    }
}
