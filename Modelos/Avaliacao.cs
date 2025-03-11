namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public int Nota { get; }

    public Avaliacao(int nota)
    {
        if (nota > 10)
            nota = 10;

        if (nota < 0)
            nota = 0;

        Nota = nota;
    }

    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}
