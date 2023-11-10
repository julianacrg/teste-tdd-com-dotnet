using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    [Theory]
    [InlineData(1, 4, 5)]
    [InlineData(4, 5, 9)]
    [InlineData(6, 1, 7)]
    public void DeveSomarDoisValoresInteirosERetornarUmValorInteriro(int val1, int val2, int resultado)
    {
        int resultadoTeste = _calc.Somar(val1, val2);

        Assert.Equal(resultado, resultadoTeste);
    }

    [Theory]
    [InlineData(7, 4, 3)]
    [InlineData(9, 2, 7)]
    [InlineData(15, 13, 2)]
    public void DeveSubtrairDoisValoresInteirosERetornarUmValorInteriro(int val1, int val2, int resultado)
    {
        int resultadoTeste = _calc.Subtrair(val1, val2);

        Assert.Equal(resultado, resultadoTeste);
    }

    [Theory]
    [InlineData(7, 2, 14)]
    [InlineData(4, 1, 4)]
    [InlineData(1, 13, 13)]
    public void DeveMultiplicarDoisValoresInteirosERetornarUmValorInteriro(int val1, int val2, int resultado)
    {
        int resultadoTeste = _calc.Multiplicar(val1, val2);

        Assert.Equal(resultado, resultadoTeste);
    }

    [Theory]
    [InlineData(8, 2, 4)]
    [InlineData(40, 4, 10)]
    [InlineData(15, 3, 5)]
    public void DeveDividirDoisValoresInteirosERetornarUmValorInteriro(int val1, int val2, int resultado)
    {
        int resultadoTeste = _calc.Dividir(val1, val2);

        Assert.Equal(resultado, resultadoTeste);
    }

    [Fact]
    public void DeveTestarDivisaoPorZeroERetornarErro()
    {
        Assert.Throws<DivideByZeroException>(
            () => _calc.Dividir(3,0)
        );
    }

    [Fact]
    public void DeveVerificarSeHistoricoExiste()
    {
        _calc.Somar(1, 2);
        _calc.Somar(6, 3);
        _calc.Somar(7, 1);
        _calc.Somar(14, 7);

        var lista = _calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }

}