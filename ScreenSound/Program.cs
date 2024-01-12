
Banda queen = new Banda("Queen");

Album albumdoQueen = new Album("A Night at the Opera");

Musica musica1 = new Musica(queen, "Love of my Life")
{
    Duracao = 255,
    Disponivel = true,
};


Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 356,
    Disponivel = false,
};


albumdoQueen.AdicionarMusica(musica1);
albumdoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumdoQueen);

musica1.ExibeFichaTecnica();
musica2.ExibeFichaTecnica();
albumdoQueen.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();


Console.WriteLine("********************** DESAFIO PODCAST E EPISODIO **********************");

Episodio episodio1 = new Episodio(1, "Iniciando C#", 60);
episodio1.AdicionarConvidado("Mario");
episodio1.AdicionarConvidado("Lucas");

Episodio episodio2 = new Episodio(2, "Entendendo C#", 90);
episodio2.AdicionarConvidado("Oliveira");
episodio2.AdicionarConvidado("Antonio");

Episodio episodio3 = new Episodio(3, "Avançando com C#", 74);
episodio3.AdicionarConvidado("Ana");
episodio3.AdicionarConvidado("Mauro");


Podcast podcast1 = new Podcast("Programando C#", "Bearzi");
podcast1.AdicionarEpisodio(episodio1);
podcast1.AdicionarEpisodio(episodio2);
podcast1.AdicionarEpisodio(episodio3);
podcast1.ExibirDetalhes();



