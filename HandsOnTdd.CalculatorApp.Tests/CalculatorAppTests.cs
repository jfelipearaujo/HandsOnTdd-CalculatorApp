using FluentAssertions;

using Xunit;

namespace HandsOnTdd.CalculatorApp.Tests
{
    public class CalculatorAppTests
    {
        [Fact]
        public void Deve_Somar_Dois_Numeros_Com_Sucesso()
        {
            // Arrange
            var calculadora = new Calculadora();

            var numero1 = 10;
            var numero2 = 5;

            var resultadoEsperado = 15;

            // Act
            var resultado = calculadora.Somar(numero1, numero2);

            // Assert
            resultado.Should().Be(resultadoEsperado);
        }

        [Fact]
        public void Deve_Subtrair_Dois_Numeros_Com_Sucesso()
        {
            // Arrange
            var calculadora = new Calculadora();

            var numero1 = 20;
            var numero2 = 10;

            var resultadoEsperado = 10;

            // Act
            var resultado = calculadora.Subtrair(numero1, numero2);

            // Assert
            resultado.Should().Be(resultadoEsperado);
        }

        [Fact]
        public void Deve_Multiplicar_Dois_Numeros_Com_Sucesso()
        {
            // Arrange
            var calculadora = new Calculadora();

            var numero1 = 4;
            var numero2 = 2;

            var resultadoEsperado = 8;

            // Act
            var resultado = calculadora.Multiplicar(numero1, numero2);

            // Assert
            resultado.Should().Be(resultadoEsperado);
        }

        [Fact]
        public void Deve_Dividir_Dois_Numeros_Com_Sucesso()
        {
            // Arrange
            var calculadora = new Calculadora();

            var numero1 = 10;
            var numero2 = 2;

            var resultadoEsperado = 5;

            // Act
            var resultado = calculadora.Dividir(numero1, numero2);

            // Assert
            resultado.Should().Be(resultadoEsperado);
        }

        [Fact]
        public void Deve_Somar_Varios_Numeros_Com_Sucesso()
        {
            // Arrange
            var calculadora = new Calculadora();

            var numeros = new int[]
            {
                1,
                4,
                3,
                2
            };

            var resultadoEsperado = 10;

            // Act
            var resultado = calculadora.SomarVariosNumeros(numeros);

            // Assert
            resultado.Should().Be(resultadoEsperado);
        }

        [Fact]
        public void Deve_Subtrair_Varios_Numeros_Com_Sucesso()
        {
            // Arrange
            var calculadora = new Calculadora();

            var numeros = new int[]
            {
                10,
                7,
                2
            };

            var resultadoEsperado = 1;

            // Act
            var resultado = calculadora.SubtrairVariosNumeros(numeros);

            // Assert
            resultado.Should().Be(resultadoEsperado);
        }
    }
}
