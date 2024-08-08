abstract class Veiculo
{
    public string Marca { get; set; }
    public string Cor { get; set; }
    public int Ano { get; set; }

    protected Veiculo(string marca, string cor, int ano)
    {
        Marca = marca;
        Cor = cor;
        Ano = ano;
    }

    public void ExibirInformações()
    {
        Console.WriteLine($"Marca: {Marca}, Cor: {Cor} e Ano: {Ano}");
    }

    public abstract void Ligar();
    public abstract void Desligar();
    public abstract void Acelerar();
    public abstract void Frear();
}