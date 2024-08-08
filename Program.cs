using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Digite a Marca do carro: ");
        string MarcaCarro = Console.ReadLine();
        Console.Write("Digite a cor do carro: ");
        string CorCarro = Console.ReadLine();
        Console.Write("Digite o ano do carro: ");
        int AnoCarro = int.Parse(Console.ReadLine());

        Carro MeuCarro = new Carro(MarcaCarro, CorCarro, AnoCarro);

        Console.WriteLine("");
        MeuCarro.Ligar();
        MeuCarro.Desligar();
        Console.WriteLine("");
        MeuCarro.Acelerar();
        MeuCarro.Frear();
        Console.WriteLine("");
        MeuCarro.AbrirPorta();
        MeuCarro.FecharPorta();
        Console.WriteLine("");
        MeuCarro.LigarFarol();
        MeuCarro.DesligarFarol();
        Console.WriteLine("");
        MeuCarro.LigarArCondicionado();
        MeuCarro.DesligarArCondicionado();
        Console.WriteLine("");
        MeuCarro.ExibirInformações();

    }
}