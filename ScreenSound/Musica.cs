class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome {  get; }
    public Banda Artista { get; }

    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence ao artista {Artista}";
     



    public void ExibeFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel == true)
        {
            Console.WriteLine("Está disponível no plano!");
        } else
        {
            Console.WriteLine("Adquira o Plano PLus+!");
        }
    }
}