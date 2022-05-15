using FluentAssertions;

using System;

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

        [Fact]
        public void Nao_Deve_Somar_Varios_Numeros_Quando_Receber_Lista_Com_Apenas_Um_Item()
        {
            // Arrange
            var calculadora = new Calculadora();

            var numeros = new int[]
            {
                1
            };

            // Act
            Action action = () => calculadora.SomarVariosNumeros(numeros);

            // Assert
            action.Should().Throw<ArgumentException>()
                .WithMessage("A lista deve ter pelo menos 2 itens para serem somados");
        }

        [Theory]
        [InlineData(new int[] { })]
        [InlineData(null)]
        public void Nao_Deve_Somar_Varios_Numeros_Quando_Receber_Lista_Vazia(int[] numeros)
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            Action action = () => calculadora.SomarVariosNumeros(numeros);

            // Assert
            action.Should().Throw<ArgumentException>()
                .WithMessage("A lista não pode estar vazia");
        }

        [Fact]
        public void Nao_Deve_Subtrair_Varios_Numeros_Quando_Receber_Lista_Com_Apenas_Um_Item()
        {
            // Arrange
            var calculadora = new Calculadora();

            var numeros = new int[]
            {
                1
            };

            // Act
            Action action = () => calculadora.SubtrairVariosNumeros(numeros);

            // Assert
            action.Should().Throw<ArgumentException>()
                .WithMessage("A lista deve ter pelo menos 2 itens para serem subtraídos");
        }

        [Theory]
        [InlineData(new int[] { })]
        [InlineData(null)]
        public void Nao_Deve_Subtrair_Varios_Numeros_Quando_Receber_Lista_Vazia(int[] numeros)
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            Action action = () => calculadora.SubtrairVariosNumeros(numeros);

            // Assert
            action.Should().Throw<ArgumentException>()
                .WithMessage("A lista não pode estar vazia");
        }

        [Fact]
        public void Deve_Calcular_Valor_Do_Produto_Com_Desconto_Com_Sucesso()
        {
            // Arrange
            var calculadora = new Calculadora();

            var precoProduto = 100d;
            var valorDesconto = 0.1d;

            var resultadoEsperado = 90d;

            // Act
            var resultado = calculadora.CalcularDescontoProduto(precoProduto, valorDesconto);

            // Assert
            resultado.Should().Be(resultadoEsperado);
        }

        [Fact]
        public void Nao_Deve_Calcular_Valor_Do_Produto_Com_Desconto_Quando_Receber_Descondo_Menor_Zero()
        {
            // Arrange
            var calculadora = new Calculadora();

            var precoProduto = 100d;
            var valorDesconto = -1d;

            // Act
            Action action = () => calculadora.CalcularDescontoProduto(precoProduto, valorDesconto);

            // Assert
            action.Should().Throw<ArgumentException>()
                .WithMessage("O valor do desconto não pode ser menor que 0%");
        }

        [Fact]
        public void Nao_Deve_Calcular_Valor_Do_Produto_Com_Desconto_Quando_Receber_Descondo_Maior_Um()
        {
            // Arrange
            var calculadora = new Calculadora();

            var precoProduto = 100d;
            var valorDesconto = 2d;

            // Act
            Action action = () => calculadora.CalcularDescontoProduto(precoProduto, valorDesconto);

            // Assert
            action.Should().Throw<ArgumentException>()
                .WithMessage("O valor do desconto não pode ser maior que 100%");
        }

        [Theory]
        [InlineData(0d)]
        [InlineData(-1d)]
        public void Nao_Deve_Calcular_Valor_Do_Produto_Com_Desconto_Quando_Receber_Valor_Menor_Zero(double precoProduto)
        {
            // Arrange
            var calculadora = new Calculadora();

            var valorDesconto = 0.5d;

            // Act
            Action action = () => calculadora.CalcularDescontoProduto(precoProduto, valorDesconto);

            // Assert
            action.Should().Throw<ArgumentException>()
                .WithMessage("O valor do produto não pode ser menor ou igual a zero");
        }

        [Fact]
        public void Deve_Calcular_Valor_Do_Produto_Quando_Usuario_For_Vip()
        {
            // Arrange
            var calculadora = new Calculadora();

            var usuarioVip = true;
            var precoProduto = 100d;
            var valorDescondo = 0.1;

            var resultadoEsperado = 70d;

            // Act
            var resultado = calculadora.CalcularDescontoProdutoPorUsuario(usuarioVip, precoProduto, valorDescondo);

            // Assert
            resultado.Should().Be(resultadoEsperado);
        }

        [Fact]
        public void Deve_Calcular_Valor_Do_Produto_Quando_Usuario_Nao_Vip()
        {
            // Arrange
            var calculadora = new Calculadora();

            var usuarioVip = false;
            var precoProduto = 100d;
            var valorDescondo = 0.1;

            var resultadoEsperado = 90d;

            // Act
            var resultado = calculadora.CalcularDescontoProdutoPorUsuario(usuarioVip, precoProduto, valorDescondo);

            // Assert
            resultado.Should().Be(resultadoEsperado);
        }

        [Fact]
        public void Nao_Deve_Calcular_Valor_Do_Produto_Quando_Usuario_Nao_Vip_Receber_Desconto_Mair_Vip()
        {
            // Arrange
            var calculadora = new Calculadora();

            var usuarioVip = false;
            var precoProduto = 100d;
            var valorDescondo = 0.5;

            // Act
            Action action = () => calculadora.CalcularDescontoProdutoPorUsuario(usuarioVip, precoProduto, valorDescondo);

            // Assert
            action.Should().Throw<ArgumentException>()
                .WithMessage("O descondo para o cliente não VIP é inválido");
        }
    }
}
