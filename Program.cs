Genero genero = new Genero() { Nome = "Forró" };

Banda forrozeira = new Banda("Forrozeira");

Musica musica1 = new Musica(forrozeira, "Roxane")
{
    Duracao = 245,
    Genero = genero,
    Disponivel = true,
};

Musica musica2 = new Musica(forrozeira, "Ah le lek")
{
    Duracao = 100,
    Genero = genero,
    Disponivel = true,
};

Album album = new Album("Álbum top");
album.AdicionarMusica(musica1);
album.AdicionarMusica(musica2);

forrozeira.AdicionarAlbum(album);

musica1.ExibirFichaTecnica();
Console.WriteLine();
musica2.ExibirFichaTecnica();
Console.WriteLine();

forrozeira.DiscografiaDaBanda();
Console.WriteLine();
album.ExibirMusicas();
