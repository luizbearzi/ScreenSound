class Podcast
{
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public Episodio Episodio { get; set; }

    private List<Episodio> episodioList = new List<Episodio>();
    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodioList.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        //Adiciona um episódio a lista
        episodioList.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"PodCast: {Nome}, apresentado por {Host}\n");

        foreach (Episodio episodio in episodioList.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\n\nEsse Podcast possui {TotalEpisodios} episódios.");
    }
}