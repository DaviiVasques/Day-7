class Carro: Veiculo
{
    public Carro(string marca, string cor, int ano)
    :base(marca,cor,ano)
    {
    }
    public override void Ligar()
    {
        Console.WriteLine("Carro ligado.");
    }

    public override void Desligar()
    {
        Console.WriteLine("Carro desligado.");
    }

    public override void Acelerar()
    {
        Console.WriteLine("Carro acelerando.");
    }

    public override void Frear()
    {
        Console.WriteLine("Carro freando.");
    }

    public void AbrirPorta()
    {
        Console.WriteLine("Porta do carro aberta.");
    }

    public void FecharPorta()
    {
        Console.WriteLine("Porta do carro fechada.");
    }

    public void LigarArCondicionado()
    {
        Console.WriteLine("Ar-condicionado do carro ligado.");
    }

    public void DesligarArCondicionado()
    {
        Console.WriteLine("Ar-condicionado do carro desligado.");
    }

    public void LigarFarol()
    {
        Console.WriteLine("Farol do carro ligado.");
    }

    public void DesligarFarol()
    {
        Console.WriteLine("Farol do carro desligado.");
    }
}
