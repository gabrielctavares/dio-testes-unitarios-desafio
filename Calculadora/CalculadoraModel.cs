namespace Calculadora;

public class CalculadoraModel(string data)
{
    private const int historicoCapacidade = 3;
    private List<string> Historico = new List<string>();
    public int Soma(int a, int b)
    {
        var resultado = a + b;
        Historico.Insert(0, $"Data: {data} - {a} + {b} = {resultado}");
        return resultado;
    }
    public int Subtracao(int a, int b)
    {
        var resultado = a - b;
        Historico.Insert(0, $"Data: {data} - {a} - {b} = {resultado}");
        return resultado;
    }
    public int Multiplicacao(int a, int b)
    {
        var resultado = a * b;
        Historico.Insert(0, $"Data: {data} - {a} * {b} = {resultado}");
        return resultado;
    }
    public int Divisao(int a, int b)
    {
        var resultado = a / b;
        Historico.Insert(0, $"Data: {data} - {a} / {b} = {resultado}");
        return resultado;
    }
    public List<string> GetHistorico()
    {
        Historico.RemoveRange(historicoCapacidade, Historico.Count - historicoCapacidade);
        return Historico;
    }
}
