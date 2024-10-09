using Calculadora;
using System.Runtime.CompilerServices;

namespace CalculadoraTest;

public class CalculadoraTest
{
    private CalculadoraModel InstanciaCalculadora() => new CalculadoraModel("01/01/2024");
    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(3, 6, 9)]
    public void DeveSomar_InformandoValores_ResultaCorretamente(int a, int b, int resultado)
    {
        // Arrange
        var calculadora = InstanciaCalculadora();

        // Act
        var resultadoCalculado = calculadora.Soma(a, b);
        // Assert
        Assert.Equal(resultado, resultadoCalculado);

    }

    [Theory]
    [InlineData(1, 1, 0)]
    [InlineData(3, 6, -3)]
    public void DeveSubtrair_InformandoValores_ResultaCorretamente(int a, int b, int resultado)
    {
        // Arrange
        var calculadora = InstanciaCalculadora();

        // Act
        var resultadoCalculado = calculadora.Subtracao(a, b);
        // Assert

        Assert.Equal(resultado, resultadoCalculado);

    }

    [Theory]
    [InlineData(1, 1, 1)]
    [InlineData(3, 6, 18)]
    public void DeveMultiplicar_InformandoValores_ResultaCorretamente(int a, int b, int resultado)
    {
        // Arrange
        var calculadora = InstanciaCalculadora();

        // Act
        var resultadoCalculado = calculadora.Multiplicacao(a, b);
        // Assert

        Assert.Equal(resultado, resultadoCalculado);

    }

    [Theory]
    [InlineData(1, 1, 1)]
    [InlineData(6, 3, 2)]
    public void DeveDividir_InformandoValores_ResultaCorretamente(int a, int b, int resultado)
    {
        // Arrange
        var calculadora = InstanciaCalculadora();

        // Act
        var resultadoCalculado = calculadora.Divisao(a, b);
        // Assert

        Assert.Equal(resultado, resultadoCalculado);

    }

    [Fact]
    public void DeveRetornarHistorico_InformandoOperacoes_ResultaCorretamente()
    {
        // Arrange
        var calculadora = InstanciaCalculadora();

        // Act
        calculadora.Soma(1, 1);
        calculadora.Subtracao(1, 1);
        calculadora.Multiplicacao(1, 1);
        calculadora.Divisao(1, 1);
        var historico = calculadora.GetHistorico();
        // Assert

        Assert.Equal(3, historico.Count);

    }

    [Fact]
    public void DeveDividir_InformandoZero_ResultaExcecao()
    {
        // Arrange
        var calculadora = InstanciaCalculadora();

        // Act
        Action act = () => calculadora.Divisao(1, 0);

        // Assert

        Assert.Throws<DivideByZeroException>(act);

    }
}