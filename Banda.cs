class Banda
{
    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    private List<Album> Albuns = new List<Album>();

    public void AdicionarAlbum(Album album)
    {
        Albuns.Add(album);
    }

    public void DiscografiaDaBanda()
    {
        Console.WriteLine($"Discografia da banda {Nome}:");
        foreach (var album in Albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} - {album.DuracaoTotal} segundos");
        }
    }
}