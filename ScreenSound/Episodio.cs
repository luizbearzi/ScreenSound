class Episodio
{
    public Episodio(int ordem, string titulo, double duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    private List<string> convidados = new(); 

    public int Ordem { get; }
    public string Titulo { get; }
    public double Duracao { get; }
    public string Resumo => $"{Ordem}. {Titulo}, Duração: ({Duracao} min) - Convidados: {string.Join(", ", convidados)}";

    public void AdicionarConvidado(string convidado)
    {
        convidados.Add(convidado);
    }
}